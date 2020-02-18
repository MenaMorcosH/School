using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Queries.ReadRepository.Infrastructure
{
    public interface IBaseRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
       Task<T> GetByIdAsync(int id, string KeyName);
     //   Task<T> GetWhereAsync(object obj);
        //Task<int> Insert(T entity);
        //Task<int> Update(T entity);
        //Task<int> Delete(int id);
    }
}
