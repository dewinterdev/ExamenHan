﻿#pragma checksum "..\..\AddPaymentPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "53072B7DD354401501804EA9F9BBD40F8E963E97D831051B6BEAF039207AC272"
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
    /// AddPaymentPage
    /// </summary>
    public partial class AddPaymentPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 26 "..\..\AddPaymentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxStudent;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\AddPaymentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxActivity;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\AddPaymentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxAmountToPay;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\AddPaymentPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSavePayment;
        
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
            System.Uri resourceLocater = new System.Uri("/Examen23012020;component/addpaymentpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\AddPaymentPage.xaml"
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
            
            #line 10 "..\..\AddPaymentPage.xaml"
            ((Examen23012020.AddPaymentPage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ComboBoxStudent = ((System.Windows.Controls.ComboBox)(target));
            
            #line 26 "..\..\AddPaymentPage.xaml"
            this.ComboBoxStudent.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.ComboBoxStudent_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBoxActivity = ((System.Windows.Controls.TextBox)(target));
            
            #line 30 "..\..\AddPaymentPage.xaml"
            this.TextBoxActivity.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxActivity_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.TextBoxAmountToPay = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\AddPaymentPage.xaml"
            this.TextBoxAmountToPay.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.TextBoxAmountToPay_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ButtonSavePayment = ((System.Windows.Controls.Button)(target));
            
            #line 36 "..\..\AddPaymentPage.xaml"
            this.ButtonSavePayment.Click += new System.Windows.RoutedEventHandler(this.ButtonSavePayment_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

