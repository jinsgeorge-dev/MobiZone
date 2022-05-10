using Microsoft.EntityFrameworkCore;
using ProductCatalog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalog.EFRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbContext _context;
        DbSet<T> _dbSet;

        #region Constructor
        public GenericRepository(DbContext context)
        {
            this._context = context;
            _dbSet = context.Set<T>();
        }
        #endregion

        #region Generic method for Add
        public async virtual Task<T> Add(T item)
        {
            try
            {
                _dbSet.Add(item);
                await _context.SaveChangesAsync();
                return item;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        #endregion

        public async virtual Task Delete(int id)
        {
            T entity = await _dbSet.FindAsync(id);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async virtual Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async virtual Task<T> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }



        public async virtual Task Update(T item)
        {
            _context.Entry<T>(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
       

    }
}
