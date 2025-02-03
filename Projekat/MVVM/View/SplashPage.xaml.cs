using System.Threading.Tasks;
using Microsoft.Maui.Controls;
namespace Projekat.MVVM.View;


    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            NavigateToWelcomePage();
        }

        private async void NavigateToWelcomePage()
        {
            await Task.Delay(5000); // Èeka 5 sekunde
            Application.Current.MainPage = new NavigationPage(new WelcomePage());
        }
    }
