namespace Lab_2
{
    partial class Bai4Form
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
            this.TittleLabel = new System.Windows.Forms.Label();
            this.studentInfoTextBox = new System.Windows.Forms.RichTextBox();
            this.writeFileButton = new System.Windows.Forms.Button();
            this.readFileButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.course2Input = new System.Windows.Forms.TextBox();
            this.course1Input = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.idInput = new System.Windows.Forms.TextBox();
            this.WriteNameLabel = new System.Windows.Forms.Label();
            this.WriteCourse2Label = new System.Windows.Forms.Label();
            this.WriteCourse1Label = new System.Windows.Forms.Label();
            this.WritePhoneLabel = new System.Windows.Forms.Label();
            this.WriteIDLabel = new System.Windows.Forms.Label();
            this.WriteCourse3Label = new System.Windows.Forms.Label();
            this.course3Input = new System.Windows.Forms.TextBox();
            this.WriteAverageLabel = new System.Windows.Forms.Label();
            this.averageInput = new System.Windows.Forms.TextBox();
            this.ReadAverageLabel = new System.Windows.Forms.Label();
            this.averageOutput = new System.Windows.Forms.TextBox();
            this.ReadCourse3Label = new System.Windows.Forms.Label();
            this.course3Output = new System.Windows.Forms.TextBox();
            this.ReadIDLabel = new System.Windows.Forms.Label();
            this.ReadPhoneLabel = new System.Windows.Forms.Label();
            this.ReadCourse1Label = new System.Windows.Forms.Label();
            this.ReadCourse2Label = new System.Windows.Forms.Label();
            this.ReadNameLabel = new System.Windows.Forms.Label();
            this.idOutput = new System.Windows.Forms.TextBox();
            this.phoneOutput = new System.Windows.Forms.TextBox();
            this.course1Output = new System.Windows.Forms.TextBox();
            this.course2Output = new System.Windows.Forms.TextBox();
            this.nameOutput = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pageNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TittleLabel
            // 
            this.TittleLabel.AutoSize = true;
            this.TittleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TittleLabel.ForeColor = System.Drawing.Color.Red;
            this.TittleLabel.Location = new System.Drawing.Point(196, 9);
            this.TittleLabel.Name = "TittleLabel";
            this.TittleLabel.Size = new System.Drawing.Size(768, 38);
            this.TittleLabel.TabIndex = 0;
            this.TittleLabel.Text = " Bài 4 - Đọc và Ghi file sử dụng BinaryFormatter ";
            // 
            // studentInfoTextBox
            // 
            this.studentInfoTextBox.Location = new System.Drawing.Point(399, 51);
            this.studentInfoTextBox.Name = "studentInfoTextBox";
            this.studentInfoTextBox.Size = new System.Drawing.Size(388, 563);
            this.studentInfoTextBox.TabIndex = 1;
            this.studentInfoTextBox.Text = "";
            // 
            // writeFileButton
            // 
            this.writeFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.writeFileButton.Location = new System.Drawing.Point(12, 53);
            this.writeFileButton.Name = "writeFileButton";
            this.writeFileButton.Size = new System.Drawing.Size(355, 38);
            this.writeFileButton.TabIndex = 2;
            this.writeFileButton.Text = "Write to a file";
            this.writeFileButton.UseVisualStyleBackColor = true;
            this.writeFileButton.Click += new System.EventHandler(this.writeFileButton_Click_1);
            // 
            // readFileButton
            // 
            this.readFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readFileButton.Location = new System.Drawing.Point(814, 53);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(356, 40);
            this.readFileButton.TabIndex = 3;
            this.readFileButton.Text = "Read to a file";
            this.readFileButton.UseVisualStyleBackColor = true;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click_1);
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(12, 128);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(222, 34);
            this.nameInput.TabIndex = 4;
            // 
            // course2Input
            // 
            this.course2Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course2Input.Location = new System.Drawing.Point(12, 374);
            this.course2Input.Name = "course2Input";
            this.course2Input.Size = new System.Drawing.Size(222, 34);
            this.course2Input.TabIndex = 5;
            // 
            // course1Input
            // 
            this.course1Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course1Input.Location = new System.Drawing.Point(12, 309);
            this.course1Input.Name = "course1Input";
            this.course1Input.Size = new System.Drawing.Size(222, 34);
            this.course1Input.TabIndex = 6;
            // 
            // phoneInput
            // 
            this.phoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneInput.Location = new System.Drawing.Point(12, 248);
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(222, 34);
            this.phoneInput.TabIndex = 7;
            // 
            // idInput
            // 
            this.idInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idInput.Location = new System.Drawing.Point(12, 185);
            this.idInput.Name = "idInput";
            this.idInput.Size = new System.Drawing.Size(222, 34);
            this.idInput.TabIndex = 8;
            // 
            // WriteNameLabel
            // 
            this.WriteNameLabel.AutoSize = true;
            this.WriteNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteNameLabel.Location = new System.Drawing.Point(258, 133);
            this.WriteNameLabel.Name = "WriteNameLabel";
            this.WriteNameLabel.Size = new System.Drawing.Size(82, 29);
            this.WriteNameLabel.TabIndex = 9;
            this.WriteNameLabel.Text = "Name";
            // 
            // WriteCourse2Label
            // 
            this.WriteCourse2Label.AutoSize = true;
            this.WriteCourse2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteCourse2Label.Location = new System.Drawing.Point(258, 379);
            this.WriteCourse2Label.Name = "WriteCourse2Label";
            this.WriteCourse2Label.Size = new System.Drawing.Size(118, 29);
            this.WriteCourse2Label.TabIndex = 10;
            this.WriteCourse2Label.Text = "Course 2";
            // 
            // WriteCourse1Label
            // 
            this.WriteCourse1Label.AutoSize = true;
            this.WriteCourse1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteCourse1Label.Location = new System.Drawing.Point(258, 314);
            this.WriteCourse1Label.Name = "WriteCourse1Label";
            this.WriteCourse1Label.Size = new System.Drawing.Size(118, 29);
            this.WriteCourse1Label.TabIndex = 11;
            this.WriteCourse1Label.Text = "Course 1";
            // 
            // WritePhoneLabel
            // 
            this.WritePhoneLabel.AutoSize = true;
            this.WritePhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WritePhoneLabel.Location = new System.Drawing.Point(258, 253);
            this.WritePhoneLabel.Name = "WritePhoneLabel";
            this.WritePhoneLabel.Size = new System.Drawing.Size(88, 29);
            this.WritePhoneLabel.TabIndex = 12;
            this.WritePhoneLabel.Text = "Phone";
            // 
            // WriteIDLabel
            // 
            this.WriteIDLabel.AutoSize = true;
            this.WriteIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteIDLabel.Location = new System.Drawing.Point(258, 190);
            this.WriteIDLabel.Name = "WriteIDLabel";
            this.WriteIDLabel.Size = new System.Drawing.Size(38, 29);
            this.WriteIDLabel.TabIndex = 13;
            this.WriteIDLabel.Text = "ID";
            // 
            // WriteCourse3Label
            // 
            this.WriteCourse3Label.AutoSize = true;
            this.WriteCourse3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteCourse3Label.Location = new System.Drawing.Point(258, 446);
            this.WriteCourse3Label.Name = "WriteCourse3Label";
            this.WriteCourse3Label.Size = new System.Drawing.Size(118, 29);
            this.WriteCourse3Label.TabIndex = 15;
            this.WriteCourse3Label.Text = "Course 3";
            // 
            // course3Input
            // 
            this.course3Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course3Input.Location = new System.Drawing.Point(12, 441);
            this.course3Input.Name = "course3Input";
            this.course3Input.Size = new System.Drawing.Size(222, 34);
            this.course3Input.TabIndex = 14;
            // 
            // WriteAverageLabel
            // 
            this.WriteAverageLabel.AutoSize = true;
            this.WriteAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WriteAverageLabel.Location = new System.Drawing.Point(258, 508);
            this.WriteAverageLabel.Name = "WriteAverageLabel";
            this.WriteAverageLabel.Size = new System.Drawing.Size(109, 29);
            this.WriteAverageLabel.TabIndex = 17;
            this.WriteAverageLabel.Text = "Average";
            // 
            // averageInput
            // 
            this.averageInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageInput.Location = new System.Drawing.Point(12, 503);
            this.averageInput.Name = "averageInput";
            this.averageInput.Size = new System.Drawing.Size(222, 34);
            this.averageInput.TabIndex = 16;
            // 
            // ReadAverageLabel
            // 
            this.ReadAverageLabel.AutoSize = true;
            this.ReadAverageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadAverageLabel.Location = new System.Drawing.Point(809, 508);
            this.ReadAverageLabel.Name = "ReadAverageLabel";
            this.ReadAverageLabel.Size = new System.Drawing.Size(109, 29);
            this.ReadAverageLabel.TabIndex = 32;
            this.ReadAverageLabel.Text = "Average";
            // 
            // averageOutput
            // 
            this.averageOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageOutput.Location = new System.Drawing.Point(948, 503);
            this.averageOutput.Name = "averageOutput";
            this.averageOutput.ReadOnly = true;
            this.averageOutput.Size = new System.Drawing.Size(222, 34);
            this.averageOutput.TabIndex = 31;
            // 
            // ReadCourse3Label
            // 
            this.ReadCourse3Label.AutoSize = true;
            this.ReadCourse3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadCourse3Label.Location = new System.Drawing.Point(809, 446);
            this.ReadCourse3Label.Name = "ReadCourse3Label";
            this.ReadCourse3Label.Size = new System.Drawing.Size(118, 29);
            this.ReadCourse3Label.TabIndex = 30;
            this.ReadCourse3Label.Text = "Course 3";
            // 
            // course3Output
            // 
            this.course3Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course3Output.Location = new System.Drawing.Point(948, 441);
            this.course3Output.Name = "course3Output";
            this.course3Output.ReadOnly = true;
            this.course3Output.Size = new System.Drawing.Size(222, 34);
            this.course3Output.TabIndex = 29;
            // 
            // ReadIDLabel
            // 
            this.ReadIDLabel.AutoSize = true;
            this.ReadIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadIDLabel.Location = new System.Drawing.Point(809, 190);
            this.ReadIDLabel.Name = "ReadIDLabel";
            this.ReadIDLabel.Size = new System.Drawing.Size(38, 29);
            this.ReadIDLabel.TabIndex = 28;
            this.ReadIDLabel.Text = "ID";
            // 
            // ReadPhoneLabel
            // 
            this.ReadPhoneLabel.AutoSize = true;
            this.ReadPhoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadPhoneLabel.Location = new System.Drawing.Point(809, 253);
            this.ReadPhoneLabel.Name = "ReadPhoneLabel";
            this.ReadPhoneLabel.Size = new System.Drawing.Size(88, 29);
            this.ReadPhoneLabel.TabIndex = 27;
            this.ReadPhoneLabel.Text = "Phone";
            // 
            // ReadCourse1Label
            // 
            this.ReadCourse1Label.AutoSize = true;
            this.ReadCourse1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadCourse1Label.Location = new System.Drawing.Point(809, 314);
            this.ReadCourse1Label.Name = "ReadCourse1Label";
            this.ReadCourse1Label.Size = new System.Drawing.Size(118, 29);
            this.ReadCourse1Label.TabIndex = 26;
            this.ReadCourse1Label.Text = "Course 1";
            // 
            // ReadCourse2Label
            // 
            this.ReadCourse2Label.AutoSize = true;
            this.ReadCourse2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadCourse2Label.Location = new System.Drawing.Point(809, 379);
            this.ReadCourse2Label.Name = "ReadCourse2Label";
            this.ReadCourse2Label.Size = new System.Drawing.Size(118, 29);
            this.ReadCourse2Label.TabIndex = 25;
            this.ReadCourse2Label.Text = "Course 2";
            // 
            // ReadNameLabel
            // 
            this.ReadNameLabel.AutoSize = true;
            this.ReadNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadNameLabel.Location = new System.Drawing.Point(809, 133);
            this.ReadNameLabel.Name = "ReadNameLabel";
            this.ReadNameLabel.Size = new System.Drawing.Size(82, 29);
            this.ReadNameLabel.TabIndex = 24;
            this.ReadNameLabel.Text = "Name";
            // 
            // idOutput
            // 
            this.idOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idOutput.Location = new System.Drawing.Point(948, 185);
            this.idOutput.Name = "idOutput";
            this.idOutput.ReadOnly = true;
            this.idOutput.Size = new System.Drawing.Size(222, 34);
            this.idOutput.TabIndex = 23;
            // 
            // phoneOutput
            // 
            this.phoneOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneOutput.Location = new System.Drawing.Point(948, 248);
            this.phoneOutput.Name = "phoneOutput";
            this.phoneOutput.ReadOnly = true;
            this.phoneOutput.Size = new System.Drawing.Size(222, 34);
            this.phoneOutput.TabIndex = 22;
            // 
            // course1Output
            // 
            this.course1Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course1Output.Location = new System.Drawing.Point(948, 309);
            this.course1Output.Name = "course1Output";
            this.course1Output.ReadOnly = true;
            this.course1Output.Size = new System.Drawing.Size(222, 34);
            this.course1Output.TabIndex = 21;
            // 
            // course2Output
            // 
            this.course2Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course2Output.Location = new System.Drawing.Point(948, 374);
            this.course2Output.Name = "course2Output";
            this.course2Output.ReadOnly = true;
            this.course2Output.Size = new System.Drawing.Size(222, 34);
            this.course2Output.TabIndex = 20;
            // 
            // nameOutput
            // 
            this.nameOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOutput.Location = new System.Drawing.Point(948, 128);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.ReadOnly = true;
            this.nameOutput.Size = new System.Drawing.Size(222, 34);
            this.nameOutput.TabIndex = 19;
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(854, 576);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(110, 38);
            this.backButton.TabIndex = 33;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click_1);
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(1060, 576);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(110, 38);
            this.nextButton.TabIndex = 34;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click_1);
            // 
            // pageNumLabel
            // 
            this.pageNumLabel.AutoSize = true;
            this.pageNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageNumLabel.Location = new System.Drawing.Point(982, 580);
            this.pageNumLabel.Name = "pageNumLabel";
            this.pageNumLabel.Size = new System.Drawing.Size(62, 29);
            this.pageNumLabel.TabIndex = 35;
            this.pageNumLabel.Text = "NaN";
            // 
            // Bai4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 655);
            this.Controls.Add(this.pageNumLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.ReadAverageLabel);
            this.Controls.Add(this.averageOutput);
            this.Controls.Add(this.ReadCourse3Label);
            this.Controls.Add(this.course3Output);
            this.Controls.Add(this.ReadIDLabel);
            this.Controls.Add(this.ReadPhoneLabel);
            this.Controls.Add(this.ReadCourse1Label);
            this.Controls.Add(this.ReadCourse2Label);
            this.Controls.Add(this.ReadNameLabel);
            this.Controls.Add(this.idOutput);
            this.Controls.Add(this.phoneOutput);
            this.Controls.Add(this.course1Output);
            this.Controls.Add(this.course2Output);
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.WriteAverageLabel);
            this.Controls.Add(this.averageInput);
            this.Controls.Add(this.WriteCourse3Label);
            this.Controls.Add(this.course3Input);
            this.Controls.Add(this.WriteIDLabel);
            this.Controls.Add(this.WritePhoneLabel);
            this.Controls.Add(this.WriteCourse1Label);
            this.Controls.Add(this.WriteCourse2Label);
            this.Controls.Add(this.WriteNameLabel);
            this.Controls.Add(this.idInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.course1Input);
            this.Controls.Add(this.course2Input);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.writeFileButton);
            this.Controls.Add(this.studentInfoTextBox);
            this.Controls.Add(this.TittleLabel);
            this.Name = "Bai4Form";
            this.Text = "Lab02-Bai4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TittleLabel;
        private System.Windows.Forms.RichTextBox studentInfoTextBox;
        private System.Windows.Forms.Button writeFileButton;
        private System.Windows.Forms.Button readFileButton;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox course2Input;
        private System.Windows.Forms.TextBox course1Input;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox idInput;
        private System.Windows.Forms.Label WriteNameLabel;
        private System.Windows.Forms.Label WriteCourse2Label;
        private System.Windows.Forms.Label WriteCourse1Label;
        private System.Windows.Forms.Label WritePhoneLabel;
        private System.Windows.Forms.Label WriteIDLabel;
        private System.Windows.Forms.Label WriteCourse3Label;
        private System.Windows.Forms.TextBox course3Input;
        private System.Windows.Forms.Label WriteAverageLabel;
        private System.Windows.Forms.TextBox averageInput;
        private System.Windows.Forms.Label ReadAverageLabel;
        private System.Windows.Forms.TextBox averageOutput;
        private System.Windows.Forms.Label ReadCourse3Label;
        private System.Windows.Forms.TextBox course3Output;
        private System.Windows.Forms.Label ReadIDLabel;
        private System.Windows.Forms.Label ReadPhoneLabel;
        private System.Windows.Forms.Label ReadCourse1Label;
        private System.Windows.Forms.Label ReadCourse2Label;
        private System.Windows.Forms.Label ReadNameLabel;
        private System.Windows.Forms.TextBox idOutput;
        private System.Windows.Forms.TextBox phoneOutput;
        private System.Windows.Forms.TextBox course1Output;
        private System.Windows.Forms.TextBox course2Output;
        private System.Windows.Forms.TextBox nameOutput;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label pageNumLabel;
    }
}