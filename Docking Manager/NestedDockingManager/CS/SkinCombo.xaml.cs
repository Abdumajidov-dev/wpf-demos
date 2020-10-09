#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Shared;
using Syncfusion.Windows.Tools.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace NestedDockingManagerDemo
{
    /// <summary>
    /// Interaction logic for SkinCombo.xaml
    /// </summary>
    public partial class SkinCombo : UserControl 
    {

        public event PropertyChangedCallback SelectedIndexChanged = delegate { };
        public int SelectedIndex
        {
            get { return (int)GetValue(SelectedIndexProperty); }
            set
            {
                SetValue(SelectedIndexProperty, value);
              
            }
        }

        // Using a DependencyProperty as the backing store for SelectedIndex.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedIndexProperty =
            DependencyProperty.Register("SelectedIndex", typeof(int), typeof(SkinCombo), new PropertyMetadata(0,new PropertyChangedCallback(OnSelctedIndexChanged)));


        private static void OnSelctedIndexChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (d as SkinCombo).OnSelectedIndexChanged(e);
            
        }

        private void OnSelectedIndexChanged(DependencyPropertyChangedEventArgs e)
        {
            if(this.SelectedIndex != combo.SelectedIndex)
            {
                combo.SelectedIndex = this.SelectedIndex;
            }
            if (this.SelectedIndexChanged != null)
            {
                this.SelectedIndexChanged(this, e);
            }
        }

        public SkinCombo()
        {
            InitializeComponent();
        }
        private void ComboBoxAdv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Window window = Application.Current.MainWindow;
            SkinStorage.SetVisualStyle(window, (combo.SelectedItem as ComboBoxItemAdv).Content.ToString());
        }
    }
}
