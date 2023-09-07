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

        private void BoldClick(object sender, RoutedEventArgs e)
        {
            var oldContent = DisplayPage1.Selection.GetPropertyValue(TextElement.FontWeightProperty);
            DisplayPage1.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);

            if (DisplayPage1.Selection.GetPropertyValue(TextElement.FontWeightProperty) == oldContent)
            {
                DisplayPage1.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
            }
        }
    }
}
