﻿#pragma checksum "..\..\..\AddSchdule.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D0488939B54BF2473F52B630E3A0E6B9EB4357C2"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Finally;
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


namespace Finally {
    
    
    /// <summary>
    /// AddSchdule
    /// </summary>
    public partial class AddSchdule : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\AddSchdule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SubjectComboBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\AddSchdule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ClassComboBox;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\AddSchdule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox TeacherCombobox;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\AddSchdule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpkTimeLearn;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\AddSchdule.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbxSlot;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Finally;component/addschdule.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddSchdule.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.11.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.SubjectComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\AddSchdule.xaml"
            this.SubjectComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.SubjectComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ClassComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 38 "..\..\..\AddSchdule.xaml"
            this.ClassComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ClassComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TeacherCombobox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 43 "..\..\..\AddSchdule.xaml"
            this.TeacherCombobox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.TeacherCombobox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.dpkTimeLearn = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 5:
            this.cbxSlot = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            
            #line 53 "..\..\..\AddSchdule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 54 "..\..\..\AddSchdule.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
