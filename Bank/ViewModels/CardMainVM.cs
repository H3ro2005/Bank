
using Bank.Models;
using Bank.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Bank.ViewModels
{
    public class CardMainVM:prop
    {
        public ICommand Search { get; protected set; }
        public ICommand CardNav { get; set; }
        public ObservableCollection<BankModel> BankDatas { get; set; }
        public BankData BankData;
        public CardMainVM(BankData json)
        {
            BankData = json;
            Search = new Command<string>(async(string query) =>
              {
                  BankDatas.Clear();
                  foreach (var item in await BankData.find(query))
                  {
                      BankDatas.Add(item);
                  } 
                 
              });
        CardNav = new Command(async (object parameter) => { await cards(parameter); });
        BankDatas = new ObservableCollection<BankModel>();
            List();
            
        }

        public async Task List()
        {

            try
            {
                var gner = await BankData.GetMainList();

                if (BankDatas.Count != 0)
                {
                    BankDatas.Clear();
                }
                foreach (var gin in gner)
                {
                    gin.colors = Color.FromRgb(gin.red, gin.green, gin.blue);
                    BankDatas.Add(gin);
                }
            }
            catch (Exception)
            {
            }
        }
        public async Task cards(object id)
        {
            
        }
    }
}
