﻿#pragma checksum "..\..\..\Dovidnik_Spivrobitnyky.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7F51CF958E133AC3B76663D651ECC0375879165371EB2286E3F030D65ECC594F"
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
using TestClient;


namespace TestClient {
    
    
    /// <summary>
    /// Dovidnik_Spivrobitnyky
    /// </summary>
    public partial class Dovidnik_Spivrobitnyky : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\..\Dovidnik_Spivrobitnyky.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MenuItem s_ch;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Dovidnik_Spivrobitnyky.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dg_countr;
        
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
            System.Uri resourceLocater = new System.Uri("/TestClient;component/dovidnik_spivrobitnyky.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Dovidnik_Spivrobitnyky.xaml"
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
            
            #line 8 "..\..\..\Dovidnik_Spivrobitnyky.xaml"
            ((TestClient.Dovidnik_Spivrobitnyky)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            
            #line 9 "..\..\..\Dovidnik_Spivrobitnyky.xaml"
            ((TestClient.Dovidnik_Spivrobitnyky)(target)).Closing += new System.ComponentModel.CancelEventHandler(this.Window_Closing);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 22 "..\..\..\Dovidnik_Spivrobitnyky.xaml"
            ((System.Windows.Controls.MenuItem)(target)).SubmenuOpened += new System.Windows.RoutedEventHandler(this.button_get_changes);
            
            #line default
            #line hidden
            return;
            case 3:
            this.s_ch = ((System.Windows.Controls.MenuItem)(target));
            return;
            case 4:
            
            #line 30 "..\..\..\Dovidnik_Spivrobitnyky.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.s_add_verf_data_click);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 31 "..\..\..\Dovidnik_Spivrobitnyky.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.s_delete_verf_data_click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 33 "..\..\..\Dovidnik_Spivrobitnyky.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.s_submit_changes_click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.dg_countr = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

