using Projekat.MVVM.Models;
using Projekat.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projekat.Background
{
    public class BackgroundDataHandler
    {
        private readonly SQLiteHelper _database;

        public BackgroundDataHandler(SQLiteHelper database)
        {
            _database = database;
        }

        public async Task SaveProductAsync(Product product)
        {
            await _database.SaveProductAsync(product);
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            return await _database.GetProductsAsync();
        }
    }
}
