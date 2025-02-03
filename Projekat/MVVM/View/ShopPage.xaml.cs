using Projekat.MVVM.ViewModels;
using Microsoft.Maui.Controls;

namespace Projekat.MVVM.View;

public partial class ShoppingPage : ContentPage
{
    public ShoppingPage()
    {
        InitializeComponent();
        var viewModel = new ShopViewModel();
        viewModel.SetNavigation(Navigation);
        BindingContext = viewModel;
    }
}
