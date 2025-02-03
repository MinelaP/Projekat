using Projekat.Background;
using Projekat.MVVM.Models;

namespace Projekat
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // Testiranje rada s bazom podataka
            var dataHandler = (BackgroundDataHandler)App.Services.GetService(typeof(BackgroundDataHandler));
            var testProduct = new Product { Name = "Test Product", ImageUrl = "test.png", Price = 9.99m, Description = "This is a test product" };
            dataHandler.SaveProductAsync(testProduct).Wait();

            var products = dataHandler.GetProductsAsync().Result;
            foreach (var product in products)
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price}");
            }
        }
    }
}
