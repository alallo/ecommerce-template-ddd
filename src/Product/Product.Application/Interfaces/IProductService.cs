using Product.Application.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductModel>> GetProductListAsync(int numberOfPages, int pageNumber);
    }
}
