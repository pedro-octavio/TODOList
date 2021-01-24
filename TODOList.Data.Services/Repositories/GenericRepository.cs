using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using TODOList.Data.Core.Repositories;

namespace TODOList.Data.Services.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ApplicationDataContext applicationDataContext;

        public GenericRepository(ApplicationDataContext applicationDataContext)
        {
            this.applicationDataContext = applicationDataContext;
        }

        public async Task<T> GetByIdAsync(string id)
        {
            var obj = await applicationDataContext.Set<T>().FindAsync(id);

            if (obj != null)
            {
                applicationDataContext.Entry(obj).State = EntityState.Detached;
            }

            return obj;
        }

        public virtual Task<string> AddAsync(T obj)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(T obj)
        {
            applicationDataContext.Set<T>().Update(obj);

            await applicationDataContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T obj)
        {
            applicationDataContext.Set<T>().Remove(obj);

            await applicationDataContext.SaveChangesAsync();
        }
    }
}
