#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace syncfusion.diagrambuilder.wpf
{
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;
    using System.Windows.Input;
    using syncfusion.diagrambuilder.wpf.ViewModel;
    using Syncfusion.SfSkinManager;
    using Syncfusion.UI.Xaml.Diagram;
    using Syncfusion.UI.Xaml.DiagramRibbon;
    using Syncfusion.Windows.Shared;
    using Syncfusion.Windows.Tools.Controls;
    using System.Linq;
    using Syncfusion.UI.Xaml.Diagram.Theming;

    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class DiagramBuilderDemo : RibbonWindow
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MainWindow" /> class.
        /// </summary>
        public DiagramBuilderDemo()
        {
            this.InitializeComponent();
            this.Closing += DiagramBuilderDemo_Closing;
            this.Loaded += this.MainWindowLoaded;
            Diagram.DataContextChanged += Diagram_DataContextChanged;            
        }

        private void DiagramBuilderDemo_Closing(object sender, CancelEventArgs e)
        {
            if(Diagram.DataContext is FlowChart.FlowDiagramVM)
            {
                (Diagram.DataContext as FlowChart.FlowDiagramVM).PanelVisibility = false;
            }
        }

        private void Diagram_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if(e.NewValue is LogicCircuit.LogicCircuitDiagramVM || e.NewValue is Network.NetworkDiagramVM)
            {
                Ribbon InnerRibbon = DiagramRibbon.Template.FindName("Part_Ribbon", this.DiagramRibbon) as Ribbon;
                ((InnerRibbon.Items[0] as RibbonTab).Items[4] as RibbonBar).Visibility = Visibility.Collapsed;
                ((InnerRibbon.Items[2] as RibbonTab).Items[1] as RibbonBar).Visibility = Visibility.Collapsed;
                ((InnerRibbon.Items[2] as RibbonTab).Items[2] as RibbonBar).Visibility = Visibility.Collapsed;
            }
            else
            {
                Ribbon InnerRibbon = DiagramRibbon.Template.FindName("Part_Ribbon", this.DiagramRibbon) as Ribbon;
                ((InnerRibbon.Items[0] as RibbonTab).Items[4] as RibbonBar).Visibility = Visibility.Visible;
                ((InnerRibbon.Items[2] as RibbonTab).Items[1] as RibbonBar).Visibility = Visibility.Visible;
                ((InnerRibbon.Items[2] as RibbonTab).Items[2] as RibbonBar).Visibility = Visibility.Visible;
            }
        }

        /// <summary>
        /// The main window_ loaded.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="e">
        /// The e.
        /// </param>
        private void MainWindowLoaded(object sender, RoutedEventArgs e)
        {
            (this.DataContext as DiagramBuilderVM).DiagramRibbon = DiagramRibbon.Template.FindName("Part_Ribbon", this.DiagramRibbon) as Ribbon;
            object NewButton = (this.DataContext as DiagramBuilderVM).DiagramRibbon.BackStage.Items.GetItemAt(0);
            (this.DataContext as DiagramBuilderVM).DiagramRibbon.BackStage.Items.Remove(NewButton);
            BackstageTabItem NewBackStageTabItem = MainGrid.Resources["NewBackStageTabItem"] as BackstageTabItem;
            (this.DataContext as DiagramBuilderVM).DiagramRibbon.BackStage.Items.Insert(0, NewBackStageTabItem);
            (this.DataContext as DiagramBuilderVM).StencilView = StencilGrid;
            (this.DataContext as DiagramBuilderVM).DiagramView = Diagram;
            (this.DataContext as DiagramBuilderVM).DiagramRibbon.ShowBackStage();
        }        
    }
}