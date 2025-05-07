namespace Lab06
{
    partial class bai3Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bai3Client));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.chatScreenRichTextBox = new System.Windows.Forms.RichTextBox();
            this.importTextBox = new System.Windows.Forms.TextBox();
            this.settingGroupBox = new System.Windows.Forms.GroupBox();
            this.controlGroupBox = new System.Windows.Forms.GroupBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.settingGroupBox.SuspendLayout();
            this.controlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP address:";
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(12, 35);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(233, 31);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click_1);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.disconnectButton.Location = new System.Drawing.Point(12, 83);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(233, 31);
            this.disconnectButton.TabIndex = 4;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(212, 54);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(447, 31);
            this.usernameTextBox.TabIndex = 5;
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextBox.Location = new System.Drawing.Point(132, 83);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(191, 31);
            this.portTextBox.TabIndex = 6;
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddressTextBox.Location = new System.Drawing.Point(132, 35);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.ReadOnly = true;
            this.ipAddressTextBox.Size = new System.Drawing.Size(191, 31);
            this.ipAddressTextBox.TabIndex = 7;
            this.ipAddressTextBox.Text = "127.0.0.1";
            // 
            // chatScreenRichTextBox
            // 
            this.chatScreenRichTextBox.Font = new System.Drawing.Font("Lucida Fax", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatScreenRichTextBox.Location = new System.Drawing.Point(16, 291);
            this.chatScreenRichTextBox.Name = "chatScreenRichTextBox";
            this.chatScreenRichTextBox.Size = new System.Drawing.Size(643, 300);
            this.chatScreenRichTextBox.TabIndex = 8;
            this.chatScreenRichTextBox.Text = "";
            // 
            // importTextBox
            // 
            this.importTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importTextBox.Location = new System.Drawing.Point(16, 611);
            this.importTextBox.Name = "importTextBox";
            this.importTextBox.Size = new System.Drawing.Size(507, 31);
            this.importTextBox.TabIndex = 9;
            // 
            // settingGroupBox
            // 
            this.settingGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.settingGroupBox.Controls.Add(this.label3);
            this.settingGroupBox.Controls.Add(this.ipAddressTextBox);
            this.settingGroupBox.Controls.Add(this.label2);
            this.settingGroupBox.Controls.Add(this.portTextBox);
            this.settingGroupBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingGroupBox.Location = new System.Drawing.Point(16, 123);
            this.settingGroupBox.Name = "settingGroupBox";
            this.settingGroupBox.Size = new System.Drawing.Size(357, 143);
            this.settingGroupBox.TabIndex = 11;
            this.settingGroupBox.TabStop = false;
            this.settingGroupBox.Text = "Setting";
            // 
            // controlGroupBox
            // 
            this.controlGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.controlGroupBox.Controls.Add(this.connectButton);
            this.controlGroupBox.Controls.Add(this.disconnectButton);
            this.controlGroupBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.controlGroupBox.Location = new System.Drawing.Point(408, 123);
            this.controlGroupBox.Name = "controlGroupBox";
            this.controlGroupBox.Size = new System.Drawing.Size(251, 143);
            this.controlGroupBox.TabIndex = 12;
            this.controlGroupBox.TabStop = false;
            this.controlGroupBox.Text = "Control";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(529, 611);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(130, 31);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click_1);
            // 
            // bai3Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(671, 693);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.controlGroupBox);
            this.Controls.Add(this.settingGroupBox);
            this.Controls.Add(this.importTextBox);
            this.Controls.Add(this.chatScreenRichTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "bai3Client";
            this.Text = "Bai3_Client";
            this.settingGroupBox.ResumeLayout(false);
            this.settingGroupBox.PerformLayout();
            this.controlGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.RichTextBox chatScreenRichTextBox;
        private System.Windows.Forms.TextBox importTextBox;
        private System.Windows.Forms.GroupBox settingGroupBox;
        private System.Windows.Forms.GroupBox controlGroupBox;
        private System.Windows.Forms.Button sendButton;
    }
}