using System;
using System.ComponentModel;

namespace SimpleMvvm.Models
{
    public class Person : INotifyPropertyChanged, IDataErrorInfo
    {
        private string _firstName;
        private string _lastName; 


        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnPropertyChanged("FirstName"); }
        }

        public string LastName 
        {
            get { return _lastName; }
            set { _lastName = value; OnPropertyChanged("LastName"); }
        }

        private DateTime _updateDate;
        public DateTime UpdatedDate
        {
            get { return _updateDate; }
            set { _updateDate = value; OnPropertyChanged("UpdatedDate"); }
        }



        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string property)
        {
            if (PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
                
        }

        #endregion


        #region IDataErrorInfo Members

        public string Error
        {
            get { return null; }           
        }

        public string this[string columnName]
        {
            get 
            { 
                string error = string.Empty;
                if(string.IsNullOrEmpty(_firstName))
                {
                    error = "First Name is empty";
                }
                return error;
            }
        }

        #endregion
    }
}