using Bank.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.DbContext
{
    public class BankService : IUserService<Autinfo>
    {
      
            private SQLiteAsyncConnection _dbcontext;

            public BankService()
            {
                SetUpDb();
            }

            public async Task AddUser(Autinfo r)
            {
                await _dbcontext.InsertAsync(r);
            }

            public async Task DeleteUser(Autinfo r)
            {
                await _dbcontext.DeleteAsync(r);
            }

            public async Task UpdateUser(Autinfo r)
            {

                await _dbcontext.UpdateAsync(r);
            }

            public async Task<List<Autinfo>> GetUserList()
            {
                var userList = await _dbcontext.Table<Autinfo>().ToListAsync();
                return userList;
            }

            public async Task<List<Autinfo>> UserId(int id)
            {
                var cards = await _dbcontext.Table<Autinfo>().Where(x => x.Userid == id).ToListAsync();
                return cards;
            }
            public async Task<Autinfo> UserEP(string email, string password,int id)
            {
            throw new Exception();
            }



            private async void SetUpDb()
            {
                if (_dbcontext == null)
                {
                    string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "MyUser.db3");
                    _dbcontext = new SQLiteAsyncConnection(dbPath);
                    await _dbcontext.CreateTableAsync<Autinfo>();


                }
            }


        
    }
}
