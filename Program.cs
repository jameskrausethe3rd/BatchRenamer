using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchRenamer
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        /// <summary>
        /// Renames the files and folders in the selected directory. Checks if it is a nested folder, then renames the files accordingly
        /// </summary>
        public void Rename(string userPath, string filePrefix, string folderPrefix, string startingPoint, string selectedFileExtension)
        {
            if (CheckArgs(userPath, filePrefix, folderPrefix, startingPoint))
            {
                //Checks if there are more directories or not
                if (GetDirectories(userPath).Length != 0)
                {
                    RenameDirectories(userPath, filePrefix, folderPrefix, startingPoint, selectedFileExtension);
                }
                else
                {
                    RenameFiles(userPath, filePrefix, selectedFileExtension);
                }
                MessageBox.Show("Files renamed!");
            }
            else
            {
                MessageBox.Show("Please select a folder first or check the prefixes");
            }
        }
        /// <summary>
        /// Renames the files in the <i>userPath</i> using the <i>filePrefix</i>.
        /// </summary>
        static void RenameFiles(string userPath, string filePrefix, string selectedFileExtension)
        {
            //Loop through each file
            foreach (var file in GetFiles(userPath, selectedFileExtension).Select((name, index) => (name, index)))
            {
                string fileNum = AddLeadingZero(file.index + 1);
                string fileExtension = Path.GetExtension(file.name);
                string folderName = GetLastDirectoryName(userPath);
                string newFileName = Path.Combine(userPath, ($"{folderName}{filePrefix}" + fileNum + fileExtension));
                File.Move(file.name, newFileName);
            }
        }
        /// <summary>
        /// Renames the directories in the <i>userPath</i> using the <i>folderPrefix</i>. Calls <i>RenameFiles</i> to rename the files in the directory.
        /// </summary>
        static void RenameDirectories(string userPath, string filePrefix, string folderPrefix, string startingPoint, string selectedFileExtension)
        {
            foreach (var directory in GetDirectories(userPath).Select((name, index) => (name, index)))
            {
                string directoryNum = AddLeadingZero(directory.index + int.Parse(startingPoint));
                string newPath = Path.Combine(userPath, ($"{folderPrefix}" + directoryNum));

                //Check if directory exists
                if (Directory.Exists(directory.name) && (directory.name != newPath))
                {
                    Directory.Move(directory.name, newPath);
                }

                //Loop through each file
                RenameFiles(newPath, filePrefix, selectedFileExtension);
            }
        }
        /// <summary>
        /// Returns a string array with the directories in the location <i>userPath</i>.
        /// </summary>
        static string[] GetDirectories(string userPath)
        {
            return Directory.GetDirectories(userPath, "*", SearchOption.TopDirectoryOnly);
        }
        /// <summary>
        /// Returns a string of the folder the file will be contained in.
        /// </summary>
        static string GetLastDirectoryName(string userPath)
        {
            return new DirectoryInfo(userPath).Name;
        }
        /// <summary>
        /// Returns a string array with the files in the location <i>directoryPath</i>.
        /// </summary>
        static string[] GetFiles(string directoryPath, string selectedFileExtension)
        {
            return Directory.GetFiles(directoryPath, "*" + selectedFileExtension, SearchOption.AllDirectories);
        }
        /// <summary>
        /// Checks the parameters given from the user to make sure none of them will cause errors.
        /// </summary>
        static bool CheckArgs(string userPath, string filePrefix, string folderPrefix, string startingPoint)
        {
            if (userPath != "" && filePrefix != "" && folderPrefix != "" && startingPoint != "")
            {
                if (filePrefix.Contains(@"\") || filePrefix.Contains(@"/"))
                {
                    return false;
                }
                if (folderPrefix.Contains(@"\") || folderPrefix.Contains(@"/"))
                {
                    return false;
                }
                if (startingPoint.Contains(@"\") || startingPoint.Contains(@"/"))
                {
                    return false;
                }
                return true;
            }
            return false;
        }
        /// <summary>
        /// Adds a leading zero to <i>num</i> if it is less than 2 digits (0-9).
        /// </summary>
        static string AddLeadingZero(int num)
        {
            string output;

            if (num< 10)
            {
                output = "0" + (num).ToString();
            }
            else
            {
                output = (num).ToString();
            }

            return output;
        }
        /// <summary>
        /// Gets a list of all the file extensions in the selected folder to populate the File Extension dropdown.
        /// </summary>       
        public static List<string> GetFileExtensions(string userPath)
        {
            HashSet<string> fileExtensions = new HashSet<string>();

            void LoopThroughFiles()
            {
                foreach (var file in Directory.GetFiles(userPath, "*", SearchOption.AllDirectories))
                {
                    string fileExtension = Path.GetExtension(file);
                    fileExtensions.Add(fileExtension);
                }
            }

            //Checks if there are more directories or not
            if (GetDirectories(userPath).Length != 0)
            {
                foreach (var directory in GetDirectories(userPath))
                {
                    LoopThroughFiles();
                }
            }
            else
            {
                LoopThroughFiles();
            }
            return fileExtensions.ToList();
        }
    }
}
