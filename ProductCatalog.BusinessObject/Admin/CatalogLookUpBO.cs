using ProductCatalog.Domain.Products;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.BusinessObject
{
    public class CatalogLookUpBO : ICatalogLookUpBO
    {
        private readonly ICatalogLookUpRepository catalogLookUpRepository;

        public CatalogLookUpBO(ICatalogLookUpRepository catalogLookUpRepository)
        {
            this.catalogLookUpRepository = catalogLookUpRepository;
        }
        #region this is add for lookup    
        public async Task<LookUp> Add(LookUp item)
        {
            try
            {
                if (item.name == null)
                {
                    return null;
                }
                else
                {
                    return await catalogLookUpRepository.Add(item);
                    
                }
                
            }
            catch(Exception ex)
            {
                return null;
            }
            
        }

        #endregion



        public async Task<IEnumerable<LookUp>> GetLookUpItems()
        {
            return await catalogLookUpRepository.GetAll();
        }



    }
}
