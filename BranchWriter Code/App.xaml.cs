﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace BranchWriter_Code
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void OnStartup(object sender, StartupEventArgs e)
        {
            if (e.Args.Length > 0)
            {
                FileHandler.PassPathToMain(e.Args[0]);
            }
            else
            {
                SelectFile selectFile = new SelectFile();
                selectFile.Show();
            }
        }
    }
}
