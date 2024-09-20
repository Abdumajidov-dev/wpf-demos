#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Xml.Linq;
using syncfusion.demoscommon.wpf;
using Syncfusion.UI.Xaml.Charts;

namespace syncfusion.chartdemos.wpf
{
    public class DoughnutChartViewModel : NotificationObject
    {
        private double startAngle;
        private double endAngle;
        private int selectedIndex;
        private int value1;
        private string name = "";
        private string pathData = "";

        public IList<DoughnutChartModel> DoughnutSeriesData { get; set; }
        public IList<DoughnutChartModel> SemiDoughnutData { get; set; }
        public IList<DoughnutChartModel> StackedDoughnutData { get; set; }
        public IList<DoughnutChartModel> CustomizedDoughnutData { get; set; }

        public double StartAngle
        {
            get
            {
                return startAngle;
            }

            set
            {
                startAngle = value;
                RaisePropertyChanged(nameof(this.StartAngle));
            }
        }

        public double EndAngle
        {
            get
            {
                return endAngle;
            }

            set
            {
                endAngle = value;
                RaisePropertyChanged(nameof(this.EndAngle));
            }
        }

        public int SelectedIndex
        {
            get { return selectedIndex; }
            set
            {
                if (selectedIndex != value)
                {
                    selectedIndex = value;
                    UpdateIndex(value);
                    RaisePropertyChanged(nameof(this.SelectedIndex));
                }
            }
        }

        public string PathData
        {
            get { return pathData; }
            set
            {
                pathData = value;
                RaisePropertyChanged(nameof(this.pathData));
            }
        }

        private void UpdateIndex(int value)
        {
            if (value >= 0 && value < DoughnutSeriesData.Count)
            {
                var model = DoughnutSeriesData[value];
                if (model != null && model.Name != null)
                {
                    PathData= model.PathData;
                }
            }
        }

        public Array CapStyles
        {
            get
            {
                return Enum.GetValues(typeof(DoughnutCapStyle));
            }
        }

        public List<string> Track { get; set; }

