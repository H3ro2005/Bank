using Bank.DbContext;
using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bank.ViewModels
{
    public class UseCardVM:prop
    {
      
        private readonly IUserService<Autinfo> service;
        public ICommand Checker { get; protected set; }
        private decimal cardid;
        public string CardId
        {
            get { return Convert.ToString(cardid); }
            set
            {
                try
                {
                    if (cardid != Convert.ToDecimal(value))
                    {
                        cardid = Convert.ToDecimal(value); pchange(nameof(CardId));
                    }
                }
                catch(Exception) {
                    

                }

            }
        }
        private int cardpassword;
        public string CardPassword
        {
            get { return Convert.ToString(cardpassword); }
            set
            {
                try
                {
                    if (cardpassword != Convert.ToInt32(value))
                    {
                        cardpassword = Convert.ToInt32(value); pchange(nameof(CardPassword));
                    }
                }
                catch(Exception)
                {

                }
                

            }
        }
        public int id { get; set; }
        public UseCardVM(IUserService<Autinfo> service)
        {
            this.service = service;
            Checker = new Command(async () => { await Check(); });
            id = Preferences.Default.Get<int>("id", 0);
        }
        public async Task Check()
        {
           var database = await service.GetUserList();
            Autinfo autinfo = database.FirstOrDefault(x => x.password == cardpassword && x.cardid == cardid);
            if (autinfo != null)
            {
                autinfo.bankcardid = id;
                await service.UpdateUser(autinfo);
            }
        }
    }
}
