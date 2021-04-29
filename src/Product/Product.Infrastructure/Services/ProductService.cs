using MongoDB.Driver;
using Product.Application.Interfaces;
using Product.Application.Models;
using Product.Infrastructure.Settings;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IMongoCollection<Domain.Product> _products;

        public ProductService(IProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _products = database.GetCollection<Domain.Product>(settings.ProductCollectionName);
        }

        public async Task<List<ProductModel>> GetProductListAsync(int numberOfPages, int pageNumber)
        {
            var result = await _products.FindAsync(product => true);
            var productsResult = result.ToList();
            var products = new List<ProductModel>();
            productsResult.ForEach(product =>
               {
                   products.Add(new ProductModel
                   {
                       Id = product.Id,
                       Name = product.Name,
                       Description = product.Description,
                       Image = product.Image,
                       IsFeatured = product.IsFeatured,
                       Price = product.Price,
                   });
               });
            return products;
        }
    }
}
