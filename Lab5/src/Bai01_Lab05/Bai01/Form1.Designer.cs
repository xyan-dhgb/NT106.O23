namespace Bai01
{
    partial class Bai01Form
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
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // toTextBox
            // 
            this.toTextBox.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTextBox.Location = new System.Drawing.Point(21, 76);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(575, 35);
            this.toTextBox.TabIndex = 0;
            this.toTextBox.Enter += new System.EventHandler(this.toTextBox_Enter);
            this.toTextBox.Leave += new System.EventHandler(this.toTextBox_Leave);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromTextBox.Location = new System.Drawing.Point(21, 26);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(575, 35);
            this.fromTextBox.TabIndex = 1;
            this.fromTextBox.Enter += new System.EventHandler(this.fromTextBox_Enter);
            this.fromTextBox.Leave += new System.EventHandler(this.fromTextBox_Leave);
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Font = new System.Drawing.Font("Lucida Fax", 13F);
            this.contentRichTextBox.Location = new System.Drawing.Point(21, 267);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(575, 326);
            this.contentRichTextBox.TabIndex = 2;
            this.contentRichTextBox.Text = "";
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.sendButton.Font = new System.Drawing.Font("Lucida Fax", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendButton.Location = new System.Drawing.Point(21, 611);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(423, 48);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectTextBox.Location = new System.Drawing.Point(21, 198);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(575, 35);
            this.subjectTextBox.TabIndex = 4;
            this.subjectTextBox.Enter += new System.EventHandler(this.subjectTextBox_Enter);
            this.subjectTextBox.Leave += new System.EventHandler(this.subjectTextBox_Leave);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Crimson;
            this.closeButton.Font = new System.Drawing.Font("Lucida Fax", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.Control;
            this.closeButton.Location = new System.Drawing.Point(475, 611);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(121, 48);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdTextBox.Location = new System.Drawing.Point(21, 136);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.Size = new System.Drawing.Size(575, 35);
            this.passwdTextBox.TabIndex = 6;
            this.passwdTextBox.UseSystemPasswordChar = true;
            this.passwdTextBox.Enter += new System.EventHandler(this.passwdTextBox_Enter);
            this.passwdTextBox.Leave += new System.EventHandler(this.passwdTextBox_Leave);
            // 
            // Bai01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 682);
            this.Controls.Add(this.passwdTextBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.toTextBox);
            this.Name = "Bai01Form";
            this.Text = "Bai01_Lab05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox passwdTextBox;
    }
}

