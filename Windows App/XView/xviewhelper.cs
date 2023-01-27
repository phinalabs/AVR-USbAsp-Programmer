using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace XView
{
    public class xviewhelper
    {
        /*default source folder where compiled files are stored.*/
        public static string defaultSourceFolder = string.Format(@"C:\Users\{0}\AppData\Local\Temp\", Environment.UserName);
        //public static string defaultSourceFolder = string.Format(@"D:\Documents and Settings\Administrator\Local Settings\Temp\");//@"C:\Users\{0}\AppData\Local\Temp\", Environment.UserName);
        public static string sourceFolder = defaultSourceFolder;
        /*path for target file.*/
        private static string targetFolder;
        public static string getTargetFolder
        {
            get { return targetFolder; }
            set { targetFolder = value; }
        }
        /*set sketch file name*/
        private static string hexName;
        public static string getHexName
        {
            get { return hexName; }
            set { hexName = value; }
        }
        /*message helper function*/
        public static void msg(string message)
        {
            MessageBox.Show(message, "XSoft", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        /*iterate through the directory to search for folder containing the files*/
        public static void TraverseTree(string root)
        {
            // Data structure to hold names of subfolders to be
            // examined for the compiled files.
            Stack<string> dirs = new Stack<string>(20);

            if (!System.IO.Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            dirs.Push(root);
            while (dirs.Count > 0)
            {
                string currentDir = dirs.Pop();
                string[] subDirs;
                try
                {
                    subDirs = System.IO.Directory.GetDirectories(currentDir);
                }
                // An UnauthorizedAccessException exception will be thrown if we do not have
                // discovery permission on a folder or file. It may or may not be acceptable 
                // to ignore the exception and continue enumerating the remaining files and 
                // folders. It is also possible (but unlikely) that a DirectoryNotFound exception 
                // will be raised. This will happen if currentDir has been deleted by
                // another application or thread after our call to Directory.Exists. The 
                // choice of which exceptions to catch depends entirely on the specific task 
                // you are intending to perform and also on how much you know with certainty 
                // about the systems on which this code will run.
                catch (UnauthorizedAccessException e)
                {
                    msg("Unauthorized access to the source path directory.");
                    continue;
                }
                catch (System.IO.DirectoryNotFoundException e)
                {
                    msg("Cannot find the specified source path directory.");
                    continue;
                }
                string[] files = null;
                try
                {
                    files = System.IO.Directory.GetFiles(currentDir);
                }
                catch (UnauthorizedAccessException e)
                {
                    msg("Unauthorized access to the source path directory.");
                    continue;
                }

                catch (System.IO.DirectoryNotFoundException e)
                {
                    msg("Cannot find the specified source path directory.");
                    continue;
                }
                // Perform the required action on each file here.
                // Modify this block to perform your required task.
                foreach (string file in files)
                {
                    try
                    {
                        //Perform whatever action is required in your scenario.
                        System.IO.FileInfo fi = new System.IO.FileInfo(file);
                        //Console.WriteLine("{0}: {1}, {2}", fi..Name, fi.Length, fi.CreationTime);
                        if (fi.Name.Equals(getHexName))
                        {
                            sourceFolder = fi.DirectoryName;
                            copyHex(getHexName);
                            break;
                        }
                    }
                    catch (System.IO.FileNotFoundException e)
                    {
                        // If file was deleted by a separate application
                        //  or thread since the call to TraverseTree()
                        // then just continue.
                        msg("sketch file not found.");
                        continue;
                    }
                }
                // Push the subdirectories onto the stack for traversal.
                // This could also be done before handing the files.
                foreach (string str in subDirs)
                    dirs.Push(str);
            }
        }
        ///copy the file
        public static void copyHex(string fileName)
        {
            try
            {
                string sourcePath = sourceFolder;
                string targetPath = getTargetFolder;
                // Use Path class to manipulate file and directory paths.
                string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
                string destFile = System.IO.Path.Combine(targetPath, fileName);
                // To copy a folder's contents to a new location:
                // Create a new target folder, if necessary.
                if (!System.IO.Directory.Exists(targetPath))
                {
                    System.IO.Directory.CreateDirectory(targetPath);
                }
                // To copy a file to another location and 
                // overwrite the destination file if it already exists.
                System.IO.File.Copy(sourceFile, destFile, true);
                // To copy all the files in one directory to another directory.
                // Get the files in the source folder. (To recursively iterate through
                // all subfolders under the current directory, see
                // "How to: Iterate Through a Directory Tree.")
                // Note: Check for target path was performed previously
                //       in this code example.
                /*
                if (System.IO.Directory.Exists(sourcePath))
                {
                    string[] files = System.IO.Directory.GetFiles(sourcePath);

                    // Copy the files and overwrite destination files if they already exist.
                    foreach (string s in files)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        fileName = System.IO.Path.GetFileName(s);
                        destFile = System.IO.Path.Combine(targetPath, fileName);
                        System.IO.File.Copy(s, destFile, true);
                    }
                }
                else
                {
                    Console.WriteLine("Source path does not exist!");
                }
                 * */
            }
            catch (Exception ex)
            {
                msg("File copy failed");
            }

        }
    }
}
