using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BatchRenamer.Program;

namespace BatchRenamer
{
    public partial class Form1 : Form
    {
        private string UserPath = "";

        Program otherFunctions = new Program();

        private FolderBrowserDialog fbd;

        public Form1()
        {
            InitializeComponent();
        }
        public class UserParams
        {
            public string userPath { get; set; }
            public string filePrefix { get; set; }
            public string folderPrefix { get; set; }
            public string startingNumber { get; set; }
            public string fileExtension { get; set; }

            public UserParams() { }

            public UserParams(UserParams other)
            {
                this.userPath = other.userPath;
                this.filePrefix = other.filePrefix;
                this.folderPrefix = other.folderPrefix;
                this.startingNumber = other.startingNumber;
                this.fileExtension = other.fileExtension;
            }

            public static UserParams GetInstance(UserParams p)
            {
                return new UserParams(p);
            }
        }
        private void setUserPath(string userPath)
        {
            UserPath = userPath;
        }
        public string getUserPath()
        {
            return UserPath;
        }
        public string getFilePrefix()
        {
            return (string)comboBox2.SelectedItem;
        }
        public string getFolderPrefix()
        {
            return (string)comboBox1.SelectedItem;
        }
        public string getStartingNumber()
        {
            return (string)comboBox3.SelectedItem;
        }
        public string getFileExtension()
        {
            return (string)comboBox4_fileExtension.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lbl_userSelection.Text = fbd.SelectedPath;
                setUserPath(fbd.SelectedPath);
                comboBox4_fileExtension.Enabled = true;
                comboBox4_fileExtension.DataSource = GetFileExtensions(fbd.SelectedPath);
                ListDirectory(treeView1, UserPath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            UserParams p = new UserParams() {
                userPath = getUserPath(),
                filePrefix = getFilePrefix(),
                folderPrefix = getFolderPrefix(),
                startingNumber = getStartingNumber(),
                fileExtension = getFileExtension()
            };

            otherFunctions.Rename(p);
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            lbl_userSelection.Text = FileList[0];
            setUserPath(FileList[0]);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            DragDropEffects effects = DragDropEffects.None;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var path = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
                if (Directory.Exists(path))
                    effects = DragDropEffects.Copy;
            }

            e.Effect = effects;
        }
        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            treeView.Nodes.Add(CreateDirectoryNode(path));
        }

        private TreeNode CreateDirectoryNode(string path)
        {
            string selectedFileExtension = getFileExtension();

            if(selectedFileExtension == "All")
            {
                selectedFileExtension = "";
            }

            var directoryNode = new TreeNode(new DirectoryInfo(path).Name);
            foreach (var folder in Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly).Select((name, index) => (name, index)))
            {
                string test = getFolderPrefix() + folder.index.ToString();
                directoryNode.Nodes.Add(CreateDirectoryNode(folder.name));
            }
            foreach (var file in Directory.GetFiles(path, "*" + selectedFileExtension, SearchOption.TopDirectoryOnly).Select((name, index) => (name, index)))
            {
                Console.WriteLine(file.name);
                //directoryNode.Nodes.Add(new TreeNode(file.index.ToString()));
                directoryNode.Nodes.Add(new TreeNode(new DirectoryInfo(file.name).Name));
            }
            return directoryNode;
        }
        private void CreateFileNode(TreeNode directoryNode, string path, int folderIndex)
        {

        }

        private void comboBox4_fileExtension_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListDirectory(treeView1, UserPath);
        }
    }
}
