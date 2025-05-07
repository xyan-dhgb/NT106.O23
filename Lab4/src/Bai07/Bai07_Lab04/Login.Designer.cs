namespace Lab05Bai4
{
    partial class Login
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
            this.signupLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signupLabel
            // 
            this.signupLabel.AutoSize = true;
            this.signupLabel.BackColor = System.Drawing.Color.Transparent;
            this.signupLabel.ForeColor = System.Drawing.Color.Navy;
            this.signupLabel.Location = new System.Drawing.Point(276, 206);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(52, 16);
            this.signupLabel.TabIndex = 15;
            this.signupLabel.Text = "Sign up";
            this.signupLabel.Click += new System.EventHandler(this.signupLabel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(91, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Don\'t have an account yet?";
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.passwdTextBox.Location = new System.Drawing.Point(100, 146);
            this.passwdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwdTextBox.Multiline = true;
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.PasswordChar = '*';
            this.passwdTextBox.Size = new System.Drawing.Size(243, 28);
            this.passwdTextBox.TabIndex = 13;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.LightBlue;
            this.nameTextBox.Location = new System.Drawing.Point(100, 83);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(243, 28);
            this.nameTextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Username";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.loginButton.Location = new System.Drawing.Point(374, 83);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(123, 90);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(213, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 241);
            this.Controls.Add(this.signupLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwdTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label1;
    }
}