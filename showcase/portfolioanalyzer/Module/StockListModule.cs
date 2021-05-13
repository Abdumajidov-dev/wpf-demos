#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Composite.Events;

namespace syncfusion.portfolioanalyzerdemo.wpf
{
    /// <summary>
    /// Represents the StockListModule class. This module is responsible for adding the StockListView to the Docking region. 
    /// </summary>
    public class StockListModule : IModule
    {
        #region IModule Members
        private readonly IRegionManager regionManager;
        private readonly IModuleManager moduleManager;
        private readonly IEventAggregator eventagg;
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="StockListModule"/> class.
        /// </summary>
        /// <param name="regionManager">The region manager.</param>
        /// <param name="moduleManager">The module manager.</param>
        /// <param name="eventagg">The eventagg.</param>
        public StockListModule(IRegionManager regionManager, IModuleManager moduleManager, IEventAggregator eventagg)
        {
            this.regionManager = regionManager;
            this.moduleManager = moduleManager;
            this.eventagg = eventagg;
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        public void Initialize()
        {
            StockListViewModel stockmodel = new StockListViewModel(eventagg);
            this.regionManager.Regions[RegionNames.DockingRegion].Add(new StockListView(stockmodel), "stocklistView");
        }
    }
}