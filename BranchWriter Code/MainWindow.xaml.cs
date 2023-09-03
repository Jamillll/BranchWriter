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
        bool isMaximised = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CloseButton(object sender, RoutedEventArgs e)
        {
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

        private void tempSave(object sender, MouseButtonEventArgs e)
        {
            if (FileHandler.WriteToFile(DisplayPage1.Text))
            {
                MessageBox.Show("It worked");
            }
        }
    }
}
