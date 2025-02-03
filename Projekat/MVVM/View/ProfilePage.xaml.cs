using Projekat.MVVM.ViewModels;
using Microsoft.Maui.Controls;

namespace Projekat.MVVM.View;

public partial class ProfilePage : ContentPage
{
    public ProfilePage()
    {
        InitializeComponent();
        BindingContext = new ProfileViewModel(Navigation);
    }
}
