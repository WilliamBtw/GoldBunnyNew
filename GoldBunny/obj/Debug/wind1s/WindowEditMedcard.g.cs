#pragma checksum "..\..\..\wind1s\WindowEditMedcard.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F083D9E6832A9DA1D5846FA0B8B9C9682460458D7F1678610ED654D9204536D"
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
    /// WindowEditMedcard
    /// </summary>
    public partial class WindowEditMedcard : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 30 "..\..\..\wind1s\WindowEditMedcard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtNamePet;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\wind1s\WindowEditMedcard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbTypePet;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\wind1s\WindowEditMedcard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker JoinDateDatePicker;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\wind1s\WindowEditMedcard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cmbGender;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\wind1s\WindowEditMedcard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSaveMedcard;
        
        #line default
        #line hidden
        
        
        #line 89 "..\..\..\wind1s\WindowEditMedcard.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCancelMedcard;
        
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
            System.Uri resourceLocater = new System.Uri("/GoldBunny;component/wind1s/windoweditmedcard.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\wind1s\WindowEditMedcard.xaml"
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
            this.txtNamePet = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.cmbTypePet = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.JoinDateDatePicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.cmbGender = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.btnSaveMedcard = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\wind1s\WindowEditMedcard.xaml"
            this.btnSaveMedcard.Click += new System.Windows.RoutedEventHandler(this.btnSaveMedcard_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnCancelMedcard = ((System.Windows.Controls.Button)(target));
            
            #line 90 "..\..\..\wind1s\WindowEditMedcard.xaml"
            this.btnCancelMedcard.Click += new System.Windows.RoutedEventHandler(this.btnCancelMedcard_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

