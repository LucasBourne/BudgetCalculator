﻿#pragma checksum "..\..\Budget Calculator.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "E0C93024089DF127554A996934757D6A6BFF9124"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using BudgetCalculator;
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


namespace BudgetCalculator {
    
    
    /// <summary>
    /// Budget_Calculator
    /// </summary>
    public partial class Budget_Calculator : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\Budget Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Calendar Cal;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\Budget Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubButton;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\Budget Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddButton;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\Budget Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox RemainingWeekTextBox;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\Budget Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TransactionTextBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\Budget Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button QuitButton;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\Budget Calculator.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AccessPoolButton;
        
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
            System.Uri resourceLocater = new System.Uri("/BudgetCalculator;component/budget%20calculator.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Budget Calculator.xaml"
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
            this.Cal = ((System.Windows.Controls.Calendar)(target));
            
            #line 10 "..\..\Budget Calculator.xaml"
            this.Cal.SelectedDatesChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.Cal_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.SubButton = ((System.Windows.Controls.Button)(target));
            
            #line 11 "..\..\Budget Calculator.xaml"
            this.SubButton.Click += new System.Windows.RoutedEventHandler(this.SubButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.AddButton = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.RemainingWeekTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.TransactionTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.QuitButton = ((System.Windows.Controls.Button)(target));
            
            #line 16 "..\..\Budget Calculator.xaml"
            this.QuitButton.Click += new System.Windows.RoutedEventHandler(this.QuitButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.AccessPoolButton = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\Budget Calculator.xaml"
            this.AccessPoolButton.Click += new System.Windows.RoutedEventHandler(this.AccessPoolButton_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

