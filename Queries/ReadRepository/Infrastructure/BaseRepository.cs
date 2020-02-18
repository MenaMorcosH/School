using Dapper;
using School.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace School.Queries.ReadRepository.Infrastructure
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private string _connectionString = string.Empty;

        public BaseRepository(string connectionString)
        {
            _connectionString = ! String.IsNullOrWhiteSpace(connectionString)? connectionString : throw new ArgumentNullException(nameof(connectionString));
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string qr = $" SELECT * FROM [{typeof(T).Name}]"; 
                return await connection.QueryAsync<T>(qr);
                
            }
        }

        //public Task<int> Delete(int id)
        //{
        //    throw new NotImplementedException();
        //}



        public async Task<T> GetByIdAsync(int id , string KeyName)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                string qr = $" SELECT * FROM [{typeof(T).Name}] where [{KeyName}] = @Id";

                return ( await connection.QueryAsync<T>(qr, new {Id=id })).SingleOrDefault();
               

            }
        }

        //public Task<int> Insert(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<int> Update(T entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
