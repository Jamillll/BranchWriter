using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BranchWriter_Code
{
    /// <summary>
    /// Interaction logic for SelectFile.xaml
    /// </summary>
    public partial class SelectFile : Window
    {
        public SelectFile()
        {
            InitializeComponent();
        }

        private void WindowBarMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void CloseButton(object sender, RoutedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void FileDropped(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, true);

                if (FileHandler.IsLeaf(filePaths[0]))
                {
                    FileHandler.path = filePaths[0];
                }

                else
                {
                    MessageBox.Show("Please only drop in leaf files.");
                    return;
                }
            }

            this.Close();

        }

        private void FileOpenerClicked(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileExplorer = new OpenFileDialog();
            fileExplorer.Multiselect = false;

            if (fileExplorer.ShowDialog() == true)
            {
                if (FileHandler.IsLeaf(fileExplorer.FileName))
                {
                    FileHandler.path = fileExplorer.FileName;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Please select one leaf file");
                    return;
                }
            }
        }
    }
}
