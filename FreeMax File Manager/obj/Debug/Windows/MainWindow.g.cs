﻿#pragma checksum "..\..\..\Windows\MainWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "2AAEDB984FE9C79848E2BCCC9F6944C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FolderView;
using FreeMax_File_Manager;
using FreeMax_File_Manager.Properties;
using FreeMax_File_Manager.Properties.UserSettings.Text.MainWindow;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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


namespace FreeMax_File_Manager.Windows {
    
    
    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FreeMax_File_Manager.Windows.MainWindow WMain;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FolderView.MyFolderView LbLeftPanel;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\..\Windows\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal FolderView.MyFolderView LbRightPanel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/FreeMax File Manager;component/windows/mainwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.WMain = ((FreeMax_File_Manager.Windows.MainWindow)(target));
            
            #line 19 "..\..\..\Windows\MainWindow.xaml"
            this.WMain.KeyUp += new System.Windows.Input.KeyEventHandler(this.wMain_KeyUp);
            
            #line default
            #line hidden
            
            #line 20 "..\..\..\Windows\MainWindow.xaml"
            this.WMain.KeyDown += new System.Windows.Input.KeyEventHandler(this.wMain_KeyDown);
            
            #line default
            #line hidden
            
            #line 21 "..\..\..\Windows\MainWindow.xaml"
            this.WMain.Activated += new System.EventHandler(this.WMain_Activated);
            
            #line default
            #line hidden
            
            #line 22 "..\..\..\Windows\MainWindow.xaml"
            this.WMain.Deactivated += new System.EventHandler(this.WMain_Deactivated);
            
            #line default
            #line hidden
            
            #line 23 "..\..\..\Windows\MainWindow.xaml"
            this.WMain.Loaded += new System.Windows.RoutedEventHandler(this.MainWindow_OnLoaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.LbLeftPanel = ((FolderView.MyFolderView)(target));
            return;
            case 3:
            this.LbRightPanel = ((FolderView.MyFolderView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

