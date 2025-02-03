using Projekat.MVVM.View;
using Microsoft.Maui.Controls;
using Microsoft.Extensions.DependencyInjection;
using Projekat.Services;
using Projekat.Background;


namespace Projekat
{
    public partial class App : Application
    {
        public static IServiceProvider Services { get; private set; }

        public App()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            Services = serviceCollection.BuildServiceProvider();

            MainPage = new NavigationPage(new SplashPage());
        }

        private void ConfigureServices(IServiceCollection services)
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "projekat.db3");
            services.AddSingleton(new SQLiteHelper(dbPath));
            services.AddTransient<BackgroundDataHandler>();
        }
    }
}
