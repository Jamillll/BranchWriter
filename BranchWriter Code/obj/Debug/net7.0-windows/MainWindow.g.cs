﻿#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A961AFF75DDBB10CFDC910C5CFB0987D7E47B262"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BranchWriter_Code;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace BranchWriter_Code {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal BranchWriter_Code.MainWindow Main;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock displayPath;
        
        #line default
        #line hidden
        
        
        #line 105 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Bold;
        
        #line default
        #line hidden
        
        
        #line 114 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Italic;
        
        #line default
        #line hidden
        
        
        #line 125 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Remove;
        
        #line default
        #line hidden
        
        
        #line 140 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontMenu;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox FontSizeMenu;
        
        #line default
        #line hidden
        
        
        #line 157 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RichTextBox DisplayPage1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/BranchWriter Code;component/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Main = ((BranchWriter_Code.MainWindow)(target));
            
            #line 12 "..\..\..\MainWindow.xaml"
            this.Main.Loaded += new System.Windows.RoutedEventHandler(this.MainLoaded);
            
            #line default
            #line hidden
            
            #line 13 "..\..\..\MainWindow.xaml"
            this.Main.MouseEnter += new System.Windows.Input.MouseEventHandler(this.WindowMouseHover);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 45 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.TextBlock)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowBarMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.displayPath = ((System.Windows.Controls.TextBlock)(target));
            
            #line 54 "..\..\..\MainWindow.xaml"
            this.displayPath.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.WindowBarMouseDown);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 60 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.MinimiseButton);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 66 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SizeChangeButton);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 72 "..\..\..\MainWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CloseButton);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Bold = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\MainWindow.xaml"
            this.Bold.Click += new System.Windows.RoutedEventHandler(this.TextEffectClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Italic = ((System.Windows.Controls.Button)(target));
            
            #line 119 "..\..\..\MainWindow.xaml"
            this.Italic.Click += new System.Windows.RoutedEventHandler(this.TextEffectClick);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Remove = ((System.Windows.Controls.Button)(target));
            
            #line 130 "..\..\..\MainWindow.xaml"
            this.Remove.Click += new System.Windows.RoutedEventHandler(this.TextEffectClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.FontMenu = ((System.Windows.Controls.ComboBox)(target));
            
            #line 144 "..\..\..\MainWindow.xaml"
            this.FontMenu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontSelected);
            
            #line default
            #line hidden
            return;
            case 11:
            this.FontSizeMenu = ((System.Windows.Controls.ComboBox)(target));
            
            #line 152 "..\..\..\MainWindow.xaml"
            this.FontSizeMenu.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FontSizeSelected);
            
            #line default
            #line hidden
            return;
            case 12:
            this.DisplayPage1 = ((System.Windows.Controls.RichTextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

