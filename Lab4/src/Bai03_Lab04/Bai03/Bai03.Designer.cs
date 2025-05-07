namespace Bai03
{
    partial class Bai03Form
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
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.fileDownLoadButton = new System.Windows.Forms.Button();
            this.resourceDownloadButton = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER YOUR URL";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlTextBox.Location = new System.Drawing.Point(23, 74);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(294, 34);
            this.urlTextBox.TabIndex = 1;
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(323, 26);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(96, 112);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "LOAD";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // fileDownLoadButton
            // 
            this.fileDownLoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileDownLoadButton.Location = new System.Drawing.Point(425, 26);
            this.fileDownLoadButton.Name = "fileDownLoadButton";
            this.fileDownLoadButton.Size = new System.Drawing.Size(308, 47);
            this.fileDownLoadButton.TabIndex = 3;
            this.fileDownLoadButton.Text = "DOWNLOAD FILE";
            this.fileDownLoadButton.UseVisualStyleBackColor = true;
            this.fileDownLoadButton.Click += new System.EventHandler(this.fileDownLoadButton_Click);
            // 
            // resourceDownloadButton
            // 
            this.resourceDownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resourceDownloadButton.Location = new System.Drawing.Point(425, 91);
            this.resourceDownloadButton.Name = "resourceDownloadButton";
            this.resourceDownloadButton.Size = new System.Drawing.Size(308, 47);
            this.resourceDownloadButton.TabIndex = 4;
            this.resourceDownloadButton.Text = "GET RESOURCE";
            this.resourceDownloadButton.UseVisualStyleBackColor = true;
            this.resourceDownloadButton.Click += new System.EventHandler(this.resourceDownloadButton_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(23, 162);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(710, 563);
            this.webView.TabIndex = 5;
            this.webView.ZoomFactor = 1D;
            // 
            // Bai03Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 737);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.resourceDownloadButton);
            this.Controls.Add(this.fileDownLoadButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Bai03Form";
            this.Text = "BAI03";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button fileDownLoadButton;
        private System.Windows.Forms.Button resourceDownloadButton;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}

