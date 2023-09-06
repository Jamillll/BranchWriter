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

        public static string? ReadFromFile(string readPath)
        {
            if (File.Exists(readPath))
            {
                using (BinaryReader reader = new BinaryReader(File.OpenRead(readPath)))
                {
                    return reader.ReadString();
                }
            }

            else return null;
        }
        
        public static void PassPathToMain(string passingPath)
        {
            MainWindow.path = passingPath;
        }
    }
}
