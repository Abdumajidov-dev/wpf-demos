#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
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
using Syncfusion.UI.Xaml.Charts;
using Syncfusion.Windows.Shared;

using syncfusion.demoscommon.wpf;
using System.Diagnostics;

namespace syncfusion.chartdemos.wpf
{
    /// <summary>
    /// Interaction logic for ScaleBreakDemo.xaml
    /// </summary>
    public partial class ScaleBreakDemo : DemoControl
    {
        public ScaleBreakDemo()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            ScaleChart.Dispose();
            base.Dispose(disposing);
        }
        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo("https://www.worlddata.info/highest-mountains.php") { UseShellExecute = true });
        }
    }
}
