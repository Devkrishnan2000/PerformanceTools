﻿#pragma checksum "..\..\..\Usercontrol\CPU.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "A71CC16CDCB6C32CB8E211111B30CD05734A310EC5878315EB648D24F9BDE20D"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using LiveCharts.Wpf;
using Performance_Tools.Usercontrol;
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


namespace Performance_Tools.Usercontrol {
    
    
    /// <summary>
    /// CPU
    /// </summary>
    public partial class CPU : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 22 "..\..\..\Usercontrol\CPU.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Gauge tempgaugeCPU;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\Usercontrol\CPU.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ClockspdCPU;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Usercontrol\CPU.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal LiveCharts.Wpf.Gauge tempgaugeGPU;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Usercontrol\CPU.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ClockspdGPU;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Usercontrol\CPU.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label cpufam;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Usercontrol\CPU.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label ver;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Usercontrol\CPU.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label stapm;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Usercontrol\CPU.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label temp;
        
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
            System.Uri resourceLocater = new System.Uri("/PerformanceTools;component/usercontrol/cpu.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Usercontrol\CPU.xaml"
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
            this.tempgaugeCPU = ((LiveCharts.Wpf.Gauge)(target));
            return;
            case 2:
            this.ClockspdCPU = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.tempgaugeGPU = ((LiveCharts.Wpf.Gauge)(target));
            return;
            case 4:
            this.ClockspdGPU = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.cpufam = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.ver = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.stapm = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.temp = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

