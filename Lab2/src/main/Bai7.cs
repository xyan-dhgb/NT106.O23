using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lab_2
{
    public partial class Bai07Form : Form
    {
        public Bai07Form()
        {
            InitializeComponent();
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            FileAttributes fileAttributes = File.GetAttributes(e.Node.FullPath);
            if ((fileAttributes & FileAttributes.Directory) == FileAttributes.Directory)
            {
                e.Node.Nodes.Clear();

                string path = e.Node.FullPath;
                DirectoryInfo directoryInfo = new DirectoryInfo(path);
                FileInfo[] files = directoryInfo.GetFiles();
                DirectoryInfo[] dirs = directoryInfo.GetDirectories();

                foreach (FileInfo file in files)
                {
                    TreeNode treeNode = new TreeNode(file.Name);
                    e.Node.Nodes.Add(treeNode);
                }

                foreach (DirectoryInfo dir in dirs)
                {
                    TreeNode treeNode = new TreeNode(dir.Name);
                    e.Node.Nodes.Add(treeNode);
                }

                e.Node.ExpandAll();
            }
            else
            {
                Show_FileContent(e.Node.FullPath);
            }
        }

        private void Show_FileContent(string fullPath)
        {
            string fileExtension = Path.GetExtension(fullPath);
            if (fileExtension == ".txt")
            {
                pictureBox.Visible = false;
                richTextBox.Visible = true;

                FileStream fileStream = new FileStream(fullPath, FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(fileStream);
                richTextBox.Text = streamReader.ReadToEnd();
            }
            else if (fileExtension == ".png" || fileExtension == ".jpg")
            {
                richTextBox.Visible = false;
                pictureBox.Visible = true;

                Image image = Image.FromFile(fullPath);
                pictureBox.Image = image;
            }
        }

        private void Bai07Form_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo drive in allDrives)
            {
                treeView.Nodes.Add(drive.Name);
            }
        }


    }
}
