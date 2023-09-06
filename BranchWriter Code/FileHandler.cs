using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace BranchWriter_Code
{
    internal static class FileHandler
    {
        public static bool IsLeaf(string checkPath)
        {
            if (checkPath.Split('.')[^1] == "leaf") return true;
            else return false;
        }

        public static void WriteToFile(string writePath, TextRange content)
        {
            FileStream stream = new FileStream(writePath, FileMode.OpenOrCreate, FileAccess.ReadWrite);

            content.Save(stream, DataFormats.XamlPackage);
            stream.Close();
        }

        public static TextRange? ReadFromFile(string readPath, TextRange content)
        {
            if (File.Exists(readPath))
            {
                FileStream stream = new FileStream(readPath, FileMode.Open, FileAccess.ReadWrite);

                content.Load(stream, DataFormats.XamlPackage);
                stream.Close();
                return content;
            }
            else
            {
                return null;
            }
        }
        
        public static void PassPathToMain(string passingPath)
        {
            MainWindow.path = passingPath;
        }
    }
}
