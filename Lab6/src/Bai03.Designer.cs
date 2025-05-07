namespace Lab06
{
    partial class bai03Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bai03Form));
            this.label1 = new System.Windows.Forms.Label();
            this.clientButton = new System.Windows.Forms.Button();
            this.serverButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, -20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 224);
            this.label1.TabIndex = 11;
            this.label1.Text = "RSA CODE";
            // 
            // clientButton
            // 
            this.clientButton.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.Location = new System.Drawing.Point(245, 154);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(226, 50);
            this.clientButton.TabIndex = 12;
            this.clientButton.Text = "Client";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // serverButton
            // 
            this.serverButton.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverButton.Location = new System.Drawing.Point(245, 241);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(226, 50);
            this.serverButton.TabIndex = 13;
            this.serverButton.Text = "Server";
            this.serverButton.UseVisualStyleBackColor = true;
            this.serverButton.Click += new System.EventHandler(this.serverButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(245, 330);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(226, 50);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // bai03Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(702, 520);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.serverButton);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.label1);
            this.Name = "bai03Form";
            this.Text = "Bai03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clientButton;
        private System.Windows.Forms.Button serverButton;
        private System.Windows.Forms.Button exitButton;
    }
}