using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace App2
{
    public class TaskView : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Task task;
        public TaskView()
        {
            task = new Task
            {
                _date = DateTime.Now.ToString()
            };
        }
        public string description
        {
            get { return task._description; }
            set
            {
                if (task._description != value)
                {
                    task._description = value;
                    OnPropertyChanged("description");
                }
            }
        }
        public string date
        {
            get { return task._date; }
            set
            {
                if (task._date != value)
                {
                    task._date = value;
                    OnPropertyChanged("date");
                }
            }
        }
        public string check
        {
            get { return task._check; }
            set
            {
                if (task._check != value)
                {
                    task._check = value;
                    OnPropertyChanged("check");
                }
            }
        }
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
