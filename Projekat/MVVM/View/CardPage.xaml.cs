using Projekat.MVVM.ViewModels;
using Microsoft.Maui.Controls;

namespace Projekat.MVVM.View;

public partial class CardPage : ContentPage
{
    public CardPage()
    {
        InitializeComponent();
        BindingContext = CartViewModel.Instance;
    }
}
