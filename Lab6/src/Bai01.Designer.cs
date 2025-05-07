namespace Lab06
{
    partial class bai01Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bai01Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shiftTextBox = new System.Windows.Forms.TextBox();
            this.plainTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.encodeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.decodeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.decodeButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, -62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 224);
            this.label1.TabIndex = 0;
            this.label1.Text = "CAESAR CODE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter your plain text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Shift";
            // 
            // shiftTextBox
            // 
            this.shiftTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.shiftTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftTextBox.Location = new System.Drawing.Point(590, 94);
            this.shiftTextBox.Name = "shiftTextBox";
            this.shiftTextBox.Size = new System.Drawing.Size(129, 30);
            this.shiftTextBox.TabIndex = 4;
            // 
            // plainTextRichTextBox
            // 
            this.plainTextRichTextBox.BackColor = System.Drawing.Color.Azure;
            this.plainTextRichTextBox.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainTextRichTextBox.Location = new System.Drawing.Point(33, 130);
            this.plainTextRichTextBox.Name = "plainTextRichTextBox";
            this.plainTextRichTextBox.Size = new System.Drawing.Size(686, 135);
            this.plainTextRichTextBox.TabIndex = 5;
            this.plainTextRichTextBox.Text = "";
            // 
            // encodeButton
            // 
            this.encodeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.encodeButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeButton.Location = new System.Drawing.Point(135, 359);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(132, 38);
            this.encodeButton.TabIndex = 6;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = false;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // encodeRichTextBox
            // 
            this.encodeRichTextBox.BackColor = System.Drawing.Color.Azure;
            this.encodeRichTextBox.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeRichTextBox.Location = new System.Drawing.Point(24, 403);
            this.encodeRichTextBox.Name = "encodeRichTextBox";
            this.encodeRichTextBox.Size = new System.Drawing.Size(343, 261);
            this.encodeRichTextBox.TabIndex = 7;
            this.encodeRichTextBox.Text = "";
            // 
            // decodeRichTextBox
            // 
            this.decodeRichTextBox.BackColor = System.Drawing.Color.Azure;
            this.decodeRichTextBox.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeRichTextBox.Location = new System.Drawing.Point(374, 403);
            this.decodeRichTextBox.Name = "decodeRichTextBox";
            this.decodeRichTextBox.Size = new System.Drawing.Size(345, 261);
            this.decodeRichTextBox.TabIndex = 8;
            this.decodeRichTextBox.Text = "";
            // 
            // decodeButton
            // 
            this.decodeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.decodeButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeButton.Location = new System.Drawing.Point(484, 359);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(132, 38);
            this.decodeButton.TabIndex = 9;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = false;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.AliceBlue;
            this.clearButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(35, 271);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(202, 38);
            this.clearButton.TabIndex = 20;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // bai01Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(742, 719);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.decodeRichTextBox);
            this.Controls.Add(this.encodeRichTextBox);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.plainTextRichTextBox);
            this.Controls.Add(this.shiftTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "bai01Form";
            this.Text = "Bai01";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shiftTextBox;
        private System.Windows.Forms.RichTextBox plainTextRichTextBox;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.RichTextBox encodeRichTextBox;
        private System.Windows.Forms.RichTextBox decodeRichTextBox;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button clearButton;
    }
}