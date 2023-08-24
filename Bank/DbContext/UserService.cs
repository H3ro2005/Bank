using Bank.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DbContext
{
    public class UserService : IUserService<RegisterModel>
    {
        private SQLiteAsyncConnection _dbcontext;

        public UserService()
        {
            SetUpDb();
        }

        public async Task AddUser(RegisterModel r)
        {
           await _dbcontext.InsertAsync(r);
        }

        public async Task DeleteUser(RegisterModel r)
        {
            await _dbcontext.DeleteAsync(r);
        }

        public async Task UpdateUser(RegisterModel r)
        {
           await _dbcontext.UpdateAsync(r);
        }

        public async Task<List<RegisterModel>> GetUserList()
        {
            var userList = await _dbcontext.Table<RegisterModel>().ToListAsync();
            return userList;
        }

        public  Task<List<RegisterModel>> UserId(int id)
        {
            throw new Exception();
            
        }
        public async Task<RegisterModel> UserEP(string email,string password,int id)
        {
            if (id > 0)
            {
                var user = await _dbcontext.Table<RegisterModel>().FirstOrDefaultAsync(x => x.Id == id);
                return user;
            }
            else
            {
                var user = await _dbcontext.Table<RegisterModel>().FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
                return user;
            }
           
        }



        private async void SetUpDb()
        {
            if (_dbcontext == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyUser.db3");
                _dbcontext = new SQLiteAsyncConnection(dbPath);
                await _dbcontext.CreateTableAsync<RegisterModel>();
               
               
            }
        }

   
    }
}
