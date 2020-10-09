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
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Syncfusion.SfSkinManager;
using Syncfusion.Windows.Shared;

namespace SfRadialSlider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SfSkinManager.SetVisualStyle(this, VisualStyles.MaterialLight);
        }

        private void Label_Customization_DrawLabel(object sender, Syncfusion.Windows.Controls.Navigation.DrawLabelEventArgs e)
        {
            e.Handled = true;
            if (e.Handled == true)
            {
                e.Text += "°C";

                e.Foreground = Brushes.Red;

                e.FontSize = 10;

                if (e.Value == 10 || e.Value == 20 || e.Value == 30)
                {
                    e.Foreground = Brushes.Green;
                }
                else if (e.Value == 40 || e.Value == 50 || e.Value == 60)
                {
                    e.Foreground = Brushes.Blue;
                }
                else if (e.Value == 70 || e.Value == 80 || e.Value == 90)
                {
                    e.Foreground = Brushes.Red;
                }

            }
        }

    }
}
