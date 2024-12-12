﻿#pragma checksum "..\..\..\..\Course\ViewCourseManage.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "D5CEEC2785E537F5931DEACDC5249BD9AC8A9ECC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CourseManagementSystem.Course;
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


namespace CourseManagementSystem.Course {
    
    
    /// <summary>
    /// ViewCourseManage
    /// </summary>
    public partial class ViewCourseManage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\Course\ViewCourseManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbFilterTitle;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\Course\ViewCourseManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cboFilterCredits;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\..\Course\ViewCourseManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClearFilter;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Course\ViewCourseManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAddCourse;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\..\Course\ViewCourseManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnUpdateCourse;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\..\Course\ViewCourseManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnChangeStatus;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\Course\ViewCourseManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnViewAssessments;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\Course\ViewCourseManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnClose;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Course\ViewCourseManage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dgCourses;
        
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
            System.Uri resourceLocater = new System.Uri("/CourseManagementSystem;component/course/viewcoursemanage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Course\ViewCourseManage.xaml"
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
            this.cbFilterTitle = ((System.Windows.Controls.ComboBox)(target));
            
            #line 32 "..\..\..\..\Course\ViewCourseManage.xaml"
            this.cbFilterTitle.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterCourses);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cboFilterCredits = ((System.Windows.Controls.ComboBox)(target));
            
            #line 34 "..\..\..\..\Course\ViewCourseManage.xaml"
            this.cboFilterCredits.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.FilterCourses);
            
            #line default
            #line hidden
            return;
            case 3:
            this.btnClearFilter = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\..\..\Course\ViewCourseManage.xaml"
            this.btnClearFilter.Click += new System.Windows.RoutedEventHandler(this.btnClearFilter_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnAddCourse = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\..\..\Course\ViewCourseManage.xaml"
            this.btnAddCourse.Click += new System.Windows.RoutedEventHandler(this.btnAddCourse_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnUpdateCourse = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\..\Course\ViewCourseManage.xaml"
            this.btnUpdateCourse.Click += new System.Windows.RoutedEventHandler(this.btnUpdateCourse_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnChangeStatus = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\..\Course\ViewCourseManage.xaml"
            this.btnChangeStatus.Click += new System.Windows.RoutedEventHandler(this.btnChangeStatus_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnViewAssessments = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\..\Course\ViewCourseManage.xaml"
            this.btnViewAssessments.Click += new System.Windows.RoutedEventHandler(this.btnViewAssessments_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnClose = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\..\Course\ViewCourseManage.xaml"
            this.btnClose.Click += new System.Windows.RoutedEventHandler(this.btnClose_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.dgCourses = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

