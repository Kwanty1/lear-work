﻿#pragma checksum "..\..\Catalog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2F7DC957F7B5029A96D6CCD9CD3530A3591487FA40228B62BCAF06AF27EF5D1F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using ToyShopWpf;


namespace ToyShopWpf {
    
    
    /// <summary>
    /// Catalog
    /// </summary>
    public partial class Catalog : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 27 "..\..\Catalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Car;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\Catalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Doll;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\Catalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Puzle;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Catalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CarCheck;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Catalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CarDoll;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Catalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox CarPuzle;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\Catalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox basketCar;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\Catalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox basketDoll;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\Catalog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox basketPuzle;
        
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
            System.Uri resourceLocater = new System.Uri("/ToyShopWpf;component/catalog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Catalog.xaml"
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
            this.Car = ((System.Windows.Controls.Label)(target));
            return;
            case 2:
            this.Doll = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.Puzle = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.CarCheck = ((System.Windows.Controls.CheckBox)(target));
            
            #line 40 "..\..\Catalog.xaml"
            this.CarCheck.Checked += new System.Windows.RoutedEventHandler(this.CarCheck_Checked);
            
            #line default
            #line hidden
            
            #line 40 "..\..\Catalog.xaml"
            this.CarCheck.Unchecked += new System.Windows.RoutedEventHandler(this.CarCheck_Unchecked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.CarDoll = ((System.Windows.Controls.CheckBox)(target));
            
            #line 41 "..\..\Catalog.xaml"
            this.CarDoll.Checked += new System.Windows.RoutedEventHandler(this.CarDoll_Checked);
            
            #line default
            #line hidden
            
            #line 41 "..\..\Catalog.xaml"
            this.CarDoll.Unchecked += new System.Windows.RoutedEventHandler(this.CarDoll_Unchecked);
            
            #line default
            #line hidden
            return;
            case 6:
            this.CarPuzle = ((System.Windows.Controls.CheckBox)(target));
            
            #line 42 "..\..\Catalog.xaml"
            this.CarPuzle.Checked += new System.Windows.RoutedEventHandler(this.CarPuzle_Checked);
            
            #line default
            #line hidden
            
            #line 42 "..\..\Catalog.xaml"
            this.CarPuzle.Unchecked += new System.Windows.RoutedEventHandler(this.CarPuzle_Unchecked);
            
            #line default
            #line hidden
            return;
            case 7:
            this.basketCar = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.basketDoll = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.basketPuzle = ((System.Windows.Controls.TextBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

