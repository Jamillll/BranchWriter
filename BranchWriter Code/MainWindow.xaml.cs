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
using System.Windows.Media.Animation;
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

        List<string> fontList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void MainLoaded(object sender, RoutedEventArgs e)
        {
            foreach (var font in Fonts.SystemFontFamilies)
            {
                FontMenu.Items.Add(font);
                fontList.Add(font.ToString());
            }

            for (int i = 0; i < 50; i++)
            {
                FontSizeMenu.Items.Add(i + 1);
            }
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
                isMaximised = true;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                isMaximised = false;
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

        private void TextEffectClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            var oldBoldState = DisplayPage1.Selection.GetPropertyValue(TextElement.FontWeightProperty);
            var oldItalicState = DisplayPage1.Selection.GetPropertyValue(TextElement.FontStyleProperty);

            switch (button.Name)
            {
                case "Bold":
                    DisplayPage1.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);

                    if (DisplayPage1.Selection.GetPropertyValue(TextElement.FontWeightProperty) == oldBoldState)
                    {
                        DisplayPage1.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
                    }
                break;

                case "Italic":
                    DisplayPage1.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);

                    if (DisplayPage1.Selection.GetPropertyValue(TextElement.FontStyleProperty) == oldItalicState)
                    {
                        DisplayPage1.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
                    }
                    break;

                case "Remove":
                    DisplayPage1.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
                    DisplayPage1.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
                    break;
            }
        }

        private void FontSelected(object sender, SelectionChangedEventArgs e)
        {
            if (DisplayPage1.Selection.Text.Length > 0)
            {
                DisplayPage1.Selection.ApplyPropertyValue(TextElement.FontFamilyProperty, new FontFamily(fontList[FontMenu.SelectedIndex]));
            }
        }

        private void FontSizeSelected(object sender, SelectionChangedEventArgs e)
        {
            if (DisplayPage1.Selection.Text.Length > 0)
            {
                DisplayPage1.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, Convert.ToDouble(FontSizeMenu.SelectedIndex + 1));
            }
        }
    }
}
