using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppIntroMVVM
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _fullName;

        public string FirstName { get { return _firstName; } set { _firstName = value; OnPropertyChanged(nameof(FirstName)); UpdateFullNameFromNames(); } }
        public string LastName { get { return _lastName; } set { _lastName = value; OnPropertyChanged(nameof(LastName)); UpdateFullNameFromNames(); } }
        public string FullName { get { return _fullName; } set { _fullName = value; OnPropertyChanged(nameof(FullName)); UpdateNamesFromFullName(); } }

        public event PropertyChangedEventHandler? PropertyChanged;

        public MainWindowViewModel()
        {
            UpdateCommand = new RelayCommand(Update,CanUpdate);
            _firstName = string.Empty;
            _lastName = string.Empty;
            _fullName = string.Empty;
        }

        public ICommand UpdateCommand { get; set; }

        private void Update()
        {
            FirstName = "Henry";
            LastName = "Sifuentes";
        }

        private bool CanUpdate()
        {
            return string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName);
        }
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateFullNameFromNames() {
            _fullName = $"{_firstName} {_lastName}";
            OnPropertyChanged(nameof(FullName));
        }

        private void UpdateNamesFromFullName()
        {
            var name = _fullName.Split(' ');
            if (name.Length >= 2)
            {
                FirstName = name[0];
                LastName = name[1];
            }
            else {
                FirstName = _fullName;
                LastName = String.Empty;
            }
        }
    }
}
