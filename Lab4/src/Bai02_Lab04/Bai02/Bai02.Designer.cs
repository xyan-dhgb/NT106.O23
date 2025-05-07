namespace Bai02
{
    partial class Bai02Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.downloadTextBox = new System.Windows.Forms.TextBox();
            this.webInputTextBox = new System.Windows.Forms.TextBox();
            this.downloadButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER YOUR WEB";
            // 
            // downloadTextBox
            // 
            this.downloadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadTextBox.Location = new System.Drawing.Point(34, 142);
            this.downloadTextBox.Name = "downloadTextBox";
            this.downloadTextBox.ReadOnly = true;
            this.downloadTextBox.Size = new System.Drawing.Size(456, 34);
            this.downloadTextBox.TabIndex = 1;
            this.downloadTextBox.Text = "D:\\index.html";
            // 
            // webInputTextBox
            // 
            this.webInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webInputTextBox.Location = new System.Drawing.Point(34, 64);
            this.webInputTextBox.Name = "webInputTextBox";
            this.webInputTextBox.Size = new System.Drawing.Size(362, 34);
            this.webInputTextBox.TabIndex = 2;
            // 
            // downloadButton
            // 
            this.downloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.downloadButton.Location = new System.Drawing.Point(508, 64);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(181, 112);
            this.downloadButton.TabIndex = 3;
            this.downloadButton.Text = "DOWNLOAD";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "SAVE TO";
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Location = new System.Drawing.Point(34, 212);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(655, 336);
            this.contentRichTextBox.TabIndex = 5;
            this.contentRichTextBox.Text = "";
            // 
            // Bai02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 573);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.downloadButton);
            this.Controls.Add(this.webInputTextBox);
            this.Controls.Add(this.downloadTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Bai02Form";
            this.Text = "BAI02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox downloadTextBox;
        private System.Windows.Forms.TextBox webInputTextBox;
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
    }
}

