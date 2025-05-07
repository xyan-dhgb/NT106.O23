namespace Bai06
{
    partial class EmailReading
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
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Location = new System.Drawing.Point(13, 13);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(787, 589);
            this.contentRichTextBox.TabIndex = 0;
            this.contentRichTextBox.Text = "";
            // 
            // EmailReading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 614);
            this.Controls.Add(this.contentRichTextBox);
            this.Name = "EmailReading";
            this.Text = "EmailReading";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox contentRichTextBox;
    }
}