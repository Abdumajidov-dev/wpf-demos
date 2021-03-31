#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace syncfusion.chartdemos.wpf
{
    public class CategoryDataModel
    {
        public CategoryDataModel(string category, double value)
        {
            Category = category; Value = value;
        }

        public string Category
        {
            get;

            set;

        }

        public double Value
        {
            get;

            set;
        }
    }
}
