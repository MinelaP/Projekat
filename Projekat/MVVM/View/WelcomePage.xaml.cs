using Microsoft.Maui.Controls;
namespace Projekat.MVVM.View;


    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
        }

        private async void NavigateToLoginPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
