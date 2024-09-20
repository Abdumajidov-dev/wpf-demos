#region Copyright Syncfusion Inc. 2001 - 2024
// Copyright Syncfusion Inc. 2001 - 2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace syncfusion.olapgriddemos.wpf
{
    using syncfusion.demoscommon.wpf;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for MDX_Query.xaml
    /// </summary>
    public partial class MDXQuery : DemoControl
    {
        public MDXQuery()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            // Release all resources
            (this.DataContext as MDXQueryViewModel).Dispose();
            this.DataContext = null;
            if (this.olapgrid1 != null)
            {
                this.olapgrid1.Dispose();
                this.olapgrid1 = null;
            }
            base.Dispose(disposing);
        }
    }
}
