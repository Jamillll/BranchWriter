using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BranchWriter_Code
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string? path;

        bool isMaximised = false;
        bool isLoaded = false;


        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void CloseButton(object sender, RoutedEventArgs e)
        {
            if (path != null)
            {
                FileHandler.WriteToFile(MainWindow.path, new TextRange(DisplayPage1.Document.ContentStart, DisplayPage1.Document.ContentEnd));
            }

            System.Environment.Exit(0);
        }

        private void SizeChangeButton(object sender, RoutedEventArgs e)
        {
            if (isMaximised == false)
            {
                this.WindowState = WindowState.Maximized;
                isMaximised= true;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void MinimiseButton(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void WindowBarMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void WindowMouseHover(object sender, MouseEventArgs e)
        {
            if (!isLoaded && path != null)
            {
                FileHandler.ReadFromFile(path, new TextRange(DisplayPage1.Document.ContentStart, DisplayPage1.Document.ContentEnd));
                displayPath.Text = path;
                isLoaded = true;
            }
        }

        //private void BoldClick(object sender, RoutedEventArgs e)
        //{
        //    string currentText = DisplayPage1.Text;
        //    string workingText = "";
        //    bool isBold = false;

        //    if (DisplayPage1.SelectionLength > 0)
        //    {
        //        if (currentText[DisplayPage1.SelectionStart] == '<')
        //        {
        //            isBold = true;
        //        }

        //        if (isBold)
        //        {
        //            for (int i = 0; i < currentText.Length; i++)
        //            {
        //                if (currentText[i] == '<' && currentText[i + 1] == 'b' && currentText[i + 2] == '>')
        //                {
        //                    i += 2;
        //                    continue;
        //                }
        //                else if (currentText[i] == '<' && currentText[i + 1] == '/' && currentText[i + 2] == 'b' && currentText[i + 3] == '>')
        //                {
        //                    i += 3;
        //                    continue;
        //                }

        //                workingText += currentText[i];
        //            }
        //        }
        //        else
        //        {
        //            bool boldCLosed = false;

        //            for (int i = 0; i < currentText.Length; i++)
        //            {
        //                if (i == DisplayPage1.SelectionStart)
        //                {
        //                    workingText += "<b>";
        //                }
        //                else if (i == DisplayPage1.SelectionStart + DisplayPage1.SelectionLength)
        //                {
        //                    workingText += "</b>";
        //                    boldCLosed = true;
        //                }

        //                workingText += currentText[i];
        //            }

        //            if (!boldCLosed)
        //            {
        //                workingText += "</b>";
        //            }
        //        }

        //        DisplayPage1.Text = workingText;
        //    }
        //}
    }
}
