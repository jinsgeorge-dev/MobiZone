using ProductCatalog.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Services
{
    public interface IProductService
    {

        Task<IEnumerable<Product>> GetProductItemsAsync();
        Task<IEnumerable<Product>> GetProductItemsByIdAsync(int id);
        Task<bool> AddProductItemsAsync(Product item);
        //Task<IEnumerable<Product>> EditProductItemsAsync();

    }
}