        public DoughnutChartViewModel()
        {
            StartAngle = 180;
            EndAngle = 360;

            this.DoughnutSeriesData = new List<DoughnutChartModel>()
            {
            new DoughnutChartModel( "Food",  15,  "M2,20.016956C2.0169987,25.523976,6.5019841,29.998954,12.013001,29.998954L14.947998,29.998954C20.458985,29.998954,24.944001,25.523976,24.960999,20.016956z M9.2816433,11.277565L6.5858178,11.814028 6.5913763,11.827922C6.6284499,11.915079,6.6692576,12.000516,6.7137527,12.084016L7.5446567,13.648015C8.1277775,14.818265,8.7718911,16.113332,7.4061961,17.950516L7.3549294,18.016955 9.8750548,18.016955 10.928175,16.657988C11.256187,16.161988,11.252187,15.736988,10.871173,14.964988L9.8361353,13.021986C9.5593752,12.502236,9.3775401,11.946732,9.2940125,11.375229z M13.759736,10.386434L11.25262,10.885345 11.258424,10.968728C11.300251,11.356032,11.415568,11.732986,11.6012,12.082986L12.650238,14.052987C13.099255,14.961988,13.561272,16.310988,12.551235,17.824989L12.402679,18.016955 14.811498,18.016955 15.370404,17.016996C15.885464,16.023998,15.742447,15.635998,15.209385,14.562001L14.38829,13.022004C13.995744,12.279506,13.786422,11.478414,13.761547,10.627517z M30.549996,1.9073486E-06C30.97736,0.0010147095 31.3699,0.27421188 31.502337,0.70320129 31.667336,1.2301903 31.371336,1.7911777 30.843337,1.9541721L3.8967628,10.311369 30.789517,4.958642C30.857766,4.9446411 30.925656,4.937953 30.992419,4.9380255 31.459759,4.9385309 31.871878,5.2702818 31.965502,5.74368 32.073502,6.2857065 31.722506,6.8127317 31.180512,6.9197369L15.78748,9.9829168 15.784574,10.006654C15.705825,10.772024,15.829645,11.468945,16.155495,12.084006L16.987593,13.648003C17.675673,15.032,18.080719,16.136997,17.130608,17.964994L17.101603,18.016955 26.960999,18.016955 26.960999,19.985949C26.960999,26.609975,21.571991,31.998954,14.947998,31.998954L12.013001,31.998954C5.389008,31.998954,4.2701868E-07,26.609975,0,19.985949L0,18.016955 4.6592588,18.016955 5.7488641,16.829014C6.453783,15.945015,6.3087997,15.652015,5.7668623,14.563015L4.9469571,13.022016C4.840094,12.820641,4.7467298,12.613219,4.6669697,12.400488L4.5998878,12.209224 2.5808243,12.611013C2.5148253,12.625013 2.448826,12.631014 2.3848264,12.631014 1.9168318,12.631014 1.4998364,12.301998 1.4058369,11.825975 1.3309006,11.453332 1.4738562,11.088252 1.7466427,10.861696L1.756172,10.854537 1.7029963,10.843845C1.3723782,10.763733 1.0913543,10.517348 0.9832914,10.167982 0.81929136,9.6409941 1.1152918,9.0800066 1.6422922,8.9170113L30.251336,0.044218063C30.350897,0.014030457,30.451374,-0.00023078918,30.549996,1.9073486E-06z" ),
            new DoughnutChartModel( "Medical", 28, "M28.227046,5.6769892C26.750043,5.6769892 25.54904,6.8779889 25.54904,8.3539888 25.54904,9.6916124 26.535411,10.803383 27.819678,11.000083L27.896592,11.009881 27.929398,10.997892C28.023385,10.96871 28.123345,10.952995 28.227032,10.952995 28.330533,10.952995 28.430375,10.96871 28.524295,10.997892L28.557137,11.0099 28.634158,11.000083C29.917681,10.803383 30.904051,9.6916124 30.904051,8.3539888 30.904051,6.8779889 29.703049,5.6769892 28.227046,5.6769892z M1.0000012,0L5.3800108,0C5.9329897,0 6.3800117,0.44799811 6.3800117,1.0000001 6.3800117,1.5519869 5.9329897,2.0000004 5.3800108,2.0000004L2.0119652,2.0000004C2.249227,11.645887,5.8924619,18.10379,9.3609892,18.303246L9.5127122,18.307617 9.5250556,18.306994 9.5381066,18.307652 9.6910311,18.303246C13.159531,18.10379,16.803771,11.645887,17.040972,2.0000004L13.672012,2.0000004C13.118971,2.0000004 12.67201,1.5519869 12.67201,1.0000001 12.67201,0.44799811 13.118971,0 13.672012,0L18.052998,0C18.605977,0 19.052998,0.44799811 19.052998,1.0000001 19.052998,10.981137 15.49719,18.968525 10.755605,20.155634L10.525055,20.20751 10.525055,23.648993C10.525055,28.252993 14.27205,31.998991 18.876044,31.998991 23.480038,31.998991 27.227032,28.252993 27.227032,23.648993L27.227032,12.922256 27.05947,12.883493C25.043347,12.363618 23.549037,10.530019 23.549037,8.3539888 23.549037,5.7749892 25.648041,3.6769902 28.227046,3.6769902 30.806052,3.6769902 32.904055,5.7749892 32.904055,8.3539888 32.904055,10.530019 31.410456,12.363618 29.394557,12.883493L29.22703,12.922252 29.22703,23.648993C29.22703,29.355991 24.583037,33.998991 18.876044,33.998991 13.169051,33.998991 8.5250565,29.355991 8.5250565,23.648993L8.5250565,20.207045 8.2966172,20.155634C3.555757,18.968525 -9.7305019E-08,10.981137 0,1.0000001 -9.7305019E-08,0.44799811 0.44696084,0 1.0000012,0z" ),
            new DoughnutChartModel("Travel", 15, "M22.875021,28.999992L24.875021,28.999992 24.875021,31.999992 22.875021,31.999992z M3.875022,28.999992L5.8750223,28.999992 5.8750223,31.999992 3.875022,31.999992z M20.115029,22.365994L20.115029,24.499992 24.208018,24.499992 24.208018,22.365994z M4.2080077,22.365994L4.2080077,24.499992 8.2999805,24.499992 8.2999805,22.365994z M19.115033,21.365994L25.208014,21.365994 25.208014,25.499992 19.115033,25.499992z M3.2080141,21.365994L9.2999738,21.365994 9.2999738,25.499992 3.2080141,25.499992z M26.75,19.271777L26.680382,19.30329C26.381371,19.429931,26.052758,19.499994,25.708031,19.499994L2.708031,19.499994C2.4925579,19.499994,2.2833849,19.472625,2.0838036,19.421181L2,19.397341 2,26.75 26.75,26.75z M2.708031,7.4999938C2.5012744,7.4999939,2.3041461,7.5420567,2.1247544,7.6180725L2,7.6782665 2,18.321722 2.1247544,18.381916C2.3041461,18.457931,2.5012744,18.499994,2.708031,18.499994L25.708031,18.499994C26.069802,18.499994,26.402132,18.371176,26.661537,18.157005L26.75,18.076588 26.75,7.9233989 26.661537,7.8429831C26.402132,7.628811,26.069802,7.4999939,25.708031,7.4999938z M7.0000003,2C4.4153131,2,2.2823831,3.9713867,2.0258631,6.4895079L2.0176143,6.597635 2.0838036,6.5788066C2.2833849,6.5273621,2.4925579,6.499994,2.708031,6.4999941L25.708031,6.4999941C26.052758,6.4999939,26.381371,6.5700565,26.680382,6.6966974L26.742073,6.7246225 26.724137,6.4895079C26.467617,3.9713867,24.334689,2,21.75,2z M7.0000003,0L21.75,0C25.609,0,28.75,3.141,28.75,7.0000001L28.75,28.75 0,28.75 0,7.0000001C1.6391277E-07,3.141,3.1410001,0,7.0000003,0z"),
            new DoughnutChartModel( "Shopping", 17, "M24.998001,26.000008C23.895001,26.000008 22.998001,26.897008 22.998001,28.000008 22.998001,29.103008 23.895001,30.000008 24.998001,30.000008 26.101002,30.000008 26.998001,29.103008 26.998001,28.000008 26.998001,26.897008 26.101002,26.000008 24.998001,26.000008z M13.998001,26.000008C12.895004,26.000008 11.998001,26.897011 11.998002,28.000008 11.998001,29.103004 12.895004,30.000008 13.998001,30.000008 15.100998,30.000008 15.998001,29.103004 15.998001,28.000008 15.998001,26.897011 15.100998,26.000008 13.998001,26.000008z M24.998001,24.000008C27.204,24.000008 28.998001,25.794008 28.998001,28.000008 28.998001,30.206007 27.204,32.000008 24.998001,32.000008 22.792001,32.000008 20.998001,30.206007 20.998001,28.000008 20.998001,25.794008 22.792001,24.000008 24.998001,24.000008z M13.998001,24.000008C16.204002,24.000008 17.998001,25.794014 17.998001,28.000008 17.998001,30.206001 16.204002,32.000008 13.998001,32.000008 11.792,32.000008 9.9980011,30.206001 9.9980011,28.000008 9.9980011,25.794014 11.792,24.000008 13.998001,24.000008z M29.965622,6.9920082L6.8818386,6.999712 9.5831679,17.000008 26.873669,17.000008 29.990622,7.1260071C30.014622,7.0500069,29.974623,6.9980068,29.965622,6.9920082z M1,0L3.4629998,0C4.4029999,0,5.2259998,0.66800117,5.4200001,1.5880013L6.3416681,5.0000076 29.994621,5.0000076C30.625612,5.0000076 31.206604,5.2990074 31.588598,5.8200073 31.987593,6.3660069 32.102591,7.0800076 31.896593,7.7310085L28.77564,17.571008C28.504644,18.426008,27.740656,19.000008,26.873669,19.000008L10.123418,19.000008 10.648,20.942006 29.406002,20.997006C29.958002,20.997006 30.406002,21.445006 30.406002,21.997007 30.406002,22.549007 29.958002,22.997007 29.406002,22.997007L10.661,22.997007C9.7200003,22.997007,8.8980002,22.329007,8.7040001,21.408006L3.4759998,2.0550022 1,2.0000019C0.44799995,2.0000019 0,1.552002 0,1.0000019 0,0.44800186 0.44799995,0 1,0z" ),
            new DoughnutChartModel("Savings", 25, "M16.583996,15.881182L16.583996,17.498785 16.634388,17.475313C16.668547,17.457184 16.700748,17.437746 16.730999,17.416996 16.972,17.250996 17.092999,17.010996 17.092999,16.695995 17.092999,16.526997 17.052999,16.379995 16.972,16.255997 16.892,16.131996 16.778999,16.017996 16.634001,15.914996z M15.583996,12.426873L15.488001,12.474999C15.351002,12.551998 15.240002,12.648998 15.155002,12.767999 15.070002,12.887999 15.027001,13.031999 15.027001,13.200998 15.027001,13.359998 15.060001,13.497998 15.126001,13.612998 15.191002,13.728998 15.287002,13.835998 15.414001,13.930998 15.445751,13.955248 15.479189,13.97931 15.514345,14.003185L15.583996,14.047915z M16.083996,10.258009C16.359997,10.258009,16.583996,10.482009,16.583996,10.758009L16.583996,11.279663 16.67075,11.280939C17.273624,11.299328,17.723373,11.382124,18.019999,11.529999L18.019999,12.698998C17.669125,12.443499,17.230202,12.300546,16.703234,12.2688L16.583996,12.265293 16.583996,14.548255 16.693047,14.606903C16.872625,14.705997 17.04475,14.808747 17.209,14.915998 17.426998,15.057997 17.619999,15.215997 17.785999,15.387997 17.951998,15.559997 18.082998,15.751997 18.179998,15.962997 18.276999,16.172997 18.325998,16.411997 18.325998,16.679997 18.325998,17.041996 18.253998,17.346996 18.108997,17.595995 17.963999,17.844996 17.768999,18.046995 17.525,18.201996 17.278999,18.357996 16.997999,18.470995 16.678999,18.539995L16.583996,18.557922 16.583996,19.258009C16.583996,19.534008 16.359997,19.758009 16.083996,19.758009 15.807997,19.758009 15.583996,19.534008 15.583996,19.258009L15.583996,18.642614 15.57386,18.642448C15.474813,18.639307 15.361001,18.631247 15.232001,18.616995 15.059002,18.597996 14.882002,18.571995 14.701002,18.537994 14.521003,18.502995 14.350002,18.460995 14.189003,18.410996 14.028003,18.360994 13.898003,18.303995 13.799004,18.241995L13.799004,17.023996C13.907003,17.122995 14.036003,17.212996 14.186003,17.292995 14.336002,17.371996 14.494002,17.438995 14.662003,17.493996 14.830002,17.548996 14.997002,17.590996 15.165002,17.619995 15.291001,17.642496 15.409126,17.656557 15.52022,17.662182L15.583996,17.663832 15.583996,15.365119 15.495001,15.323997C15.256001,15.193997 15.032001,15.062997 14.825002,14.929997 14.617002,14.798997 14.438003,14.651998 14.285003,14.490997 14.132003,14.329997 14.012003,14.148997 13.925003,13.945997 13.838003,13.744998 13.794003,13.507998 13.794003,13.235998 13.794003,12.900998 13.869003,12.609999 14.018003,12.362999 14.168003,12.115999 14.365003,11.912999 14.610003,11.751999 14.855002,11.590999 15.133001,11.470999 15.446001,11.393L15.583996,11.36332 15.583996,10.758009C15.583996,10.482009,15.807997,10.258009,16.083996,10.258009z M8.5,10.000021C9.3280001,10.000021 10,10.672021 10,11.500021 10,12.328021 9.3280001,13.000021 8.5,13.000021 7.6719999,13.000021 7,12.328021 7,11.500021 7,10.672021 7.6719999,10.000021 8.5,10.000021z M8.8330002,2.8614497L8.8330002,7.9873367 8.4440002,8.2883568C7.1380005,9.2952977 6.1920013,10.57329 5.7099991,11.982263 5.5009995,12.592237 4.9349976,13.00025 4.2990036,13.00025L2,13.001226 2,16.999203 4.6620026,17.000179C5.2440033,17.000179 5.7779999,17.346182 6.0220032,17.881146 6.7389984,19.451126 7.7409973,20.561092 9.2689972,21.479105L9.4889984,21.612099 10,22.491112 10,26.000023 13,26.000023 13,24.726059C13,24.291069 13.188004,23.87805 13.516998,23.593082 13.846001,23.309092 14.282997,23.183056 14.711998,23.241098 15.204002,23.312082 15.593002,23.339058 16.099998,23.339058 16.549004,23.339058 16.887001,23.317087 17.305,23.264048 17.736,23.204052 18.167,23.340096 18.491997,23.626041 18.815002,23.910032 19,24.319021 19,24.749067L19,26.000023 21.997002,26.000023 21.997002,22.610067 22.498001,21.738073 22.718002,21.604103C24.802002,20.336121 26.217003,18.409151 26.702003,16.180187 26.853996,15.481225 27.454002,14.993196 28.162003,14.993196L30,14.993196 30,14.005238 28.154999,14.001209C27.453003,13.998219 26.856003,13.515256 26.700996,12.824227 25.786003,8.7453194 21.426003,5.89637 16.099998,5.89637 15.32,5.89637 14.550003,5.9563666 13.810997,6.0743456L13.404999,6.1403842z M7.9301248,2.1011191E-05C8.1509247,0.0013957158,8.3701239,0.07016635,8.5579987,0.20347598L13.907997,4.0394078C14.623001,3.9443777 15.358002,3.896405 16.099998,3.8964048 22.207001,3.896405 27.263,7.210373 28.557999,12.002281L30.502998,12.006249C31.329002,12.009239,32,12.682262,32,13.506223L32,15.535179C32,16.33918,31.346001,16.99316,30.542,16.99316L28.563004,16.99316C27.911003,19.511122,26.305,21.682104,23.997002,23.163097L23.997002,26.500013C23.997002,27.327026,23.323997,27.999989,22.497002,27.999989L18.5,27.999989C17.672997,27.999989,17,27.327026,17,26.500013L17,25.307041C16.364998,25.356052,15.653,25.353062,15,25.290012L15,26.500013C15,27.327026,14.327003,27.999989,13.5,27.999989L9.5,27.999989C8.6729965,27.999989,8,27.327026,8,26.500013L8,23.047071C6.3499985,22.004122,5.177002,20.707085,4.3389969,19.000145L1.5,18.999168C0.67299652,18.999168,0,18.326145,0,17.499195L0,12.501235C0,11.674284,0.67299652,11.001262,1.5,11.001262L3.9400024,11.000285C4.5220032,9.4973202,5.5130005,8.1343069,6.8330002,7.0193363L6.8330002,0.48148635 7.4260025,0.1204696C7.5856891,0.038653691,7.7583914,-0.0010477923,7.9301248,2.1011191E-05z"),
        };

            //Semi Doughnut
            SemiDoughnutData = new List<DoughnutChartModel>
            {
                new DoughnutChartModel("Product A", 750),
                new DoughnutChartModel("Product B", 463),
                new DoughnutChartModel("Product C", 389),
                new DoughnutChartModel("Product D", 697),
                new DoughnutChartModel("Product E", 251)
            };
            
            //Stacked Doughnut

            Track = new List<string>()
            {
                "Light Gray",
                "Blue Gray",
                "Pale Blue",
                "Light Coral",
                "Pale Violet"
            };

            StackedDoughnutData = new List<DoughnutChartModel>
            {
                new DoughnutChartModel("Labor", 10),
                new DoughnutChartModel("Production", 11),
                new DoughnutChartModel("Facilities", 12),
                new DoughnutChartModel("Insurance", 13)
            };

            CustomizedDoughnutData = new List<DoughnutChartModel>
            {
                new DoughnutChartModel("Vehicle",  62.70, new Uri(@"/syncfusion.chartdemos.wpf;component/Assets/Chart/Car.png",UriKind.RelativeOrAbsolute)),
                new DoughnutChartModel("Education", 29.50,  new Uri(@"/syncfusion.chartdemos.wpf;component/Assets/Chart/Chart_Book.png",UriKind.RelativeOrAbsolute)),
                new DoughnutChartModel("Personal",  85.20, new Uri(@"/syncfusion.chartdemos.wpf;component/Assets/Chart/Personal.png",UriKind.RelativeOrAbsolute)),
                new DoughnutChartModel("Home",  45.60,  new Uri(@"/syncfusion.chartdemos.wpf;component/Assets/Chart/House.png",UriKind.RelativeOrAbsolute)),
            };

            SelectedIndex = 1;
        }
    }

    public class NullToDoughnutCapStyleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return DoughnutCapStyle.BothFlat; 

            return value;
        }
     
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}