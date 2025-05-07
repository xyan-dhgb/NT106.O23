namespace Bai01
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
            this.label1 = new System.Windows.Forms.Label();
            this.webInputTextBox = new System.Windows.Forms.TextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.answerRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER YOUR WEB:";
            // 
            // webInputTextBox
            // 
            this.webInputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webInputTextBox.Location = new System.Drawing.Point(12, 54);
            this.webInputTextBox.Name = "webInputTextBox";
            this.webInputTextBox.Size = new System.Drawing.Size(414, 34);
            this.webInputTextBox.TabIndex = 1;
            // 
            // getButton
            // 
            this.getButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getButton.Location = new System.Drawing.Point(454, 54);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(133, 34);
            this.getButton.TabIndex = 2;
            this.getButton.Text = "GET";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // answerRichTextBox
            // 
            this.answerRichTextBox.Location = new System.Drawing.Point(12, 117);
            this.answerRichTextBox.Name = "answerRichTextBox";
            this.answerRichTextBox.Size = new System.Drawing.Size(575, 312);
            this.answerRichTextBox.TabIndex = 3;
            this.answerRichTextBox.Text = "";
            // 
            // Bai1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 450);
            this.Controls.Add(this.answerRichTextBox);
            this.Controls.Add(this.getButton);
            this.Controls.Add(this.webInputTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Bai1Form";
            this.Text = "BAI01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox webInputTextBox;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.RichTextBox answerRichTextBox;
    }
}

