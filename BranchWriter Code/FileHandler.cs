using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BranchWriter_Code
{
    internal static class FileHandler
    {
        public static string? path = null;

        public static bool IsLeaf(string checkPath)
        {
            if (checkPath.Split('.')[^1] == "leaf") return true;
            else return false;
        }

        public static bool WriteToFile(string textToEnter)
        {
            if (path != null)
            {
                using (BinaryWriter writer = new BinaryWriter(File.OpenWrite(path)))
                {
                    writer.Write(textToEnter);
                    return true;
                }
            }

            else return false;
        }
    }
}
