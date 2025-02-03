using Microsoft.Maui.Controls;
using Projekat.MVVM.View;
using System.ComponentModel;
using System.Windows.Input;

namespace Projekat.MVVM.ViewModels
{
    public class ProfileViewModel : INotifyPropertyChanged
    {
        private string _name;
        private string _surname;
        private string _email;
        private string _profilePicture;
        private DateTime _dateOfBirth;

        public string Name
        {
            get => _name;
            set
            {
                if (_name != value)
                {
                    _name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }

        public string Surname
        {
            get => _surname;
            set
            {
                if (_surname != value)
                {
                    _surname = value;
                    OnPropertyChanged(nameof(Surname));
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

        public string ProfilePicture
        {
            get => _profilePicture;
            set
            {
                if (_profilePicture != value)
                {
                    _profilePicture = value;
                    OnPropertyChanged(nameof(ProfilePicture));
                }
            }
        }

        public DateTime DateOfBirth
        {
            get => _dateOfBirth;
            set
            {
                if (_dateOfBirth != value)
                {
                    _dateOfBirth = value;
                    OnPropertyChanged(nameof(DateOfBirth));
                }
            }
        }

        public ICommand LogoutCommand { get; }
        public ICommand NavigateToShopCommand { get; }
        public ICommand NavigateToCartCommand { get; }

        private readonly INavigation _navigation;

        public ProfileViewModel() { } // Default konstruktor

        public ProfileViewModel(INavigation navigation)
        {
            _navigation = navigation;
            LogoutCommand = new Command(OnLogout);
            NavigateToShopCommand = new Command(OnNavigateToShop);
            NavigateToCartCommand = new Command(OnNavigateToCart);
        }

        private async void OnLogout()
        {
            // Logika za odjavu
            await Application.Current.MainPage.DisplayAlert("Odjava", "Odjava uspješna!", "OK");
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

        private async void OnNavigateToShop()
        {
            if (_navigation != null)
            {
                await _navigation.PushAsync(new ShoppingPage());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Navigacija nije postavljena.", "OK");
            }
        }

        private async void OnNavigateToCart()
        {
            if (_navigation != null)
            {
                await _navigation.PushAsync(new CardPage());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Navigacija nije postavljena.", "OK");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
