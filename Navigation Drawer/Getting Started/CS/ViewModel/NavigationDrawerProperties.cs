#region Copyright Syncfusion Inc. 2001-2020.
// Copyright Syncfusion Inc. 2001-2020. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.UI.Xaml.NavigationDrawer;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace GettingStarted
{
    public class NavigationDrawerProperties : NotificationObject
    {
        public NavigationDrawerProperties()
        {
            Contents = new ObservableCollection<ListContent>();
            Contents.Add(new ListContent() { Name = "Home" , Image= "/Assets/NavigationDrawer/home.png" });
            Contents.Add(new ListContent() { Name = "People", Image = "/Assets/NavigationDrawer/people.png" });
            Contents.Add(new ListContent() { Name = "Photos", Image = "/Assets/NavigationDrawer/photo.png" });
        }
        private ObservableCollection<ListContent> contents;

        public ObservableCollection<ListContent> Contents
        {
            get { return contents; }
            set { contents = value; RaisePropertyChanged("Contents"); }
        }
        private Position position = Position.Left;

        public Position SlidePosition
        {
            get { return position; }
            set { position = value; RaisePropertyChanged("SlidePosition"); }
        }

        private Transition transition = Transition.SlideOnTop;

        public Transition SlideTransition
        {
            get { return transition; }
            set { transition = value; RaisePropertyChanged("SlideTransition"); }
        }
    }

    public class ListContent : NotificationObject
    {
        private string name;
        private string content;
        private string image; 
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged("Name"); }
        }

        public string Content
        {
            get { return content; }
            set { content = value; RaisePropertyChanged("Content"); }
        }

        public string Image
        {
            get { return image; }
            set { image = value; RaisePropertyChanged("Image"); }
        }
    }
}
