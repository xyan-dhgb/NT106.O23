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
            this.passwdLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwdTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.timeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // passwdLabel
            // 
            this.passwdLabel.AutoSize = true;
            this.passwdLabel.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold);
            this.passwdLabel.Location = new System.Drawing.Point(54, 101);
            this.passwdLabel.Name = "passwdLabel";
            this.passwdLabel.Size = new System.Drawing.Size(138, 27);
            this.passwdLabel.TabIndex = 1;
            this.passwdLabel.Text = "Password:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(209, 59);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(401, 31);
            this.emailTextBox.TabIndex = 2;
            // 
            // passwdTextBox
            // 
            this.passwdTextBox.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwdTextBox.Location = new System.Drawing.Point(209, 100);
            this.passwdTextBox.Name = "passwdTextBox";
            this.passwdTextBox.Size = new System.Drawing.Size(401, 31);
            this.passwdTextBox.TabIndex = 3;
            this.passwdTextBox.UseSystemPasswordChar = true;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Lucida Fax", 14F, System.Drawing.FontStyle.Bold);
            this.emailLabel.Location = new System.Drawing.Point(54, 63);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(90, 27);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email:";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.SkyBlue;
            this.loginButton.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.Location = new System.Drawing.Point(648, 54);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(268, 77);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeColumn,
            this.emailColumn,
            this.fromColumn});
            this.dataGridView.Location = new System.Drawing.Point(12, 197);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(904, 375);
            this.dataGridView.TabIndex = 8;
            // 
            // timeColumn
            // 
            this.timeColumn.HeaderText = "Time";
            this.timeColumn.MinimumWidth = 6;
            this.timeColumn.Name = "timeColumn";
            this.timeColumn.Width = 200;
            // 
            // emailColumn
            // 
            this.emailColumn.HeaderText = "Email";
            this.emailColumn.MinimumWidth = 6;
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.Width = 250;
            // 
            // fromColumn
            // 
            this.fromColumn.HeaderText = "From";
            this.fromColumn.MinimumWidth = 6;
            this.fromColumn.Name = "fromColumn";
            this.fromColumn.Width = 175;
            // 
            // Bai02Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 584);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwdTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.passwdLabel);
            this.Controls.Add(this.emailLabel);
            this.Name = "Bai02Form";
            this.Text = "Bai02_Lab05";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label passwdLabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwdTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fromColumn;
    }
}

