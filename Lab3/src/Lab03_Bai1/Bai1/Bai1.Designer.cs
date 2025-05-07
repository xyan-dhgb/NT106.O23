namespace _22520101_DinhHuynhGiaBao_Lab03_Bai1
{
    partial class Bai1Form
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
            this.serverButton = new System.Windows.Forms.Button();
            this.clientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // serverButton
            // 
            this.serverButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverButton.Location = new System.Drawing.Point(282, 83);
            this.serverButton.Name = "serverButton";
            this.serverButton.Size = new System.Drawing.Size(229, 70);
            this.serverButton.TabIndex = 1;
            this.serverButton.Text = "UDP SERVER";
            this.serverButton.UseVisualStyleBackColor = true;
            this.serverButton.Click += new System.EventHandler(this.serverButton_Click);
            // 
            // clientButton
            // 
            this.clientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientButton.Location = new System.Drawing.Point(47, 83);
            this.clientButton.Name = "clientButton";
            this.clientButton.Size = new System.Drawing.Size(229, 70);
            this.clientButton.TabIndex = 2;
            this.clientButton.Text = "UDP CLIENT";
            this.clientButton.UseVisualStyleBackColor = true;
            this.clientButton.Click += new System.EventHandler(this.clientButton_Click);
            // 
            // Bai1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 230);
            this.Controls.Add(this.clientButton);
            this.Controls.Add(this.serverButton);
            this.Name = "Bai1Form";
            this.Text = "Lab03_Bai1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button serverButton;
        private System.Windows.Forms.Button clientButton;
    }
}

