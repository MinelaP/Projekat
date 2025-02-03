using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Projekat.MVVM.Models;

namespace Projekat.Services
{
    public class SQLiteHelper
    {
        private readonly SQLiteAsyncConnection _database;

        public SQLiteHelper(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Product>().Wait();
        }

        public Task<int> SaveProductAsync(Product product)
        {
            return _database.InsertAsync(product);
        }

        public Task<List<Product>> GetProductsAsync()
        {
            return _database.Table<Product>().ToListAsync();
        }
    }
}
