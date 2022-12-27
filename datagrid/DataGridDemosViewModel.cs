#region Copyright Syncfusion Inc. 2001-2022.
// Copyright Syncfusion Inc. 2001-2022. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syncfusion.datagriddemos.wpf
{
    public class DataGridDemosViewModel : DemoBrowserViewModel
    {
        public override List<ProductDemo> GetDemosDetails()
        {
            var productdemos = new List<ProductDemo>();
            productdemos.Add(new DataGridProductDemos());
            return productdemos;
        }
    }

    public class DataGridProductDemos : ProductDemo
    {
        public DataGridProductDemos()
        {
            this.Product = "DataGrid";
            this.ProductCategory = "GRIDS";
            this.Demos = new List<DemoInfo>(); 
           
            this.Demos.Add(new DemoInfo() { SampleName = "Getting Started", GroupName = "GETTING STARTED", Description = "This sample showcases the basic features in SfDataGrid by simple ObservableCollection binding.", DemoViewType = typeof(GettingStarted) });
            this.Demos.Add(new DemoInfo() { SampleName = "Data Binding", GroupName = "DATA BINDING", Description = "This sample showcases the data binding capabilities in SfDataGrid with data sources such as DataTable and Custom Collection such as List, BindingList and ObservableCollection.", DemoViewType = typeof(DataBindingDemo), ThemeMode= ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "Complex and Indexer Properties", GroupName = "DATA BINDING", Description = "This sample showcases the complex and indexer properties binding capabilities in SfDataGrid. SfDataGrid supports to bind complex and indexer properties to its columns at any level.", DemoViewType = typeof(ComplexPropertyBindingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Sorting", GroupName = "DATA PRESENTATION", Description = "This sample showcases the sorting capabilities of data in SfDataGrid. The SfDataGrid control allows you to sort the data against one or more columns and provides some sorting functionalities like Tristate Sorting, Showing Sort Orders or Sort Numbers.", DemoViewType = typeof(SortingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Grouping", GroupName = "DATA PRESENTATION", Description = "This sample showcases the grouping capabilities of data in SfDataGrid. The SfDataGrid enables you to grouping the data by one or more columns.", DemoViewType = typeof(GroupingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Summaries", GroupName = "DATA PRESENTATION", Description = "This sample showcases the summary calculation capabilities of data in SfDataGrid. SfDataGrid provides three kinds of summary row collections, namely GroupSummaryRows, TableSummaryRows, and CaptionSummaryRows.", DemoViewType = typeof(SummariesDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Interval Grouping", GroupName = "DATA PRESENTATION", Description = "This sample showcases the interval grouping capabilities of data in SfDataGrid. The SfDataGrid Supports the interval grouping by enable the interval grouping logic.", DemoViewType = typeof(IntervalGroupingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Custom Grouping", GroupName = "DATA PRESENTATION", Description = "This sample showcases the custom grouping capabilities in SfDataGrid. The SfDataGrid supports custom grouping which enables you to implement custom grouping logic, if the standard grouping techniques does not meet your requirements.", DemoViewType = typeof(CustomGroupingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Sort by Summary", GroupName = "DATA PRESENTATION", Description = "This sample showcases the sort by summary capabilities of data in SfDataGrid.", DemoViewType = typeof(SortBySummaryDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Filtering", GroupName = "FILTERING", Description = "This sample showcases the filtering capabilities of data in SfDataGrid.", DemoViewType = typeof(FilteringDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Advanced Filtering", GroupName = "FILTERING", Description = "This sample showcases the Excel inspired filtering capabilities of data in SfDataGrid.", DemoViewType = typeof(ExcelLikeFilteringDemo), ThemeMode= ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "Filter Row", GroupName = "FILTERING", Description = "This sample showcases the filter row functionalities of SfDataGrid.", DemoViewType = typeof(FilterRowDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Filter Status Bar", GroupName = "FILTERING", Description = "This sample showcases the Filter Status Bar at the bottom of SfDataGrid which displays the filter conditions in simple context.", DemoViewType = typeof(FilterStatusBarDemo),ThemeMode = ThemeMode.None });

            this.Demos.Add(new DemoInfo() { SampleName = "Custom Filter Row", GroupName = "FILTERING", Description = "This sample showcases the customization of filter row editors and drop-down options in SfDataGrid.", DemoViewType = typeof(CustomFilterRowDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Search", GroupName = "FILTERING", Description = "This sample showcases the search support of SfDataGrid. This allows you to search the DataGrid with options to filter and highlight the search text in cells.", DemoViewType = typeof(SearchPanelDemo), ThemeMode = ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "Master Details View", GroupName = "MASTER DETAIL", Description = "This sample showcases the MasterDetailsView capability of SfDataGrid. The SfDataGrid displays hierarchical data in the form of nested tables using master-detail view configuration. In a hierarchical view, all tables in the data source are interconnected by means of relations.", DemoViewType = typeof(MasterDetailsViewDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Details View Template", GroupName = "MASTER DETAIL", Description = "This sample showcases the SfDataGrid with a DetailsView Template. It displays major values in each row and detailed information in the details section when the row is expanded. It can be used to load specific details for each row using RowTemplate property of TemplateViewDefinition. ", DemoViewType = typeof(DetailsViewTemplateDemo), ThemeMode = ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "DataTable Binding", GroupName = "MASTER DETAIL", Description = "This sample showcases the datatable binding capability of DetailsViewDataGrid. The DetailsViewDataGrid supports data sources such as DataTable and custom collection such as List, BindingList, ObservableCollection.", DemoViewType = typeof(DetailsViewDataTableBindingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Stacked Headers", GroupName = "MASTER DETAIL", Description = "This sample showcases the stacked headers capability in DetailsViewDataGrid of SfDataGrid.", DemoViewType = typeof(DetailsViewStackedHeaderRowsDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Column Types", GroupName = "MASTER DETAIL", Description = "This sample showcases the different column types capabilities in DetailsViewDataGrid. The SfDataGrid allows you to create various types of columns like Editable, Non-Editable and DropDown columns in DetailsViewDataGrid also.", DemoViewType = typeof(DetailsViewColumnTypesDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Conditional Formatting", GroupName = "MASTER DETAIL", Description = "This sample showcases the conditional formatting capabilities of DetailsViewDataGrid. SfDataGrid control allows you to format the styles of cells and rows based on certain conditions by using converter and StyleSelector in DetailsViewDataGrid.", DemoViewType = typeof(ConditionalFormattingDetailsViewDataGridDemo), ThemeMode= ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "Excel Exporting", GroupName = "MASTER DETAIL", Description = "This sample showcases the excel exporting capability of MasterDetailsView in SfDataGrid.", DemoViewType = typeof(MasterDetailsExportingDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Data Virtualization", GroupName = "DATA VIRTUALIZATION", Description = "This sample showcases the data virtualization capability of SfDataGrid. Data Virtualization support enables you to work with the huge data sources. SfDataGrid control creates records on-demand by automatically enabling data virtualization when EnableDataVirtualization property set to true.", DemoViewType = typeof(DataVirtualizationDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Data Paging", GroupName = "DATA VIRTUALIZATION", Description = "This sample showcases the paging capability of SfDataGrid. Paging support is achieved by using SfDataPager control which return pages of data with entries where selection of the pages can be done using the numbered buttons. Paging loads the entire data collection to the SfDataPager and bind the PagedSource property of the SfDataPager to the ItemsSource property of SfDataGrid.", DemoViewType = typeof(DataPagingDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "On-Demand Paging", GroupName = "DATA VIRTUALIZATION", Description = "This sample showcases the on-demand paging capabilities of SfDataGrid. On-demand paging supports current page item source adds by on demand basis. The entire data is not needed to be fetched from the data source and we can get high performance even if there are millions of records. Also we can load millions of records in an efficient way.", DemoViewType = typeof(OnDemandPagingDemo) });
            //this.Demos.Add(new DemoInfo() { SampleName = "Incremental Loading", GroupName = "DATA VIRTUALIZATION", Description = "This sample showcases the incremental loading capabilities of SfDataGrid. Incremental loading allows you to load a set of data from whole data source to SfDataGrid and it provides support with fast and fluid scrolling and loading the huge set of data. You can enable incremental loading in SfDataGrid by creating a data source with IncrementalList class which implements the ISupportIncrementalLoading interface internally. In this, Sorting, Filtering, Grouping and Summaries will be applied only for loaded data.", DemoViewType = typeof(IncrementalLoadingDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Editing", GroupName = "EDITING", Description = "This sample showcases the editing capability in SfDataGrid. SfDataGrid provided options to trigger the edit mode by either with single or double click.", DemoViewType = typeof(EditingAndDataValidationDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Editable Columns", GroupName = "EDITING", Description = "This sample showcases the editable columns capability of SfDataGrid. SfDataGrid provides different editable columns such as GridTextColumn, GridNumericColumn, GridCurrencyColumn, GridPercentColumn, GridMaskColumn, GridTimeSpanColumn, GridTemplateColumn and GridUnboundColumn.", DemoViewType = typeof(GridColumnsDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Dropdown and Read Only Columns", GroupName = "EDITING", Description = "This sample showcases the dropdown and readonly columns capability of SfDataGrid. The SfDataGrid supports various types of dropdown and readonly columns like DateTimeColumn, ComboboxColumn, MultiColumnDropDownList, TemplateColumn, ImageColumn and HyperLinkColumn.", DemoViewType = typeof(GridDropDownAndReadOnlyColumnsDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "ComboBox Column", GroupName = "EDITING", Description = "This sample showcases the loading of different ItemsSource for different rows in GridComboBoxColumn based on data object.", DemoViewType = typeof(ComboBoxColumnsDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Add New Row", GroupName = "ROWS", Description = "This sample showcases adding the new record at runtime in SfDataGrid by AddNewRow feature. The AddNewRow is displayed, above or below the rows in the SfDataGrid based on AddNewRowPosition property.", DemoViewType = typeof(AddNewRowDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Stacked headers", GroupName = "ROWS", Description = "This sample showcases the stacked headers capability in DetailsViewDataGrid of SfDataGrid.", DemoViewType = typeof(StackedHeaderRowsDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Auto RowHeight", GroupName = "ROWS", Description = "This sample showcases the auto row height feature of SfDataGrid which improves the readability of the content and occurs on-demand basis. It does not affect the loading performance of the SfDataGrid and provides support to change the height of the row based on its content on-demand based for all columns or certain columns of SfDataGrid.", DemoViewType = typeof(AutoRowHeightDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Unbound Row", GroupName = "ROWS", Description = "This sample showcases unbound rows support of SfDataGrid. The SfDataGrid provides support to place the Unbound Row at the top and the bottom of record rows and also have the option to place them above or below the Table summary row.", DemoViewType = typeof(UnBoundRowDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Unbound column", GroupName = "COLUMNS", Description = "This sample showcases the unbound column capability of SfDataGrid. SfDataGrid supports the addition of extra columns to the data source columns. These additional columns are called as unbound columns, as they do not belong to the data source. Unbound column has two features like Expression and Format and these unbound fields are used when you want to add additional or custom information to each record. An unbound column is sorted, grouped, and filtered like other GridColumns.", DemoViewType = typeof(UnBoundColumnsDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Column Sizer", GroupName = "COLUMNS", Description = "This sample showcases the different types of column sizer capabilities in SfDataGrid. The SfDataGrid provides in-built feature for customizing the width of the column based on the data present in the cell by defining the ColumnSizer property. This property has different ColumnSizer options like Auto, AutoWithLastColumnFill, SizeToCells, SizeToHeader, Star and None.", DemoViewType = typeof(ColumnSizerDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Cell Merge", GroupName = "COLUMNS", Description = "This sample showcases the merged cells based on data in SfDataGrid by QueryCoveredRange event.", DemoViewType = typeof(CellMergeDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Auto Cell Merge", GroupName = "COLUMNS", Description = "This sample showcases the Merged cell feature of SfDataGrid.", DemoViewType = typeof(AutoCellMergeDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Data Validation", GroupName = "DATA VALIDATION", Description = "This sample showcases the data validation capability in SfDataGrid by implementing IDataErrorInfo interface.", DemoViewType = typeof(DataValidationDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Custom Validation", GroupName = "DATA VALIDATION", Description = "This sample showcases the custom validation capability based on certain conditions in SfDataGrid.", DemoViewType = typeof(CustomValidationDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Row Selection", GroupName = "SELECTIONS", Description = "This sample showcases the cell selection capability of SfDataGrid. SfDataGrid control provides an interactive support for selecting cells in different mode with smooth and ease manner by SelectionUnit as Cell or Any and NavigationMode should be Cell. SfDataGrid allows you to select more than one cell at a time by using SelectionMode property of SfDataGrid. This property provides options like Single, Multiple, Extended and None.", DemoViewType = typeof(SelectionDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Cell Selection", GroupName = "SELECTIONS", Description = "This sample showcases the cell selection capability of SfDataGrid. SfDataGrid control provides an interactive support for selecting cells in different mode with smooth and ease manner by SelectionUnit as Cell or Any and NavigationMode should be Cell. SfDataGrid allows you to select more than one cell at a time by using SelectionMode property of SfDataGrid. This property provides options like Single, Multiple, Extended and None.", DemoViewType = typeof(CellSelectionDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "CheckBox Selector Column", GroupName = "SELECTIONS", Description = "This sample showcases the DataGrid with a grid check-box-selector column. It displays check boxes for all the rows to allow users to select or deselect them by clicking on them.", DemoViewType = typeof(CheckBoxSelectorColumnDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Real time updates", GroupName = "PERFORMANCE", Description = "This sample showcases real time updates capability of SfDataGrid. SfDataGrid has a high performance standard, where you can make the grid to work with large amounts of data with few property settings, without a performance hit. It provides complete support for Virtual Mode, where the data will be loaded only on demand and thus saves the memory consumption and provides quick response. It also handles very high frequency updates and refresh scenarios.", DemoViewType = typeof(PerformanceDemo) });
            this.Demos.Add(new DemoInfo() { SampleName="Scroll Performance", GroupName= "PERFORMANCE", Description= "This sample illustrates the loading and scrolling performance of SfDataGrid.", DemoViewType=typeof(ScrollPerformanceDemo)});
            this.Demos.Add(new DemoInfo() { SampleName = "Trader Grid", GroupName = "PERFORMANCE", Description = "This sample illustrates the frequent updates that occur in random cells across the Grid, while keeping the CPU usage to a minimum in the SfDataGrid.", DemoViewType = typeof(TradingGridDemo) });

            this.Demos.Add(new DemoInfo() { SampleName = "Alternate Row Style", GroupName = "APPEARANCE", Description = "This sample showcases the alternate row style capability of SfDataGrid. By default, the style is applied for every alternative second row and change it by using AlternationCount property.", DemoViewType = typeof(AlternateRowStyleDemo), ThemeMode = ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "Styling", GroupName = "APPEARANCE", Description = "This sample showcases the styling capability of SfDataGrid.", DemoViewType = typeof(StylingDemo), ThemeMode = ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "Freeze Panes", GroupName = "APPEARANCE", Description = "This sample showcases the freeze panes capability of SfDataGrid. The SfDataGrid provides support to freeze rows and columns at the top and also at the bottom similar to Excel Freeze Panes with the help of FrozenRowCount, FooterRowsCount, FrozenColumnCount and FooterColumnCount.", DemoViewType = typeof(FreezePanesDemo) });
            this.Demos.Add(new DemoInfo() { SampleName = "Conditional Cell Style", GroupName = "APPEARANCE", Description = "This sample showcases the conditional formatting capability of SfDataGrid. The SfDataGrid control allows you to format the styles of cells and rows based on certain conditions by using Converter and StyleSelector.", DemoViewType = typeof(ConditionalFormattingDemo), ThemeMode= ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "Cell Animation", GroupName = "APPEARANCE", Description = "This sample showcases the cell animation capability to animate the cells in SfDataGrid. SfDataGrid provides support to animate the cell when the underlying property gets changed by using the behaviors with the help of ColorAnimation.", DemoViewType = typeof(CellAnimationDemo), ThemeMode = ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "Conditional Row Style", GroupName = "APPEARANCE", Description = "This sample showcases the row style customization in SfDataGrid by StyleSelector.", DemoViewType = typeof(RowStyleDemo), ThemeMode= ThemeMode.None });

            this.Demos.Add(new DemoInfo() { SampleName = "Context Menu", GroupName = "INTERACTIVE FEATURES", Description = "This sample showcases the context menu capabilities of SfDataGrid. ContextMenu in SfDataGrid is entirely customizable menu for the extensible functionalities of the Grid. ContextMenu is enabled for various parts of the Grid with the appropriate APIs. SfDataGrid has a set of APIs that allows access to the context menu in various parts of the Grid.", DemoViewType = typeof(ContextMenuDemo), ThemeMode= ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "Column Chooser", GroupName = "INTERACTIVE FEATURES", Description = "This sample showcases the column chooser capability of SfDatagrid. Column Chooser allows you to add or remove columns dynamically from the current Grid view using drag-and-drop operations.", DemoViewType = typeof(ColumnChooserDemo), DemoLauchMode = DemoLauchMode.Window, ThemeMode= ThemeMode.None });
            this.Demos.Add(new DemoInfo() { SampleName = "Clipboard Operation", GroupName = "INTERACTIVE FEATURES", Description = "This sample showcases the clipboard operation capabilities of SfDataGrid. The SfDataGrid, provides an interactive support to perform cut, copy and paste operations by using GridCopyOption and GridPasteOption properties. The GridCopyOption provides options like None, CopyData, CutData, IncludeHeaders, and IncludeFormat and the GridPasteOption provides options like None, PasteData, IncludeFirstLine.", DemoViewType = typeof(CutCopyPasteDemo)});
            this.Demos.Add(new DemoInfo() { SampleName = "Drag and Drop", GroupName = "INTERACTIVE FEATURES", Description = "This sample showcases the built-in row drag and drop capability of SfDataGrid.", DemoViewType = typeof(DragAndDropDemo)});

            this.Demos.Add(new DemoInfo() { SampleName = "Serialization", GroupName = "SERIALIZATION", Description = "This sample showcases the serialization and deserialization capability of SfDataGrid. By customizing SerializationController, you can serialize and deserialize derived DataGrid and custom column also.", DemoViewType = typeof(SerializationDemo), ThemeMode = ThemeMode.None });

            this.Demos.Add(new DemoInfo() { SampleName = "Excel Exporting", GroupName = "EXPORT & PRINT", Description = "This sample showcases the excel exporting capability of SfDataGrid. The SfGridConverter assembly helps to provide support for exporting data from a SfDataGrid to an Excel spreadsheet. Our XlsIO libraries are used to support the conversion of the SfDataGrid contents to Excel. It also supports to export the selected ranges of SfDataGrid content to Excel.", DemoViewType = typeof(ExportingDemo)});
            this.Demos.Add(new DemoInfo() { SampleName = "PDF Exporting", GroupName = "EXPORT & PRINT", Description = "This sample showcases the PDF exporting capability of SfDataGrid. The SfGridConverter assembly helps to provide support for exporting data from a SfDataGrid to a PDF file. Our Pdf.Base libraries are used to support the conversion of the SfDataGrid contents to PDF. The exporting to PDF provides the options like Auto Column Width, Auto Row Height, Export Groups, Export Group Summaries, Export Table Summaries, Repeat Headers, Fit All Columns in one page and export all to pdf, export selected items to PDF.", DemoViewType = typeof(PdfExportingDemo)});

            this.Demos.Add(new DemoInfo() { SampleName = "Printing", GroupName = "EXPORT & PRINT", Description = "This sample showcases the printing capabilities of SfDataGrid. The SfDataGrid control allows you to print the data displayed in the DataGrid. The GridPrintManager of SfDataGrid is designed to support different orientations, sizes, margins, etc. you can change print settings using the print settings property of SfDataGrid.", DemoViewType = typeof(PrintingDemo)});
            this.Demos.Add(new DemoInfo() { SampleName = "Printing Customization", GroupName = "EXPORT & PRINT", Description = "This sample showcases the custom printing capabilities of SfDataGrid. SfDataGrid provide options to customize the content while printing by CustomPrintManager. This sample demonstrates the CustomPrintManager support to meet the required level of customization.", DemoViewType = typeof(CustomPrintingDemo)});

            this.Demos.Add(new DemoInfo() { SampleName = "Localization", GroupName = "LOCALIZATION", Description = "This sample showcases the localization capability of SfDataGrid. Localization is the process of making your application multi-lingual, by formatting content according to cultures.", DemoViewType = typeof(DataGridLocalizationDemo) });

        }
    }
}
