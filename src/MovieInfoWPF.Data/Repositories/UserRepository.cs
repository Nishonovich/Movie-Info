using MovieInfo.Data.Interfaces;
using MovieInto.Domain.Configurations;
using MovieInto.Domain.Constants;
using MovieInto.Domain.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieInfo.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly NpgsqlConnection _connection = new NpgsqlConnection(DatabaseConstants.CONNECTION_STRING);
        public async Task<bool> CreateAsync(User entity)
        {
            try
            {
                await _connection.OpenAsync();
                string query = $"insert into users(first_name, last_name, is_male, " +
                            $"birth_date, email, phone_number, login, password " +
                            $"values('@FirstName', '@LastName', )";
                return false;
            }
            catch
            {

                throw;
            }
            finally
            {
                await _connection.CloseAsync();
            }
        }

        public Task<bool> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> ReadAllAsync(PaginationParams @params)
        {
            throw new NotImplementedException();
        }

        public Task<User> ReadAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(long id, User entity)
        {
            throw new NotImplementedException();
        }
    }
}
