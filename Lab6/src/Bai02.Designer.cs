namespace Lab06
{
    partial class bai02Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bai02Form));
            this.decodeButton = new System.Windows.Forms.Button();
            this.decodeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.encodeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.plainTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // decodeButton
            // 
            this.decodeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.decodeButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeButton.Location = new System.Drawing.Point(541, 360);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(132, 38);
            this.decodeButton.TabIndex = 18;
            this.decodeButton.Text = "Decode";
            this.decodeButton.UseVisualStyleBackColor = false;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // decodeRichTextBox
            // 
            this.decodeRichTextBox.BackColor = System.Drawing.Color.Azure;
            this.decodeRichTextBox.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decodeRichTextBox.Location = new System.Drawing.Point(408, 404);
            this.decodeRichTextBox.Name = "decodeRichTextBox";
            this.decodeRichTextBox.Size = new System.Drawing.Size(369, 261);
            this.decodeRichTextBox.TabIndex = 17;
            this.decodeRichTextBox.Text = "";
            // 
            // encodeRichTextBox
            // 
            this.encodeRichTextBox.BackColor = System.Drawing.Color.Azure;
            this.encodeRichTextBox.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeRichTextBox.Location = new System.Drawing.Point(24, 404);
            this.encodeRichTextBox.Name = "encodeRichTextBox";
            this.encodeRichTextBox.Size = new System.Drawing.Size(378, 261);
            this.encodeRichTextBox.TabIndex = 16;
            this.encodeRichTextBox.Text = "";
            // 
            // encodeButton
            // 
            this.encodeButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.encodeButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encodeButton.Location = new System.Drawing.Point(145, 360);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(132, 38);
            this.encodeButton.TabIndex = 15;
            this.encodeButton.Text = "Encode";
            this.encodeButton.UseVisualStyleBackColor = false;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // plainTextRichTextBox
            // 
            this.plainTextRichTextBox.BackColor = System.Drawing.Color.Azure;
            this.plainTextRichTextBox.Font = new System.Drawing.Font("Lucida Fax", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plainTextRichTextBox.Location = new System.Drawing.Point(24, 147);
            this.plainTextRichTextBox.Name = "plainTextRichTextBox";
            this.plainTextRichTextBox.Size = new System.Drawing.Size(753, 135);
            this.plainTextRichTextBox.TabIndex = 14;
            this.plainTextRichTextBox.Text = "";
            // 
            // keyTextBox
            // 
            this.keyTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.keyTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyTextBox.Location = new System.Drawing.Point(492, 111);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(285, 31);
            this.keyTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Enter your plain text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, -58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 224);
            this.label1.TabIndex = 10;
            this.label1.Text = "VIGENÈRE CODE";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.AliceBlue;
            this.clearButton.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(24, 299);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(202, 38);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // bai02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 702);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.decodeRichTextBox);
            this.Controls.Add(this.encodeRichTextBox);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.plainTextRichTextBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "bai02Form";
            this.Text = "Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.RichTextBox decodeRichTextBox;
        private System.Windows.Forms.RichTextBox encodeRichTextBox;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.RichTextBox plainTextRichTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearButton;
    }
}