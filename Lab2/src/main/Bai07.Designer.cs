using System.Drawing;
using System.Windows.Forms;

namespace Lab_2
{
    partial class Bai07Form
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
            this.TreeViewer = new System.Windows.Forms.TreeView();
            this.contentLabel = new System.Windows.Forms.Label();
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.RichText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TreeViewer
            // 
            this.TreeViewer.Location = new System.Drawing.Point(13, 44);
            this.TreeViewer.Name = "TreeViewer";
            this.TreeViewer.Size = new System.Drawing.Size(219, 530);
            this.TreeViewer.TabIndex = 0;
            // Chú ý, nếu dòng dưới không có đoạn code: this.TreeViewer.NodeMouseDoubleClick += TreeViewer_NodeMouseDoubleClick;
            // thì thêm váo giúp em do đôi khi nó tự nhiên biến mất ạ. 
            this.TreeViewer.NodeMouseDoubleClick += TreeViewer_NodeMouseDoubleClick;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(251, 44);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(52, 16);
            this.contentLabel.TabIndex = 1;
            this.contentLabel.Text = "Content";
            // 
            // PicBox
            // 
            this.PicBox.Location = new System.Drawing.Point(254, 64);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(489, 510);
            this.PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBox.TabIndex = 2;
            this.PicBox.TabStop = false;
            // 
            // RichText
            // 
            this.RichText.Location = new System.Drawing.Point(254, 63);
            this.RichText.Name = "RichText";
            this.RichText.Size = new System.Drawing.Size(489, 510);
            this.RichText.TabIndex = 3;
            this.RichText.Text = "";
            // 
            // Bai07Form
            // 
            this.ClientSize = new System.Drawing.Size(755, 586);
            this.Controls.Add(this.RichText);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.TreeViewer);
            this.Name = "Bai07Form";
            this.Text = "Lab02-Bai7";
            this.Load += new System.EventHandler(this.Bai07Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label;
        private TreeView treeView;
        private PictureBox pictureBox;
        private RichTextBox richTextBox;
        private TreeView TreeViewer;
        private Label contentLabel;
        private PictureBox PicBox;
        private RichTextBox RichText;
    }
}