using System;
using System.Data;
using System.IO;
using System.Linq;
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
            public string fileSeasonPrefix { get; set; }
            public string showName { get; set; }
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
        public string getFileEpisodePrefix()
        {
            return (string)fileEpisodePrefix.SelectedItem;
        }
        public string getFileSeasonPrefix()
        {
            return (string)fileSeasonPrefix.SelectedItem;
        }
        public string getFolderPrefix()
        {
            return (string)folderSeasonPrefix.SelectedItem;
        }
        public string getStartingNumber()
        {
            return (string)startSeasonNumber.SelectedItem;
        }
        public string getFileExtension()
        {
            return (string)fileExtension.SelectedItem;
        }
        private string getShowName()
        {
            return (string)showName.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lbl_userSelection.Text = fbd.SelectedPath;
                setUserPath(fbd.SelectedPath);
                fileExtension.Enabled = true;
                fileExtension.DataSource = GetFileExtensions(fbd.SelectedPath);
                ListDirectory(treeView1, UserPath);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            folderSeasonPrefix.SelectedIndex = 2;
            fileEpisodePrefix.SelectedIndex = 0;
            startSeasonNumber.SelectedIndex = 0;
            fileSeasonPrefix.SelectedIndex = 0;
        }
        private void btn_rename_Click(object sender, EventArgs e)
        {
            UserParams p = new UserParams() {
                userPath = getUserPath(),
                filePrefix = getFileEpisodePrefix(),
                folderPrefix = getFolderPrefix(),
                showName = getShowName(),
                startingNumber = getStartingNumber(),
                fileExtension = getFileExtension(),
                fileSeasonPrefix = getFileSeasonPrefix()
            };

            otherFunctions.Rename(p);
        }
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] FileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            string dragDropFolder = getDragDropFolder(FileList);
            showName.AutoCompleteCustomSource.Add(dragDropFolder);
            showName.Text = dragDropFolder;
            lbl_userSelection.Text = FileList[0];
            setUserPath(FileList[0]);
            fileExtension.Enabled = true;
            fileExtension.DataSource = GetFileExtensions(FileList[0]);
            ListDirectory(treeView1, UserPath);
        }

        private string getDragDropFolder(string[] fileList)
        {
            string path = fileList[0];
            return new DirectoryInfo(path).Name;
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
        private TreeNode CreateDirectoryNode(string path, int folderIndex = 0, string folderSeasonNumber = "")
        {
            string selectedFileExtension = getFileExtension();
            TreeNode directoryNode;

            if(selectedFileExtension == "All")
            {
                selectedFileExtension = "";
            }

            //If it is base folder, use original name
            if (folderIndex == 0)
            {
                directoryNode = new TreeNode(new DirectoryInfo(path).Name);
            }
            else
            {
                string folderIndexString = AddLeadingZero(folderIndex);
                directoryNode = new TreeNode(getFolderPrefix() + " " + folderIndexString);
            }

            foreach (var folder in Directory.GetDirectories(path, "*", SearchOption.TopDirectoryOnly).Select((name, index) => (name, index)))
            {
                directoryNode.Nodes.Add(CreateDirectoryNode(folder.name, int.Parse(getStartingNumber()) + folder.index, AddLeadingZero(folder.index + 1)));
            }
            foreach (var file in Directory.GetFiles(path, "*" + selectedFileExtension, SearchOption.TopDirectoryOnly).Select((name, index) => (name, index)))
            {
                string fileNum = AddLeadingZero(file.index+1);
                string currentFileExtension = Path.GetExtension(file.name);
                directoryNode.Nodes.Add(new TreeNode(getShowName() + " - " + getFileSeasonPrefix() + folderSeasonNumber + getFileEpisodePrefix() + fileNum + currentFileExtension));
            }
            return directoryNode;
        }
        static string AddLeadingZero(int num)
        {
            string output;

            if (num < 10)
            {
                output = "0" + (num).ToString();
            }
            else
            {
                output = (num).ToString();
            }
            return output;
        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserPath != "")
            {
                ListDirectory(treeView1, UserPath);
            }
        }
    }
}
