﻿#pragma checksum "..\..\..\..\..\Views\Selection\CellSelection.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85DEB1523EEDF4D890E8DD9E9807D90D169EE3F6"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Xaml.Behaviors;
using Microsoft.Xaml.Behaviors.Core;
using Microsoft.Xaml.Behaviors.Input;
using Microsoft.Xaml.Behaviors.Layout;
using Microsoft.Xaml.Behaviors.Media;
using Syncfusion;
using Syncfusion.PivotAnalysis.Base;
using Syncfusion.SfSkinManager;
using Syncfusion.UI.Xaml.Controls.DataPager;
using Syncfusion.UI.Xaml.Grid;
using Syncfusion.UI.Xaml.Grid.RowFilter;
using Syncfusion.UI.Xaml.TreeGrid;
using Syncfusion.UI.Xaml.TreeGrid.Filtering;
using Syncfusion.Windows;
using Syncfusion.Windows.Collections;
using Syncfusion.Windows.ComponentModel;
using Syncfusion.Windows.Controls.Cells;
using Syncfusion.Windows.Controls.Grid;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Controls.PivotGrid;
using Syncfusion.Windows.Controls.PivotSchemaDesigner;
using Syncfusion.Windows.Controls.Scroll;
using Syncfusion.Windows.Controls.VirtualTreeView;
using Syncfusion.Windows.Data;
using Syncfusion.Windows.Diagnostics;
using Syncfusion.Windows.GridCommon;
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Styles;
using Syncfusion.Windows.Tools;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
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
using syncfusion.demoscommon.wpf;
using syncfusion.pivotgriddemos.wpf;


namespace syncfusion.pivotgriddemos.wpf {
    
    
    /// <summary>
    /// CellSelection
    /// </summary>
    public partial class CellSelection : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\..\..\Views\Selection\CellSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.PivotGrid.PivotGridControl pivotGrid1;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\..\..\Views\Selection\CellSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lstSelectedItems;
        
        #line default
        #line hidden
        
        
        #line 101 "..\..\..\..\..\Views\Selection\CellSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.PivotSchemaDesigner.PivotSchemaDesigner SchemaDesigner;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\..\Views\Selection\CellSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chkBoxAllowSelection;
        
        #line default
        #line hidden
        
        
        #line 115 "..\..\..\..\..\Views\Selection\CellSelection.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton chkBoxAllowSelectionwithheaders;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/syncfusion.pivotgriddemos.wpf;component/views/selection/cellselection.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Selection\CellSelection.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal System.Delegate _CreateDelegate(System.Type delegateType, string handler) {
            return System.Delegate.CreateDelegate(delegateType, this, handler);
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.pivotGrid1 = ((Syncfusion.Windows.Controls.PivotGrid.PivotGridControl)(target));
            return;
            case 2:
            this.lstSelectedItems = ((System.Windows.Controls.ListBox)(target));
            return;
            case 3:
            this.SchemaDesigner = ((Syncfusion.Windows.Controls.PivotSchemaDesigner.PivotSchemaDesigner)(target));
            return;
            case 4:
            this.chkBoxAllowSelection = ((System.Windows.Controls.RadioButton)(target));
            
            #line 111 "..\..\..\..\..\Views\Selection\CellSelection.xaml"
            this.chkBoxAllowSelection.Unchecked += new System.Windows.RoutedEventHandler(this.chkBoxAllowSelection_Unchecked);
            
            #line default
            #line hidden
            
            #line 112 "..\..\..\..\..\Views\Selection\CellSelection.xaml"
            this.chkBoxAllowSelection.Checked += new System.Windows.RoutedEventHandler(this.chkBoxAllowSelection_Checked);
            
            #line default
            #line hidden
            return;
            case 5:
            this.chkBoxAllowSelectionwithheaders = ((System.Windows.Controls.RadioButton)(target));
            
            #line 118 "..\..\..\..\..\Views\Selection\CellSelection.xaml"
            this.chkBoxAllowSelectionwithheaders.Unchecked += new System.Windows.RoutedEventHandler(this.chkBoxAllowSelection_Unchecked);
            
            #line default
            #line hidden
            
            #line 119 "..\..\..\..\..\Views\Selection\CellSelection.xaml"
            this.chkBoxAllowSelectionwithheaders.Checked += new System.Windows.RoutedEventHandler(this.chkBoxAllowSelectionwithheaders_Checked);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

