using ProductCatalog.Domain.Products;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject.Admin
{
    public class CatalogProductBO : ICatalogProductBO
    {
        private readonly ICatalogProductRepository catalogProductRepository;
        public CatalogProductBO(ICatalogProductRepository catalogProductRepository)
        {
            this.catalogProductRepository = catalogProductRepository;
        }
        public async Task<Product> Add(Product item)
        {
            return await catalogProductRepository.Add(item);
        }

        public async Task Delete(int id)
        {
            await catalogProductRepository.Delete(id);
        }
        /// <summary>
        /// bo/get all
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Product>> GetAll()
        {
            return await catalogProductRepository.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await catalogProductRepository.GetById(id);
        }

        public Task Update(Product item)
        {

            return catalogProductRepository.Update(item);

        }
    }
}
