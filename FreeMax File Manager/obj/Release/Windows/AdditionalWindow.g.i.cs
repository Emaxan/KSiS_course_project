﻿#pragma checksum "..\..\..\Windows\AdditionalWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B3713AE91ECF721057CF8D8F2C0C8125"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using FreeMax_File_Manager.Properties.UserSettings.Colors;
using FreeMax_File_Manager.Properties.UserSettings.Text.AdditionalWindow;
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
    /// AdditionalWindow
    /// </summary>
    public partial class AdditionalWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbTitle;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TbText;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox LbAttributes;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid LbDrives;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbNewElem;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TbRename;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label RealFileName;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BOk;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BYes;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BNo;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\..\Windows\AdditionalWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock BCancel;
        
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
            System.Uri resourceLocater = new System.Uri("/FreeMax File Manager;component/windows/additionalwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\AdditionalWindow.xaml"
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
            
            #line 11 "..\..\..\Windows\AdditionalWindow.xaml"
            ((FreeMax_File_Manager.Windows.AdditionalWindow)(target)).KeyUp += new System.Windows.Input.KeyEventHandler(this.OnKeyUp);
            
            #line default
            #line hidden
            
            #line 12 "..\..\..\Windows\AdditionalWindow.xaml"
            ((FreeMax_File_Manager.Windows.AdditionalWindow)(target)).Closed += new System.EventHandler(this.AdditionalWindow_OnClosed);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TbTitle = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TbText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.LbAttributes = ((System.Windows.Controls.ListBox)(target));
            
            #line 23 "..\..\..\Windows\AdditionalWindow.xaml"
            this.LbAttributes.GotFocus += new System.Windows.RoutedEventHandler(this.LbAttributes_OnGotFocus);
            
            #line default
            #line hidden
            
            #line 24 "..\..\..\Windows\AdditionalWindow.xaml"
            this.LbAttributes.LostFocus += new System.Windows.RoutedEventHandler(this.LbAttributes_OnLostFocus);
            
            #line default
            #line hidden
            return;
            case 5:
            this.LbDrives = ((System.Windows.Controls.Grid)(target));
            
            #line 41 "..\..\..\Windows\AdditionalWindow.xaml"
            this.LbDrives.GotFocus += new System.Windows.RoutedEventHandler(this.LbDrives_OnGotFocus);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\Windows\AdditionalWindow.xaml"
            this.LbDrives.LostFocus += new System.Windows.RoutedEventHandler(this.LbDrives_OnLostFocus);
            
            #line default
            #line hidden
            return;
            case 6:
            this.TbNewElem = ((System.Windows.Controls.TextBox)(target));
            
            #line 53 "..\..\..\Windows\AdditionalWindow.xaml"
            this.TbNewElem.KeyUp += new System.Windows.Input.KeyEventHandler(this.TbNewElem_OnKeyUp);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TbRename = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\Windows\AdditionalWindow.xaml"
            this.TbRename.KeyUp += new System.Windows.Input.KeyEventHandler(this.TbNewElem_OnKeyUp);
            
            #line default
            #line hidden
            return;
            case 8:
            this.RealFileName = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.BOk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.BYes = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.BNo = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            this.BCancel = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

