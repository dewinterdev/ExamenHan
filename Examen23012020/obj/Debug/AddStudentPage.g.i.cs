﻿#pragma checksum "..\..\AddStudentPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B382AB195E57FDA4EE843E20EB88477FFA4670EEDDB71B5CBC238EF25A48DCA1"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Examen23012020;
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


namespace Examen23012020 {
    
    
    /// <summary>
    /// AddStudentPage
    /// </summary>
    public partial class AddStudentPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 25 "..\..\AddStudentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxFirstName;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\AddStudentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxLastName;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\AddStudentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxClassNumber;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\AddStudentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSaveStudent;
        
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
            System.Uri resourceLocater = new System.Uri("/Examen23012020;component/addstudentpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddStudentPage.xaml"
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
            this.TextBoxFirstName = ((System.Windows.Controls.TextBox)(target));
            
            #line 25 "..\..\AddStudentPage.xaml"
            this.TextBoxFirstName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxFirstName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxLastName = ((System.Windows.Controls.TextBox)(target));
            
            #line 29 "..\..\AddStudentPage.xaml"
            this.TextBoxLastName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxLastName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBoxClassNumber = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\AddStudentPage.xaml"
            this.TextBoxClassNumber.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxClassNumber_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.ButtonSaveStudent = ((System.Windows.Controls.Button)(target));
            
            #line 35 "..\..\AddStudentPage.xaml"
            this.ButtonSaveStudent.Click += new System.Windows.RoutedEventHandler(this.ButtonSaveStudent_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

