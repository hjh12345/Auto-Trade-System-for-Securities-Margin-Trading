﻿#pragma checksum "..\..\..\Pages\BasicPage1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C8F08DD7B02E2E622A969F552E3E3505"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18034
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using FirstFloor.ModernUI.Presentation;
using FirstFloor.ModernUI.Windows;
using FirstFloor.ModernUI.Windows.Controls;
using FirstFloor.ModernUI.Windows.Converters;
using FirstFloor.ModernUI.Windows.Navigation;
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


namespace Project02.Pages {
    
    
    /// <summary>
    /// BasicPage1
    /// </summary>
    public partial class BasicPage1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox StokeCode;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SearchButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView listview1;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label LabelOfTime;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label StokeName;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox buycode;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox buyprice;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox buyamount;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PPbutton;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AutoButton;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\Pages\BasicPage1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Watching;
        
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
            System.Uri resourceLocater = new System.Uri("/Project02;component/pages/basicpage1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\BasicPage1.xaml"
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
            this.StokeCode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.SearchButton = ((System.Windows.Controls.Button)(target));
            
            #line 39 "..\..\..\Pages\BasicPage1.xaml"
            this.SearchButton.Click += new System.Windows.RoutedEventHandler(this.SearchButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.listview1 = ((System.Windows.Controls.ListView)(target));
            
            #line 40 "..\..\..\Pages\BasicPage1.xaml"
            this.listview1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.listview1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.LabelOfTime = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.StokeName = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.buycode = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.buyprice = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.buyamount = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.PPbutton = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\Pages\BasicPage1.xaml"
            this.PPbutton.Click += new System.Windows.RoutedEventHandler(this.PPbutton_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AutoButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Pages\BasicPage1.xaml"
            this.AutoButton.Click += new System.Windows.RoutedEventHandler(this.AutoButton_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.Watching = ((System.Windows.Controls.Button)(target));
            
            #line 60 "..\..\..\Pages\BasicPage1.xaml"
            this.Watching.Click += new System.Windows.RoutedEventHandler(this.Watching_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

