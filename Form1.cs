using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void button1_Click(object sender, EventArgs e)
        {
            fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lbl_userSelection.Text = fbd.SelectedPath;
                setUserPath(fbd.SelectedPath);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbl_userSelection_Click(object sender, EventArgs e)
        {

        }

        private void btn_rename_Click(object sender, EventArgs e)
        {
            otherFunctions.Rename(getUserPath(), getFilePrefix(), getFolderPrefix(), getStartingNumber());
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
