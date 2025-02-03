using Microsoft.Maui.Controls;

namespace Projekat.MVVM.View;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void NavigateToRegistrationPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new RegistrationPage());
    }
}
