#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Shared;
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
using System.Windows.Shapes;

namespace syncfusion.organizationallayout.wpf
{
    /// <summary>
    /// Interaction logic for Organizationallayout.xaml
    /// </summary>
    public partial class Organizationallayout : ChromelessWindow
    {
        public Organizationallayout()
        {
            InitializeComponent();
            this.Template = this.Resources["ChromelessWindowTemplate"] as ControlTemplate;
            ChartViewModel cvm = new ChartViewModel();
            this.DataContext = cvm;

            orgFrame.Content = new OrganizationDiagram() { DataContext = cvm, ChartViewModel = cvm };
        }
    }
}
