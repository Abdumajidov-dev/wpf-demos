#region Copyright Syncfusion Inc. 2001-2023.
// Copyright Syncfusion Inc. 2001-2023. All rights reserved.
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
using System.Xml.Linq;

namespace syncfusion.chartdemos.wpf
{
    public class RangeColumnChartModel
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public double Size { get; set; }
        public RangeColumnChartModel(string name, double value, double size)
        {
            Name = name;
            Value = value;
            Size = size;
        }
    }
}
