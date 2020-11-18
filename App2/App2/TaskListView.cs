using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace App2
{
    class TaskListView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<TaskView> taskViews { get; set; }
        public ICommand accept { get; set; }
        public ICommand remove { get; set; }
        public string descr { set; get;}
        public TaskListView()
        {
            taskViews = new ObservableCollection<TaskView>();
            accept = new Command(create);
            remove = new Command(RemoveTask);
        }
        void create(object nthg = null)
        {
            if (!string.IsNullOrEmpty(descr))
            taskViews.Add(new TaskView
            {
                description = descr
            });
        }
        void RemoveTask(object item)
        {
            taskViews.Remove((TaskView)item);
        }
    }
}
