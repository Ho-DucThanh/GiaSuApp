﻿#pragma checksum "..\..\..\View\DanhGia.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DF7501BA145155F1F7123634D737CB470BE9A32EF632CED0D2CB1605177B3A48"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Demo_Profile.View;
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


namespace Demo_Profile.View {
    
    
    /// <summary>
    /// DanhGia
    /// </summary>
    public partial class DanhGia : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 79 "..\..\..\View\DanhGia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock textRating;
        
        #line default
        #line hidden
        
        
        #line 81 "..\..\..\View\DanhGia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtRating;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\View\DanhGia.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnRating;
        
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
            System.Uri resourceLocater = new System.Uri("/Demo_Profile;component/view/danhgia.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\DanhGia.xaml"
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
            
            #line 22 "..\..\..\View\DanhGia.xaml"
            ((System.Windows.Controls.Border)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Border_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 41 "..\..\..\View\DanhGia.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 48 "..\..\..\View\DanhGia.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 55 "..\..\..\View\DanhGia.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 62 "..\..\..\View\DanhGia.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 69 "..\..\..\View\DanhGia.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseLeftButtonDown_1);
            
            #line default
            #line hidden
            return;
            case 7:
            this.textRating = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.txtRating = ((System.Windows.Controls.TextBox)(target));
            
            #line 81 "..\..\..\View\DanhGia.xaml"
            this.txtRating.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.txtRating_TextChanged);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnRating = ((System.Windows.Controls.Button)(target));
            
            #line 86 "..\..\..\View\DanhGia.xaml"
            this.btnRating.Click += new System.Windows.RoutedEventHandler(this.ratingButtonClick);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

