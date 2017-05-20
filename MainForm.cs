#region licence
/*
The MIT License (MIT)

Copyright (c) 2013 Joeri van Belle

Permission is hereby granted, free of charge, to any person obtaining a copy of
this software and associated documentation files (the "Software"), to deal in
the Software without restriction, including without limitation the rights to
use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/
#endregion

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using EV3MessengerLib;

namespace MGER
{
    public partial class MainForm : Form
    {
        private EV3Messenger messenger;
        private EV3Messenger messenger2;

        private Timer readTimer;
        private Timer readTimer2;


        public MainForm()
        {
            InitializeComponent();
            messageTypeComboBox.Items.AddRange(new string[] { "Text", "Number", "Logic" });
            messageTypeComboBox.SelectedIndex = 0;
            messenger = new EV3Messenger();
            messenger2 = new EV3Messenger();


            readTimer = new Timer();
            readTimer2 = new Timer();


            readTimer.Interval = 10;
            readTimer2.Interval = 10;

            readTimer.Tick += new EventHandler(readTimer_Tick);
            readTimer2.Tick += new EventHandler(readTimer_Tick);


            FillSerialPortSelectionBoxWithAvailablePorts();
            UpdateButtonsAndConnectionInfo();
            UpdateButtonsAndConnectionInfo2();
        }
        private void scanForSerialPortsButton_Click(object sender, EventArgs e)
        {
            FillSerialPortSelectionBoxWithAvailablePorts();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            String port = serialPortSelectionBox.Text;

            if (messenger.Connect(port))
            {
                UpdateButtonsAndConnectionInfo();
                receivedMessagesListBox.Items.Clear();
                readTimer.Start();
            }
            else
            {
                MessageBox.Show("Failed to connect to serial port '" + port + "'.\n"
                    + "Is your EV3 connected to that serial port? Or is it using another one?");
            }
        }

        private void connectButton2_Click(object sender, EventArgs e)
        {
            String port2 = serialPortSelectionBox2.Text;

            if (messenger2.Connect(port2))
            {
                UpdateButtonsAndConnectionInfo2();
                receivedMessagesListBox.Items.Clear();
                readTimer.Start();
            }
            else
            {
                MessageBox.Show("Failed to connect to serial port '" + port2 + "'.\n"
                    + "Is your EV3 connected to that serial port? Or is it using another one?");
            }
        }

        private void disconnectButton_Click(object sender, EventArgs e)
        {
            readTimer.Stop();
            messenger.Disconnect();
            UpdateButtonsAndConnectionInfo();
            UpdateButtonsAndConnectionInfo2();
        }

        private void disconnectButton2_Click(object sender, EventArgs e)
        {
            readTimer2.Stop();
            messenger2.Disconnect();
            UpdateButtonsAndConnectionInfo();
            UpdateButtonsAndConnectionInfo2();
        }

        private void serialPortSelectionBox_Leave(object sender, EventArgs e)
        {
            serialPortSelectionBox.Text = serialPortSelectionBox.Text.ToUpper();
        }

        private void FillSerialPortSelectionBoxWithAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            serialPortSelectionBox.Items.Clear();
            foreach (String port in ports)
            {
                serialPortSelectionBox.Items.Add(port);
                serialPortSelectionBox2.Items.Add(port);
            }
        }

        private void UpdateButtonsAndConnectionInfo()
        {

            bool isConnected = messenger.IsConnected;

            connectButton.Enabled = !isConnected;
            scanForSerialPortsButton.Enabled = !isConnected;
            disconnectButton.Enabled = isConnected;
            //disconnectButton2.Enabled = isConnected;
            //beepTestButton.Enabled = isConnected;

            sendMessageBox.Enabled = isConnected;
            receivedMessagesBox.Enabled = isConnected;

            if (isConnected)
            {
                connectedDeviceLabel.Text = "Connected to:\n" + messenger.Port;
                //connectedDeviceLabel.BackColor = Color.LightGreen;
                connectedDeviceLabel.BackColor = Color.DarkTurquoise;

            }
            else
            {
                connectedDeviceLabel.Text = "No connection";
                connectedDeviceLabel.BackColor = Color.Red;
            }
        }

        private void UpdateButtonsAndConnectionInfo2()
        {

            bool isConnected2 = messenger2.IsConnected;



            connectButton2.Enabled = !isConnected2;
            scanForSerialPortsButton.Enabled = !isConnected2;
            //disconnectButton.Enabled = isConnected;
            disconnectButton2.Enabled = isConnected2;
            //beepTestButton.Enabled = isConnected;

            sendMessageBox.Enabled = isConnected2;
            receivedMessagesBox.Enabled = isConnected2;

            if (isConnected2)
            {
                connectedDeviceLabel2.Text = "Connected to:\n" + messenger2.Port;
                //connectedDeviceLabel.BackColor = Color.LightGreen;
                connectedDeviceLabel2.BackColor = Color.DarkTurquoise;

            }
            else
            {
                connectedDeviceLabel2.Text = "No connection";
                connectedDeviceLabel2.BackColor = Color.Red;
            }
        }

        private void clearReceivedMessagesButton_Click(object sender, EventArgs e)
        {
            receivedMessagesListBox.Items.Clear();
        }

        private void readTimer_Tick(object sender, EventArgs e)
        {


            if (messenger.IsConnected)
            {
                EV3Message message = messenger.ReadMessage();
                if (message != null)
                {
                    // a message was present and is read.
                    receivedMessagesListBox.Items.Add(message);
                }
            }
            else
            {
                readTimer.Stop();
                UpdateButtonsAndConnectionInfo();
            }

        }

        private void sendMessageButton_Click(object sender, EventArgs e)
        {
            if (!messenger.IsConnected)
            {
                MessageBox.Show("Not connected.");
                return;
            }

            string mailboxTitle = mailboxTitleTextBox.Text;
            string message = messageTextBox.Text;

            if (mailboxTitle == "")
            {
                MessageBox.Show("No mailbox title entered. Please enter a mailbox title.");
                return;
            }

            if (message == "")
            {
                MessageBox.Show("No message entered. Please enter a message.");
                return;
            }

            switch (messageTypeComboBox.Text)
            {
                case "Text":
                    {
                        messenger.SendMessage(mailboxTitle, message);
                    }
                    break;

                case "Number":
                    {
                        float numberMessage;
                        if (float.TryParse(message, out numberMessage))
                        {
                            messenger.SendMessage(mailboxTitle, numberMessage);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid single precision floating point number (float).");
                        }
                    }
                    break;

                case "Logic":
                    {
                        bool logicMessage;
                        if (bool.TryParse(message, out logicMessage))
                        {
                            messenger.SendMessage(mailboxTitle, logicMessage);
                        }
                        else
                        {
                            MessageBox.Show("Please enter a valid logic value (\"True\"/\"False\").");
                        }
                    }
                    break;

                default:
                    MessageBox.Show("Unknown message type.");
                    break;
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            readTimer.Stop();
            messenger.Disconnect();
        }

        private void ev3MEssengerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(ev3MEssengerLinkLabel.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("NumberMailbox", 2);
            messenger2.SendMessage("NumberMailbox", 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("NumberMailbox", 4);
            messenger2.SendMessage("NumberMailbox", 4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("NumberMailbox", 5);
            messenger2.SendMessage("NumberMailbox", 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("NumberMailbox", 6);
            messenger2.SendMessage("NumberMailbox", 6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("NumberMailbox", 8);
            messenger2.SendMessage("NumberMailbox", 8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            messenger.SendMessage("NumberMailbox", 7);
            messenger2.SendMessage("NumberMailbox", 7);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void serialPortSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void serialPortSelectionBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
