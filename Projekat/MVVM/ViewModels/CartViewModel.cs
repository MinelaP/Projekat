using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Maui.Controls;
using Projekat.MVVM.Models;

namespace Projekat.MVVM.ViewModels
{
    public class CartViewModel : INotifyPropertyChanged
    {
        private static CartViewModel _instance;
        public static CartViewModel Instance => _instance ??= new CartViewModel();

        public ObservableCollection<Product> CartItems { get; set; }
        public ICommand CheckoutCommand { get; }
        public ICommand RemoveItemCommand { get; }

        public CartViewModel()
        {
            CartItems = new ObservableCollection<Product>();
            CheckoutCommand = new Command(OnCheckout);
            RemoveItemCommand = new Command<Product>(OnRemoveItem);
        }

        public void AddToCart(Product product)
        {
            CartItems.Add(product);
            OnPropertyChanged(nameof(CartItems));
        }

        private async void OnCheckout()
        {
            // Purchase logic
            await Application.Current.MainPage.DisplayAlert("Kupi", "Kupovina Uspjesna!", "OK");
            CartItems.Clear();
            OnPropertyChanged(nameof(CartItems));
        }

        private void OnRemoveItem(Product product)
        {
            if (product != null && CartItems.Contains(product))
            {
                CartItems.Remove(product);
                OnPropertyChanged(nameof(CartItems));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
