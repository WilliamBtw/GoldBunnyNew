﻿#pragma checksum "..\..\..\wind1s\WindowAddOrder.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7774DD9D92E9BA2C7F6A23CB690AE5B8B54FAEE74E44A2E5683C90634DFC65B8"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using GoldBunny.wind1s;
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


namespace GoldBunny.wind1s {
    
    
    /// <summary>
    /// WindowAddOrder
    /// </summary>
    public partial class WindowAddOrder : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\wind1s\WindowAddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbServiceNameService;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\wind1s\WindowAddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txbDateOrder;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\wind1s\WindowAddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbStaffNameStaff;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\wind1s\WindowAddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbNamePet;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\wind1s\WindowAddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbClientName;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\wind1s\WindowAddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveOrder;
        
        #line default
        #line hidden
        
        
        #line 95 "..\..\..\wind1s\WindowAddOrder.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelOrder;
        
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
            System.Uri resourceLocater = new System.Uri("/GoldBunny;component/wind1s/windowaddorder.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\wind1s\WindowAddOrder.xaml"
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
            this.cmbServiceNameService = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 2:
            this.txbDateOrder = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.cmbStaffNameStaff = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.cmbNamePet = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.cmbClientName = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.btnSaveOrder = ((System.Windows.Controls.Button)(target));
            
            #line 80 "..\..\..\wind1s\WindowAddOrder.xaml"
            this.btnSaveOrder.Click += new System.Windows.RoutedEventHandler(this.btnSaveOrder_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnCancelOrder = ((System.Windows.Controls.Button)(target));
            
            #line 96 "..\..\..\wind1s\WindowAddOrder.xaml"
            this.btnCancelOrder.Click += new System.Windows.RoutedEventHandler(this.btnCancelOrder_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

