﻿#pragma checksum "..\..\..\..\..\Views\Interactive Features\Sorting.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95FCB9FB4F622348404A568F60837CB7099F1707"
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
    /// Sorting
    /// </summary>
    public partial class Sorting : syncfusion.demoscommon.wpf.DemoControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.PivotGrid.PivotGridControl pivotGrid1;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Controls.PivotSchemaDesigner.PivotSchemaDesigner SchemaDesigner;
        
        #line default
        #line hidden
        
        
        #line 83 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnSortAll;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnSortColumn;
        
        #line default
        #line hidden
        
        
        #line 96 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnSortTotal;
        
        #line default
        #line hidden
        
        
        #line 102 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnSortGrandTotal;
        
        #line default
        #line hidden
        
        
        #line 108 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton btnSortNone;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.pivotgriddemos.wpf;component/views/interactive%20features/sorting.xam" +
                    "l", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
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
            this.SchemaDesigner = ((Syncfusion.Windows.Controls.PivotSchemaDesigner.PivotSchemaDesigner)(target));
            return;
            case 3:
            this.btnSortAll = ((System.Windows.Controls.RadioButton)(target));
            
            #line 86 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
            this.btnSortAll.Click += new System.Windows.RoutedEventHandler(this.btnSortAll_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.btnSortColumn = ((System.Windows.Controls.RadioButton)(target));
            
            #line 92 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
            this.btnSortColumn.Click += new System.Windows.RoutedEventHandler(this.btnSortColumn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btnSortTotal = ((System.Windows.Controls.RadioButton)(target));
            
            #line 98 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
            this.btnSortTotal.Click += new System.Windows.RoutedEventHandler(this.btnSortTotal_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.btnSortGrandTotal = ((System.Windows.Controls.RadioButton)(target));
            
            #line 104 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
            this.btnSortGrandTotal.Click += new System.Windows.RoutedEventHandler(this.btnSortGrandTotal_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.btnSortNone = ((System.Windows.Controls.RadioButton)(target));
            
            #line 110 "..\..\..\..\..\Views\Interactive Features\Sorting.xaml"
            this.btnSortNone.Click += new System.Windows.RoutedEventHandler(this.btnSortNone_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

