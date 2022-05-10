using Microsoft.EntityFrameworkCore;
using ProductCatalog.Domain.DataBase;
using ProductCatalog.Domain.Products;
using ProductCatalog.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace ProductCatalog.EFRepository
{
    public class CatalogProductRepository : GenericRepository<Product>, ICatalogProductRepository
    {
        private readonly CatalogDBContext context;
        public CatalogProductRepository(CatalogDBContext context) : base(context)
        {
            this.context = context;
        }
        public async override Task<IEnumerable<Product>> GetAll()
        {
            return await context.Products.ToListAsync();
        }
        public async Task<Product> Add(Product item)
        {
            try
            {
                context.Products.Add(item);

                await context.SaveChangesAsync();
                return item;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public async Task<Product> GetById(int id)
        {
            return await context.Products
                .FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<Product> Update(Product product)
        {

            /* var result = await context.Product
                 .FirstOrDefaultAsync(e => e.Id == product.Id);

             if (result != null)
             {
                 result.Id = product.Id;
                 result.Name = product.Name;
                 result.Price = product.Price;
                 result.AvailableStock = product.AvailableStock;
                 result.IsActive = product.IsActive;


                 await context.SaveChangesAsync();

                 return result;
             }

             return null;*/

            var entity = context.Products.Attach(product);
            entity.State = EntityState.Modified;
            context.SaveChanges();
            return product;
        }
        public async void Delete(int id)
        {
            var result = await context.Products
                .FirstOrDefaultAsync(e => e.Id == id);
            if (result != null)
            {
                context.Products.Remove(result);
                await context.SaveChangesAsync();
            }
        }


    }
}
