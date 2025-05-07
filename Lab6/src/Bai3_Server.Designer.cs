namespace Lab06
{
    partial class bai3Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bai3Server));
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.chatScreenRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.importTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port:";
            // 
            // portTextBox
            // 
            this.portTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portTextBox.Location = new System.Drawing.Point(86, 69);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(191, 31);
            this.portTextBox.TabIndex = 8;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(321, 68);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(144, 32);
            this.startButton.TabIndex = 9;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click_1);
            // 
            // stopButton
            // 
            this.stopButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.Location = new System.Drawing.Point(477, 68);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(144, 32);
            this.stopButton.TabIndex = 10;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click_1);
            // 
            // chatScreenRichTextBox
            // 
            this.chatScreenRichTextBox.Font = new System.Drawing.Font("Lucida Fax", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatScreenRichTextBox.Location = new System.Drawing.Point(23, 130);
            this.chatScreenRichTextBox.Name = "chatScreenRichTextBox";
            this.chatScreenRichTextBox.Size = new System.Drawing.Size(598, 358);
            this.chatScreenRichTextBox.TabIndex = 11;
            this.chatScreenRichTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(490, 517);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(131, 32);
            this.sendButton.TabIndex = 12;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // importTextBox
            // 
            this.importTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importTextBox.Location = new System.Drawing.Point(23, 518);
            this.importTextBox.Name = "importTextBox";
            this.importTextBox.Size = new System.Drawing.Size(461, 31);
            this.importTextBox.TabIndex = 13;
            // 
            // bai3Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 600);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.importTextBox);
            this.Controls.Add(this.chatScreenRichTextBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portTextBox);
            this.Name = "bai3Server";
            this.Text = "Bai3_Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.RichTextBox chatScreenRichTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox importTextBox;
    }
}