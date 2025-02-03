using Microsoft.Maui.Controls;
using Projekat.MVVM.View;
using System.ComponentModel;
using System.Windows.Input;

namespace Projekat.MVVM.ViewModels
{
    public class RegistrationViewModel : INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _password;

        public string FirstName
        {
            get => _firstName;
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged(nameof(Password));
                }
            }
        }

        public ICommand RegisterCommand { get; }

        public RegistrationViewModel()
        {
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnRegister()
        {
            // Logika za registraciju
            await Application.Current.MainPage.DisplayAlert("Registracija", "Registracija uspješna!", "OK");
            Application.Current.MainPage = new NavigationPage(new ShoppingPage());
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
