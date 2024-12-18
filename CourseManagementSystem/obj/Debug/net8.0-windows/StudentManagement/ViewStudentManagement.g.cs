﻿#pragma checksum "..\..\..\..\StudentManagement\ViewStudentManagement.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "752682605AC4BCD6D4A6C1E5DFC57530F9BBA738"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseManagementSystem.StudentManagement;
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


namespace CourseManagementSystem.StudentManagement {
    
    
    /// <summary>
    /// ViewStudentManagement
    /// </summary>
    public partial class ViewStudentManagement : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 51 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSearchName;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboGender;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboCountry;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboDepartment;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClearFilter;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddStudent;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnExport;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnImport;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgData;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseManagementSystem;component/studentmanagement/viewstudentmanagement.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
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
            this.txtSearchName = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
            this.txtSearchName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtSearchName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboGender = ((System.Windows.Controls.ComboBox)(target));
            
            #line 53 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
            this.cboGender.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.filter);
            
            #line default
            #line hidden
            return;
            case 3:
            this.cboCountry = ((System.Windows.Controls.ComboBox)(target));
            
            #line 55 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
            this.cboCountry.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.filter);
            
            #line default
            #line hidden
            return;
            case 4:
            this.cboDepartment = ((System.Windows.Controls.ComboBox)(target));
            
            #line 57 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
            this.cboDepartment.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.filter);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnClearFilter = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
            this.btnClearFilter.Click += new System.Windows.RoutedEventHandler(this.ClearBtn_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnAddStudent = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
            this.btnAddStudent.Click += new System.Windows.RoutedEventHandler(this.AddBtn_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnExport = ((System.Windows.Controls.Button)(target));
            
            #line 62 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
            this.btnExport.Click += new System.Windows.RoutedEventHandler(this.ExportBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnImport = ((System.Windows.Controls.Button)(target));
            
            #line 64 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
            this.btnImport.Click += new System.Windows.RoutedEventHandler(this.ImportBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgData = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 10:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 81 "..\..\..\..\StudentManagement\ViewStudentManagement.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

