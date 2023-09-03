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

        public static bool WriteToFile(string writePath, string textToEnter)
        {
            if (File.Exists(writePath))
            {
                using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(writePath)))
                {
                    writer.Write(textToEnter);
                    return true;
                }
            }

            else return false;
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
    }
}
