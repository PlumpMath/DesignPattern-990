using System;
using System.ComponentModel;
using System.Windows.Input;
using SimpleMvvm.Models;

namespace SimpleMvvm.ViewModels
{
    public class MainViewModel: INotifyPropertyChanged
    {

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        private Person _modelPerson;

        public Person ModelPerson
        {
            get { return _modelPerson; }
            set { _modelPerson = value; OnPropertyChanged("ModelPerson"); }
        }

        private ICommand _savePersonCommand;

        public ICommand SavePersonCommand
        {
            get { return _savePersonCommand; }

            set
            {
                _savePersonCommand = value;
                OnPropertyChanged("SavePersonCommand");
            }
        }

        public MainViewModel()
        {
            InitializeCommand();
            LoadPerson();
        }

        private void InitializeCommand()
        {
           SavePersonCommand = new SavePersonCommand(UpdatePerson);
        }

        private void LoadPerson()
        {
            ModelPerson = new Person()
                              {
                                  FirstName = "Brian",
                                  LastName = "Lagunas",
                                  UpdatedDate = DateTime.Now                                 
                              };

        }



        private void UpdatePerson()
        {
            ModelPerson.UpdatedDate = DateTime.Now;
        }
    }
}