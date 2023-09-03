﻿using System;
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
    }
}
