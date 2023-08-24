using Bank.Models;
using Bank.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DbContext
{
    public interface IUserService<T>
    {
        public Task AddUser(T r);

        public Task DeleteUser(T r);

        public Task UpdateUser(T r);

        public Task<List<T>> GetUserList();

        public Task<List<T>> UserId(int id);

        public Task<T> UserEP(string email, string password, int id );
    }
}
