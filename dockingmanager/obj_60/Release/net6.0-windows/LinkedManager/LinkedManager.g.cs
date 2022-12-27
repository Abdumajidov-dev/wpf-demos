﻿#pragma checksum "..\..\..\..\LinkedManager\LinkedManager.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "A1696ED4AE18A5C5006189CD676627CE80E93335"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Syncfusion;
using Syncfusion.SfSkinManager;
using Syncfusion.Windows;
using Syncfusion.Windows.Collections;
using Syncfusion.Windows.ComponentModel;
using Syncfusion.Windows.Controls.Cells;
using Syncfusion.Windows.Controls.Input;
using Syncfusion.Windows.Controls.Notification;
using Syncfusion.Windows.Controls.Scroll;
using Syncfusion.Windows.Controls.VirtualTreeView;
using Syncfusion.Windows.Diagnostics;
using Syncfusion.Windows.Edit;
using Syncfusion.Windows.GridCommon;
using Syncfusion.Windows.PropertyGrid;
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


namespace syncfusion.dockingmanagerdemos.wpf {
    
    
    /// <summary>
    /// LinkedManager
    /// </summary>
    public partial class LinkedManager : Syncfusion.Windows.Shared.ChromelessWindow, System.Windows.Markup.IComponentConnector {
        
        
        #line 32 "..\..\..\..\LinkedManager\LinkedManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button newWindow;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\..\LinkedManager\LinkedManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox enableTargerManager;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\..\LinkedManager\LinkedManager.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Syncfusion.Windows.Tools.Controls.DockingManager clientdockingManager;
        
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
            System.Uri resourceLocater = new System.Uri("/syncfusion.dockingmanagerdemos.wpf;component/linkedmanager/linkedmanager.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\LinkedManager\LinkedManager.xaml"
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
            this.newWindow = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\LinkedManager\LinkedManager.xaml"
            this.newWindow.Click += new System.Windows.RoutedEventHandler(this.NewDockingWindow_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.enableTargerManager = ((System.Windows.Controls.CheckBox)(target));
            
            #line 41 "..\..\..\..\LinkedManager\LinkedManager.xaml"
            this.enableTargerManager.Checked += new System.Windows.RoutedEventHandler(this.AddToTargetManagerList_Click);
            
            #line default
            #line hidden
            
            #line 42 "..\..\..\..\LinkedManager\LinkedManager.xaml"
            this.enableTargerManager.Unchecked += new System.Windows.RoutedEventHandler(this.RemoveFromTargetManagerList_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.clientdockingManager = ((Syncfusion.Windows.Tools.Controls.DockingManager)(target));
            
            #line 60 "..\..\..\..\LinkedManager\LinkedManager.xaml"
            this.clientdockingManager.TransferredFromManager += new Syncfusion.Windows.Tools.Controls.TransferManagerEventHandler(this.clientdockingManager_TransferredFromManager);
            
            #line default
            #line hidden
            
            #line 61 "..\..\..\..\LinkedManager\LinkedManager.xaml"
            this.clientdockingManager.TransferredToManager += new Syncfusion.Windows.Tools.Controls.TransferManagerEventHandler(this.clientdockingManager_TransferredToManager);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

