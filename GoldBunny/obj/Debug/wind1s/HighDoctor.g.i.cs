﻿#pragma checksum "..\..\..\wind1s\HighDoctor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5265107A79EF3582489389A2BA10881781CC0754989A567341427B42EF5D4B19"
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
    /// HighDoctor
    /// </summary>
    public partial class HighDoctor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 37 "..\..\..\wind1s\HighDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Logout;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\wind1s\HighDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Pacient;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\wind1s\HighDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Order;
        
        #line default
        #line hidden
        
        
        #line 86 "..\..\..\wind1s\HighDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ExitProfile;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\wind1s\HighDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Staff;
        
        #line default
        #line hidden
        
        
        #line 174 "..\..\..\wind1s\HighDoctor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Frame frmHomeMain;
        
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
            System.Uri resourceLocater = new System.Uri("/GoldBunny;component/wind1s/highdoctor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\wind1s\HighDoctor.xaml"
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
            
            #line 21 "..\..\..\wind1s\HighDoctor.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Logout = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\..\wind1s\HighDoctor.xaml"
            this.Logout.Click += new System.Windows.RoutedEventHandler(this.Logout_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Pacient = ((System.Windows.Controls.Button)(target));
            
            #line 58 "..\..\..\wind1s\HighDoctor.xaml"
            this.Pacient.Click += new System.Windows.RoutedEventHandler(this.Pacient_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.Order = ((System.Windows.Controls.Button)(target));
            
            #line 73 "..\..\..\wind1s\HighDoctor.xaml"
            this.Order.Click += new System.Windows.RoutedEventHandler(this.Order_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ExitProfile = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\wind1s\HighDoctor.xaml"
            this.ExitProfile.Click += new System.Windows.RoutedEventHandler(this.ExitProfile_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Staff = ((System.Windows.Controls.Button)(target));
            
            #line 105 "..\..\..\wind1s\HighDoctor.xaml"
            this.Staff.Click += new System.Windows.RoutedEventHandler(this.Staff_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.frmHomeMain = ((System.Windows.Controls.Frame)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

