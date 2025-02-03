using Microsoft.Maui.Controls;
using Projekat.MVVM.Models;
using Projekat.MVVM.View;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Projekat.MVVM.ViewModels
{
    public class ShopViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Product> Products { get; set; }
        public ICommand BuyCommand { get; }
        public ICommand NavigateToProfileCommand { get; }
        public ICommand NavigateToCartCommand { get; }

        private INavigation _navigation;

        public ShopViewModel()
        {
            Products = new ObservableCollection<Product>
            {
               new Product { Name = "Bojanka 1", ImageUrl = "bojanka1.png", Description = "Fantastičan crtež za bojanje za djecu.", Price = 4.99m },
new Product { Name = "Bojanka 2", ImageUrl = "bojanka2.png", Description = "Predivan crtež za bojanje za djecu.", Price = 5.99m },
new Product { Name = "Bojanka 3", ImageUrl = "bojanka3.png", Description = "Zabavan crtež za bojanje za djecu.", Price = 4.99m },
new Product { Name = "Bojanka 4", ImageUrl = "bojanka4.png", Description = "Maštovit crtež za bojanje za djecu.", Price = 5.99m },
new Product { Name = "Bojanka 5", ImageUrl = "bojanka5.png", Description = "Kreativan crtež za bojanje za djecu.", Price = 4.99m },

new Product { Name = "Slikovnica 1", ImageUrl = "slikovnica1.png", Description = "Očaravajuća slikovnica za djecu.", Price = 5.99m },
new Product { Name = "Slikovnica 2", ImageUrl = "slikovnica2.png", Description = "Čarobna slikovnica za djecu.", Price = 5.99m },
new Product { Name = "Slikovnica 3", ImageUrl = "slikovnica3.png", Description = "Zabavna slikovnica za djecu.", Price = 5.99m },
new Product { Name = "Slikovnica 4", ImageUrl = "slikovnica4.png", Description = "Razigrana slikovnica za djecu.", Price = 5.99m },
new Product { Name = "Slikovnica 5", ImageUrl = "slikovnica5.png", Description = "Poučna slikovnica za djecu.", Price = 5.99m },
new Product { Name = "Slikovnica 6", ImageUrl = "slikovnica6.png", Description = "Avanturistička slikovnica za djecu.", Price = 5.99m },

            };

            BuyCommand = new Command<Product>(OnBuy);
            NavigateToProfileCommand = new Command(OnNavigateToProfile);
            NavigateToCartCommand = new Command(OnNavigateToCart);
        }

        public void SetNavigation(INavigation navigation)
        {
            _navigation = navigation;
        }

        private async void OnBuy(Product product)
        {
            // Adding product to cart
            CartViewModel.Instance.AddToCart(product);

            // Navigate to CartPage
            if (_navigation != null)
            {
                await _navigation.PushAsync(new CardPage());
            }
        }

        private async void OnNavigateToProfile()
        {
            if (_navigation != null)
            {
                await _navigation.PushAsync(new ProfilePage());
            }
        }

        private async void OnNavigateToCart()
        {
            if (_navigation != null)
            {
                await _navigation.PushAsync(new CardPage());
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
