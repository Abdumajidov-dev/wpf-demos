#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
namespace syncfusion.weatheranalysis.wpf
{
    public static class WindowHelper
    {
        private static WeatherAnalysisDemo mainWindow;

        public static WeatherAnalysisDemo MainWindow
        {
            get { return mainWindow; }
            set { mainWindow = value; }
        }
    }
}
