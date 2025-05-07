namespace _22520101_DinhHuynhGiaBao_Lab03_Bai1
{
    partial class UDP_SERVER
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
            this.PortLabel = new System.Windows.Forms.Label();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.ListenButton = new System.Windows.Forms.Button();
            this.ReceivedLabel = new System.Windows.Forms.Label();
            this.ReceivedTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortLabel.Location = new System.Drawing.Point(13, 55);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(47, 25);
            this.PortLabel.TabIndex = 0;
            this.PortLabel.Text = "Port";
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerPortTextBox.Location = new System.Drawing.Point(66, 50);
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.ReadOnly = true;
            this.ServerPortTextBox.Size = new System.Drawing.Size(205, 30);
            this.ServerPortTextBox.TabIndex = 1;
            // 
            // ListenButton
            // 
            this.ListenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListenButton.Location = new System.Drawing.Point(318, 50);
            this.ListenButton.Name = "ListenButton";
            this.ListenButton.Size = new System.Drawing.Size(166, 30);
            this.ListenButton.TabIndex = 2;
            this.ListenButton.Text = "Listen";
            this.ListenButton.UseVisualStyleBackColor = true;
            this.ListenButton.Click += new System.EventHandler(this.ListenButton_Click);
            // 
            // ReceivedLabel
            // 
            this.ReceivedLabel.AutoSize = true;
            this.ReceivedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivedLabel.Location = new System.Drawing.Point(13, 127);
            this.ReceivedLabel.Name = "ReceivedLabel";
            this.ReceivedLabel.Size = new System.Drawing.Size(179, 25);
            this.ReceivedLabel.TabIndex = 3;
            this.ReceivedLabel.Text = "Received Message";
            // 
            // ReceivedTextBox
            // 
            this.ReceivedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivedTextBox.Location = new System.Drawing.Point(18, 177);
            this.ReceivedTextBox.Name = "ReceivedTextBox";
            this.ReceivedTextBox.Size = new System.Drawing.Size(466, 241);
            this.ReceivedTextBox.TabIndex = 4;
            this.ReceivedTextBox.Text = "";
            // 
            // UDP_SERVER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 450);
            this.Controls.Add(this.ReceivedTextBox);
            this.Controls.Add(this.ReceivedLabel);
            this.Controls.Add(this.ListenButton);
            this.Controls.Add(this.ServerPortTextBox);
            this.Controls.Add(this.PortLabel);
            this.Name = "UDP_SERVER";
            this.Text = "UDP_server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.TextBox ServerPortTextBox;
        private System.Windows.Forms.Button ListenButton;
        private System.Windows.Forms.Label ReceivedLabel;
        private System.Windows.Forms.RichTextBox ReceivedTextBox;
    }
}