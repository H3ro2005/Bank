using Bank.DbContext;
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
   public enum Bank
        { 
    Name,
    RS,
    RB,
    ES,
    EB,
    DS,
    DB
    }
    public enum checker
    {
        None,
        Asc,Desc
    }

    public class BankVM:prop
    {
        BankData BankData;
        public List<BankModel> Models = new List<BankModel>();
        public ObservableCollection<BankModel> BankDatas { get; set; }
        public checker name = checker.None;
        public checker rs = checker.None;
        public checker rb = checker.None;
        public checker es = checker.None;
        public checker eb = checker.None;
        public checker ds = checker.None;
        public checker db = checker.None;
        public ICommand Sorting { get; private set; }
        public BankVM(BankData json)
        {
          BankData= json;
            BankDatas = new ObservableCollection<BankModel>();        
            List();
            Sorting = new Command(async (object item) => {
                Bank parameter = (Bank)item;
                await Sort(parameter);
                pchange(nameof(BankDatas));
            });
        }


        public async Task Sort(Bank item) 
        {
            Models = BankDatas.ToList();
            BankDatas.Clear();
            switch (item) { 
                case Bank.Name:
                    if (name == checker.None || name == checker.Desc)
                    {
                       Models = Models.OrderBy(x => x.ShortName).ToList();
                        name = checker.Asc;
                    }
                    else if(name == checker.Asc)
                    {
                       Models = Models.OrderByDescending(x => x.ShortName).ToList();
                        name = checker.Desc;
                    }
                    break;
                case Bank.RB:
                    if (rb == checker.None || rb == checker.Desc)
                    {
                       Models = Models.OrderBy(x => x.brubli).ToList();
                        rb = checker.Asc;
                    }
                    else if (rb == checker.Asc)
                    {
                        Models = Models.OrderByDescending(x => x.brubli).ToList();
                        rb = checker.Desc;
                    }
                    break;
                case Bank.RS:
                    if (rs == checker.None || rs == checker.Desc)
                    {
                        Models = Models.OrderBy(x => x.srubli).ToList();
                        rs = checker.Asc;
                    }
                    else if (rs == checker.Asc)
                    {
                        Models = Models.OrderByDescending(x => x.srubli).ToList();
                        rs = checker.Desc;
                    }
                    break;
                case Bank.EB:
                    if (eb == checker.None || eb == checker.Desc)
                    {
                        Models = Models.OrderBy(x => x.beuro).ToList();
                        eb = checker.Asc;
                    }
                    else if (eb == checker.Asc)
                    {
                        Models = Models.OrderByDescending(x => x.beuro).ToList();
                        eb = checker.Desc;
                    }
                    break;
                case Bank.ES:
                    if (es == checker.None || es == checker.Desc)
                    {
                        Models = Models.OrderBy(x => x.seuro).ToList();
                        es = checker.Asc;
                    }
                    else if (es == checker.Asc)
                    {
                       Models = Models.OrderByDescending(x => x.seuro).ToList();
                        es = checker.Desc;
                    }
                    break;
                case Bank.DB:
                    if (db == checker.None || db == checker.Desc)
                    {
                        Models = Models.OrderBy(x => x.bdolar).ToList();
                        db = checker.Asc;
                    }
                    else if (db == checker.Asc)
                    {
                        Models = Models.OrderByDescending(x => x.bdolar).ToList();
                        db = checker.Desc;
                    }
                    break;
                case Bank.DS:
                    if (ds == checker.None || ds == checker.Desc)
                    {
                        Models = Models.OrderBy(x => x.sdolar).ToList();
                        ds = checker.Asc;
                    }
                    else if (ds == checker.Asc)
                    {
                        Models = Models.OrderByDescending(x => x.sdolar).ToList();
                        ds = checker.Desc;
                    }
                    break;
                    
                  
            }
            foreach (var items in Models)
            {
                BankDatas.Add(items);
            }
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
                    BankDatas.Add(gin);

                }
               
            }
            catch (Exception)
            {

            }
        }
    }
}
