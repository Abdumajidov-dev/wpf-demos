#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace GettingStarted
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
#if Framework4_0
            StartupUri = new Uri("SignUpPage.xaml", UriKind.Relative);
#else
             StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
#endif
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Syncfusion.Licensing.DemoCommon.FindLicenseKey());
        }
    }
}
