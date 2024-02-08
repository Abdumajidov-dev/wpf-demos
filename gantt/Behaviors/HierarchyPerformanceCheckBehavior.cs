#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Xaml.Behaviors;
using Syncfusion.Windows.Controls.Gantt;
using Syncfusion.Windows.Controls.Grid;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion.ganttdemos.wpf
{
   
    public class HierarchyPerformanceCheckBehavior : Behavior<HierarchyPerformanceCheck>
    {
        /// <summary>
        /// Called when [attached].
        /// </summary>
        protected override void OnAttached()
        {
            AssociatedObject.Loaded += new System.Windows.RoutedEventHandler(AssociatedObject_Loaded);
        }

        /// <summary>
        /// Handles the Loaded event of the AssociatedObject control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        void AssociatedObject_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            ObservableCollection<TaskDetails> DataCollection;
            AssociatedObject.gantt.LayoutMode = GanttLayoutMode.Default;
            AssociatedObject.gantt.GanttGrid.AutosizingNodeColumnOption = GridNodeAutosizingOption.BasedOnLevel;

            var view = AssociatedObject.DataContext as HierarchyPerformanceCheckViewModel;
            DateTime t = DateTime.Now;

            DataCollection = view.GetData(view.NoOfItems);
            view.TimeTaken = Math.Round((DateTime.Now - t).TotalSeconds, 4).ToString() + "  Sec";

            view.TaskCollection = DataCollection;
            view.LoadedTime = Math.Round((DateTime.Now - t).TotalSeconds, 4).ToString() + "  Sec";
        }

        /// <summary>
        /// Called when [detaching].
        /// </summary>
        protected override void OnDetaching()
        {
            AssociatedObject.Loaded -= new System.Windows.RoutedEventHandler(AssociatedObject_Loaded);
        }
    }
}
