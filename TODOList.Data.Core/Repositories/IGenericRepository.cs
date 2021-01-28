using System.Collections.Generic;
using System.Threading.Tasks;

namespace TODOList.Data.Core.Repositories
{
    /// <summary>
    /// interface for generic repositorys
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// generic function for get a row by if for table
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<T> GetByIdAsync(string id);

        /// <summary>
        /// generic function for create new row in table
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task<string> AddAsync(T obj);

        /// <summary>
        /// generic function for edit new row in table
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task UpdateAsync(T obj);

        /// <summary>
        /// generic function for delete a row in table
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        Task DeleteAsync(T obj);
    }
}
