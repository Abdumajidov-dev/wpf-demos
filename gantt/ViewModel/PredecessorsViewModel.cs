#region Copyright Syncfusion Inc. 2001-2024.
// Copyright Syncfusion Inc. 2001-2024. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using Syncfusion.Windows.Controls.Gantt;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion.ganttdemos.wpf
{
    public class PredecessorsViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModel"/> class.
        /// </summary>
        public PredecessorsViewModel()
        {
            _taskDetails = PredecessorsViewModel.GetData();
        }

        private ObservableCollection<PredecessorsModel> _taskDetails;

        /// <summary>
        /// Gets or sets the appointment item source.
        /// </summary>
        /// <value>The appointment item source.</value>
        public ObservableCollection<PredecessorsModel> TaskDetails
        {
            get
            {
                return _taskDetails;
            }
            set
            {
                _taskDetails = value;
            }
        }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public static ObservableCollection<PredecessorsModel> GetData()
        {
            var data = new ObservableCollection<PredecessorsModel>();
            data.Add(new PredecessorsModel() { Id = 1, Name = "Analysis/Planning", StDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 8, 14), Complete = 40d });
            data[0].ChildTask.Add((new PredecessorsModel() { Id = 2, Name = "Identify Components to be Localized", StDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 5), Complete = 20d }));
            data[0].ChildTask.Add((new PredecessorsModel() { Id = 3, Name = "Ensure file localizability", StDate = new DateTime(2024, 7, 6), EndDate = new DateTime(2024, 7, 7), Complete = 20d }));
            data[0].ChildTask.Add((new PredecessorsModel() { Id = 4, Name = "Identify tools", StDate = new DateTime(2024, 7, 10), EndDate = new DateTime(2024, 7, 14), Complete = 10d }));
            data[0].ChildTask.Add((new PredecessorsModel() { Id = 5, Name = "Test tools", StDate = new DateTime(2024, 7, 14), EndDate = new DateTime(2024, 8, 1), Complete = 10d }));
            data[0].ChildTask.Add((new PredecessorsModel() { Id = 6, Name = "Develop delivery timeline", StDate = new DateTime(2024, 7, 10), EndDate = new DateTime(2024, 8, 1), Complete = 10d }));
            data[0].ChildTask.Add((new PredecessorsModel() { Id = 7, Name = "Analysis complete", StDate = new DateTime(2024, 7, 14), EndDate = new DateTime(2024, 8, 10), Complete = 10d }));

            data.Add(new PredecessorsModel() { Id = 8, Name = "Production", StDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 14), Complete = 40d });
            data[1].ChildTask.Add((new PredecessorsModel() { Id = 9, Name = "Software Components", StDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 5), Complete = 20d, }));
            data[1].ChildTask.Add((new PredecessorsModel() { Id = 10, Name = "Localization Component - User Interface", StDate = new DateTime(2024, 7, 6), EndDate = new DateTime(2024, 7, 7), Complete = 20d }));
            data[1].ChildTask.Add((new PredecessorsModel() { Id = 11, Name = "User Assistance Components", StDate = new DateTime(2024, 7, 10), EndDate = new DateTime(2024, 7, 14), Complete = 10d }));
            data[1].ChildTask.Add((new PredecessorsModel() { Id = 12, Name = "Software components complete", StDate = new DateTime(2024, 7, 14), EndDate = new DateTime(2024, 7, 18), Complete = 10d }));


            data.Add(new PredecessorsModel() { Id = 13, Name = "Quality Assurance", StDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 12), Complete = 40d, });
            data[2].ChildTask.Add((new PredecessorsModel() { Id = 14, Name = "Review project information", StDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 15), Complete = 20d }));
            data[2].ChildTask.Add((new PredecessorsModel() { Id = 15, Name = "Localization Component", StDate = new DateTime(2024, 7, 6), EndDate = new DateTime(2024, 7, 8), Complete = 20d }));
            data[2].ChildTask.Add((new PredecessorsModel() { Id = 16, Name = "Localization Component", StDate = new DateTime(2024, 7, 10), EndDate = new DateTime(2024, 7, 14), Complete = 10d }));
            data[2].ChildTask.Add((new PredecessorsModel() { Id = 17, Name = "Localization Component", StDate = new DateTime(2024, 7, 14), EndDate = new DateTime(2024, 7, 18), Complete = 10d }));

            data.Add(new PredecessorsModel() { Id = 18, Name = "Beta Testing", StDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 14), Complete = 40d });
            data[3].ChildTask.Add((new PredecessorsModel() { Id = 19, Name = "Disseminate completed product", StDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 5), Complete = 20d }));
            data[3].ChildTask.Add((new PredecessorsModel() { Id = 20, Name = "Obtain feedback", StDate = new DateTime(2024, 7, 6), EndDate = new DateTime(2024, 7, 7), Complete = 20d }));
            data[3].ChildTask.Add((new PredecessorsModel() { Id = 21, Name = "Modify", StDate = new DateTime(2024, 7, 10), EndDate = new DateTime(2024, 7, 19), Complete = 10d }));
            data[3].ChildTask.Add((new PredecessorsModel() { Id = 22, Name = "Test", StDate = new DateTime(2024, 7, 14), EndDate = new DateTime(2024, 7, 19), Complete = 10d }));
            data[3].ChildTask.Add((new PredecessorsModel() { Id = 23, Name = "Complete", StDate = new DateTime(2024, 7, 10), EndDate = new DateTime(2024, 7, 19), Complete = 10d }));

            data.Add(new PredecessorsModel() { Id = 24, Name = "Post-Project Review", StDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 14), Complete = 40d, });
            data[4].ChildTask.Add((new PredecessorsModel() { Id = 25, Name = "Finalize cost analysis", StDate = new DateTime(2024, 7, 3), EndDate = new DateTime(2024, 7, 5), Complete = 20d }));
            data[4].ChildTask.Add((new PredecessorsModel() { Id = 26, Name = "Analyze performance", StDate = new DateTime(2024, 7, 6), EndDate = new DateTime(2024, 7, 7), Complete = 20d }));
            data[4].ChildTask.Add((new PredecessorsModel() { Id = 27, Name = "Archive files", StDate = new DateTime(2024, 7, 10), EndDate = new DateTime(2024, 7, 14), Complete = 10d }));
            data[4].ChildTask.Add((new PredecessorsModel() { Id = 28, Name = "Document lessons learned", StDate = new DateTime(2024, 7, 14), EndDate = new DateTime(2024, 7, 18), Complete = 10d }));
            data[4].ChildTask.Add((new PredecessorsModel() { Id = 29, Name = "Distribute to team members", StDate = new DateTime(2024, 7, 10), EndDate = new DateTime(2024, 7, 14), Complete = 10d }));
            data[4].ChildTask.Add((new PredecessorsModel() { Id = 30, Name = "Post-project review complete", StDate = new DateTime(2024, 7, 10), EndDate = new DateTime(2024, 7, 14), Complete = 10d }));

            data[1].Resource.Add(new Resource() { ID = 1, Name = "Localizer" });
            data[2].Resource.Add(new Resource() { ID = 2, Name = "Technical Reviewer" });
            data[3].Resource.Add(new Resource() { ID = 3, Name = "Project Manager" });

            data[0].ChildTask[1].Predecessor.Add(new Predecessor() { GanttTaskIndex = 2, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[0].ChildTask[2].Predecessor.Add(new Predecessor() { GanttTaskIndex = 3, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[0].ChildTask[3].Predecessor.Add(new Predecessor() { GanttTaskIndex = 3, GanttTaskRelationship = GanttTaskRelationship.StartToStart });

            data[1].ChildTask[1].Predecessor.Add(new Predecessor() { GanttTaskIndex = 9, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[1].ChildTask[2].Predecessor.Add(new Predecessor() { GanttTaskIndex = 10, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[1].ChildTask[3].Predecessor.Add(new Predecessor() { GanttTaskIndex = 7, GanttTaskRelationship = GanttTaskRelationship.StartToStart });

            data[2].ChildTask[1].Predecessor.Add(new Predecessor() { GanttTaskIndex = 12, GanttTaskRelationship = GanttTaskRelationship.FinishToFinish });
            data[2].ChildTask[2].Predecessor.Add(new Predecessor() { GanttTaskIndex = 12, GanttTaskRelationship = GanttTaskRelationship.FinishToFinish });
            data[2].ChildTask[3].Predecessor.Add(new Predecessor() { GanttTaskIndex = 12, GanttTaskRelationship = GanttTaskRelationship.FinishToFinish });

            data[3].ChildTask[1].Predecessor.Add(new Predecessor() { GanttTaskIndex = 18, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[3].ChildTask[2].Predecessor.Add(new Predecessor() { GanttTaskIndex = 18, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[3].ChildTask[3].Predecessor.Add(new Predecessor() { GanttTaskIndex = 19, GanttTaskRelationship = GanttTaskRelationship.StartToStart });

            data[4].ChildTask[1].Predecessor.Add(new Predecessor() { GanttTaskIndex = 25, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[4].ChildTask[2].Predecessor.Add(new Predecessor() { GanttTaskIndex = 28, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[4].ChildTask[3].Predecessor.Add(new Predecessor() { GanttTaskIndex = 30, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            data[4].ChildTask[4].Predecessor.Add(new Predecessor() { GanttTaskIndex = 27, GanttTaskRelationship = GanttTaskRelationship.StartToStart });
            return data;
        }

        internal void Dispose()
        {
            foreach(var taskDetail in TaskDetails)
            {
                taskDetail.Dispose();
            }
        }

    }

}
