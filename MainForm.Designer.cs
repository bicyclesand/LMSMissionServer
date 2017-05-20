/*namespace MGER
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Text = "Form1";
        }

        #endregion
    }
}


*/










﻿namespace MGER
 {
     partial class MainForm
     {
         /// Required designer variable.
         private System.ComponentModel.IContainer components = null;

         /// Clean up any resources being used.
         /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
         protected override void Dispose(bool disposing)
         {
             if (disposing && (components != null))
             {
                 components.Dispose();
             }
             base.Dispose(disposing);
         }

         #region Windows Form Designer generated code

         /// Required method for Designer support - do not modify
         /// the contents of this method with the code editor.
         private void InitializeComponent()
         {
            this.connectionBox = new System.Windows.Forms.GroupBox();
            this.disconnectButton2 = new System.Windows.Forms.Button();
            this.connectButton2 = new System.Windows.Forms.Button();
            this.serialPortSelectionBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connectedDeviceLabel = new System.Windows.Forms.Label();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.scanForSerialPortsButton = new System.Windows.Forms.Button();
            this.selectComPortLabel = new System.Windows.Forms.Label();
            this.serialPortSelectionBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.receivedMessagesBox = new System.Windows.Forms.GroupBox();
            this.clearReceivedMessagesButton = new System.Windows.Forms.Button();
            this.receivedMessagesListBox = new System.Windows.Forms.ListBox();
            this.sendMessageBox = new System.Windows.Forms.GroupBox();
            this.sendMessageButton = new System.Windows.Forms.Button();
            this.messageTypeComboBox = new System.Windows.Forms.ComboBox();
            this.mailboxTitleTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.mailboxLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ev3MEssengerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.connectedDeviceLabel2 = new System.Windows.Forms.Label();
            this.connectionBox.SuspendLayout();
            this.receivedMessagesBox.SuspendLayout();
            this.sendMessageBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectionBox
            // 
            this.connectionBox.Controls.Add(this.connectedDeviceLabel2);
            this.connectionBox.Controls.Add(this.disconnectButton2);
            this.connectionBox.Controls.Add(this.connectButton2);
            this.connectionBox.Controls.Add(this.serialPortSelectionBox2);
            this.connectionBox.Controls.Add(this.label3);
            this.connectionBox.Controls.Add(this.connectedDeviceLabel);
            this.connectionBox.Controls.Add(this.disconnectButton);
            this.connectionBox.Controls.Add(this.scanForSerialPortsButton);
            this.connectionBox.Controls.Add(this.selectComPortLabel);
            this.connectionBox.Controls.Add(this.serialPortSelectionBox);
            this.connectionBox.Controls.Add(this.connectButton);
            this.connectionBox.Location = new System.Drawing.Point(10, 11);
            this.connectionBox.Name = "connectionBox";
            this.connectionBox.Size = new System.Drawing.Size(674, 83);
            this.connectionBox.TabIndex = 4;
            this.connectionBox.TabStop = false;
            this.connectionBox.Text = "EV3 connection setup";
            // 
            // disconnectButton2
            // 
            this.disconnectButton2.Enabled = false;
            this.disconnectButton2.Location = new System.Drawing.Point(433, 42);
            this.disconnectButton2.Name = "disconnectButton2";
            this.disconnectButton2.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton2.TabIndex = 10;
            this.disconnectButton2.Text = "Disconnect";
            this.disconnectButton2.UseVisualStyleBackColor = true;
            this.disconnectButton2.Click += new System.EventHandler(this.disconnectButton2_Click);
            // 
            // connectButton2
            // 
            this.connectButton2.Location = new System.Drawing.Point(341, 42);
            this.connectButton2.Name = "connectButton2";
            this.connectButton2.Size = new System.Drawing.Size(75, 23);
            this.connectButton2.TabIndex = 9;
            this.connectButton2.Text = "Connect";
            this.connectButton2.UseVisualStyleBackColor = true;
            this.connectButton2.Click += new System.EventHandler(this.connectButton2_Click);
            // 
            // serialPortSelectionBox2
            // 
            this.serialPortSelectionBox2.FormattingEnabled = true;
            this.serialPortSelectionBox2.Location = new System.Drawing.Point(214, 44);
            this.serialPortSelectionBox2.Name = "serialPortSelectionBox2";
            this.serialPortSelectionBox2.Size = new System.Drawing.Size(121, 21);
            this.serialPortSelectionBox2.TabIndex = 8;
            this.serialPortSelectionBox2.SelectedIndexChanged += new System.EventHandler(this.serialPortSelectionBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select EV3 serial port";
            // 
            // connectedDeviceLabel
            // 
            this.connectedDeviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDeviceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedDeviceLabel.Location = new System.Drawing.Point(514, 8);
            this.connectedDeviceLabel.Name = "connectedDeviceLabel";
            this.connectedDeviceLabel.Size = new System.Drawing.Size(145, 28);
            this.connectedDeviceLabel.TabIndex = 6;
            this.connectedDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // disconnectButton
            // 
            this.disconnectButton.Enabled = false;
            this.disconnectButton.Location = new System.Drawing.Point(433, 8);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 4;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // scanForSerialPortsButton
            // 
            this.scanForSerialPortsButton.Location = new System.Drawing.Point(6, 13);
            this.scanForSerialPortsButton.Name = "scanForSerialPortsButton";
            this.scanForSerialPortsButton.Size = new System.Drawing.Size(80, 23);
            this.scanForSerialPortsButton.TabIndex = 3;
            this.scanForSerialPortsButton.Text = "Rescan Ports";
            this.scanForSerialPortsButton.UseVisualStyleBackColor = true;
            this.scanForSerialPortsButton.Click += new System.EventHandler(this.scanForSerialPortsButton_Click);
            // 
            // selectComPortLabel
            // 
            this.selectComPortLabel.AutoSize = true;
            this.selectComPortLabel.Location = new System.Drawing.Point(100, 18);
            this.selectComPortLabel.Name = "selectComPortLabel";
            this.selectComPortLabel.Size = new System.Drawing.Size(108, 13);
            this.selectComPortLabel.TabIndex = 2;
            this.selectComPortLabel.Text = "Select EV3 serial port";
            // 
            // serialPortSelectionBox
            // 
            this.serialPortSelectionBox.FormattingEnabled = true;
            this.serialPortSelectionBox.Location = new System.Drawing.Point(213, 10);
            this.serialPortSelectionBox.Name = "serialPortSelectionBox";
            this.serialPortSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.serialPortSelectionBox.TabIndex = 0;
            this.serialPortSelectionBox.SelectedIndexChanged += new System.EventHandler(this.serialPortSelectionBox_SelectedIndexChanged);
            this.serialPortSelectionBox.Leave += new System.EventHandler(this.serialPortSelectionBox_Leave);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(341, 8);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 1;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // receivedMessagesBox
            // 
            this.receivedMessagesBox.Controls.Add(this.clearReceivedMessagesButton);
            this.receivedMessagesBox.Controls.Add(this.receivedMessagesListBox);
            this.receivedMessagesBox.Location = new System.Drawing.Point(351, 100);
            this.receivedMessagesBox.Name = "receivedMessagesBox";
            this.receivedMessagesBox.Size = new System.Drawing.Size(333, 318);
            this.receivedMessagesBox.TabIndex = 5;
            this.receivedMessagesBox.TabStop = false;
            this.receivedMessagesBox.Text = "Received messages";
            // 
            // clearReceivedMessagesButton
            // 
            this.clearReceivedMessagesButton.Location = new System.Drawing.Point(129, 282);
            this.clearReceivedMessagesButton.Name = "clearReceivedMessagesButton";
            this.clearReceivedMessagesButton.Size = new System.Drawing.Size(75, 23);
            this.clearReceivedMessagesButton.TabIndex = 1;
            this.clearReceivedMessagesButton.Text = "Clear";
            this.clearReceivedMessagesButton.UseVisualStyleBackColor = true;
            this.clearReceivedMessagesButton.Click += new System.EventHandler(this.clearReceivedMessagesButton_Click);
            // 
            // receivedMessagesListBox
            // 
            this.receivedMessagesListBox.FormattingEnabled = true;
            this.receivedMessagesListBox.Location = new System.Drawing.Point(14, 21);
            this.receivedMessagesListBox.Name = "receivedMessagesListBox";
            this.receivedMessagesListBox.Size = new System.Drawing.Size(304, 251);
            this.receivedMessagesListBox.TabIndex = 0;
            // 
            // sendMessageBox
            // 
            this.sendMessageBox.Controls.Add(this.sendMessageButton);
            this.sendMessageBox.Controls.Add(this.messageTypeComboBox);
            this.sendMessageBox.Controls.Add(this.mailboxTitleTextBox);
            this.sendMessageBox.Controls.Add(this.messageTextBox);
            this.sendMessageBox.Controls.Add(this.messageLabel);
            this.sendMessageBox.Controls.Add(this.mailboxLabel);
            this.sendMessageBox.Location = new System.Drawing.Point(10, 100);
            this.sendMessageBox.Name = "sendMessageBox";
            this.sendMessageBox.Size = new System.Drawing.Size(334, 132);
            this.sendMessageBox.TabIndex = 6;
            this.sendMessageBox.TabStop = false;
            this.sendMessageBox.Text = "Send message to mailbox";
            // 
            // sendMessageButton
            // 
            this.sendMessageButton.Location = new System.Drawing.Point(261, 80);
            this.sendMessageButton.Margin = new System.Windows.Forms.Padding(2);
            this.sendMessageButton.Name = "sendMessageButton";
            this.sendMessageButton.Size = new System.Drawing.Size(68, 19);
            this.sendMessageButton.TabIndex = 7;
            this.sendMessageButton.Text = "Send";
            this.sendMessageButton.UseVisualStyleBackColor = true;
            this.sendMessageButton.Click += new System.EventHandler(this.sendMessageButton_Click);
            // 
            // messageTypeComboBox
            // 
            this.messageTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.messageTypeComboBox.FormattingEnabled = true;
            this.messageTypeComboBox.Location = new System.Drawing.Point(72, 58);
            this.messageTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageTypeComboBox.Name = "messageTypeComboBox";
            this.messageTypeComboBox.Size = new System.Drawing.Size(68, 21);
            this.messageTypeComboBox.TabIndex = 6;
            // 
            // mailboxTitleTextBox
            // 
            this.mailboxTitleTextBox.Location = new System.Drawing.Point(72, 35);
            this.mailboxTitleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.mailboxTitleTextBox.Name = "mailboxTitleTextBox";
            this.mailboxTitleTextBox.Size = new System.Drawing.Size(258, 20);
            this.mailboxTitleTextBox.TabIndex = 5;
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(144, 58);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(186, 20);
            this.messageTextBox.TabIndex = 4;
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(6, 60);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(50, 13);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "Message";
            // 
            // mailboxLabel
            // 
            this.mailboxLabel.AutoSize = true;
            this.mailboxLabel.Location = new System.Drawing.Point(6, 37);
            this.mailboxLabel.Name = "mailboxLabel";
            this.mailboxLabel.Size = new System.Drawing.Size(62, 13);
            this.mailboxLabel.TabIndex = 2;
            this.mailboxLabel.Text = "Mailbox title";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ev3MEssengerLinkLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(329, 183);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Info";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(214, 70);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 27);
            this.button8.TabIndex = 15;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button7.Location = new System.Drawing.Point(103, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 45);
            this.button7.TabIndex = 14;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(282, 111);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 30);
            this.button6.TabIndex = 13;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(228, 103);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 46);
            this.button5.TabIndex = 12;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(175, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 30);
            this.button4.TabIndex = 11;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Project site:";
            // 
            // ev3MEssengerLinkLabel
            // 
            this.ev3MEssengerLinkLabel.AutoSize = true;
            this.ev3MEssengerLinkLabel.Location = new System.Drawing.Point(7, 70);
            this.ev3MEssengerLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ev3MEssengerLinkLabel.Name = "ev3MEssengerLinkLabel";
            this.ev3MEssengerLinkLabel.Size = new System.Drawing.Size(176, 13);
            this.ev3MEssengerLinkLabel.TabIndex = 1;
            this.ev3MEssengerLinkLabel.TabStop = true;
            this.ev3MEssengerLinkLabel.Text = "http://ev3messenger.codeplex.com";
            this.ev3MEssengerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ev3MEssengerLinkLabel_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "LMS Server";
            // 
            // connectedDeviceLabel2
            // 
            this.connectedDeviceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectedDeviceLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectedDeviceLabel2.Location = new System.Drawing.Point(514, 44);
            this.connectedDeviceLabel2.Name = "connectedDeviceLabel2";
            this.connectedDeviceLabel2.Size = new System.Drawing.Size(145, 28);
            this.connectedDeviceLabel2.TabIndex = 11;
            this.connectedDeviceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 431);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sendMessageBox);
            this.Controls.Add(this.receivedMessagesBox);
            this.Controls.Add(this.connectionBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "LMS Mission Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.connectionBox.ResumeLayout(false);
            this.connectionBox.PerformLayout();
            this.receivedMessagesBox.ResumeLayout(false);
            this.sendMessageBox.ResumeLayout(false);
            this.sendMessageBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

         }

         #endregion

         private System.Windows.Forms.GroupBox connectionBox;
         private System.Windows.Forms.Label connectedDeviceLabel;
         private System.Windows.Forms.Button disconnectButton;
         private System.Windows.Forms.Button scanForSerialPortsButton;
         private System.Windows.Forms.Label selectComPortLabel;
         private System.Windows.Forms.ComboBox serialPortSelectionBox;
         private System.Windows.Forms.Button connectButton;
         private System.Windows.Forms.GroupBox receivedMessagesBox;
         private System.Windows.Forms.Button clearReceivedMessagesButton;
         private System.Windows.Forms.ListBox receivedMessagesListBox;
         private System.Windows.Forms.GroupBox sendMessageBox;
         private System.Windows.Forms.Label messageLabel;
         private System.Windows.Forms.Label mailboxLabel;
         private System.Windows.Forms.ComboBox messageTypeComboBox;
         private System.Windows.Forms.TextBox mailboxTitleTextBox;
         private System.Windows.Forms.TextBox messageTextBox;
         private System.Windows.Forms.Button sendMessageButton;
         private System.Windows.Forms.GroupBox groupBox1;
         private System.Windows.Forms.LinkLabel ev3MEssengerLinkLabel;
         private System.Windows.Forms.Label label1;
         private System.Windows.Forms.Label label2;
         private System.Windows.Forms.Button button8;
         private System.Windows.Forms.Button button7;
         private System.Windows.Forms.Button button6;
         private System.Windows.Forms.Button button5;
         private System.Windows.Forms.Button button4;
         private System.Windows.Forms.Button button2;
         private System.Windows.Forms.ComboBox serialPortSelectionBox2;
         private System.Windows.Forms.Label label3;
         private System.Windows.Forms.Button connectButton2;
         private System.Windows.Forms.Button disconnectButton2;
         private System.Windows.Forms.Label connectedDeviceLabel2;
     }
 }
