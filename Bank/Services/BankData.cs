using Bank.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class BankData
    {
       
            List<BankModel> BankList = new();
        ObservableCollection<BankModel> BankCollection = new();

            public async Task<List<BankModel>> GetMainList()
            {
                if (BankList?.Count > 0)
                    return BankList;

                var stream = await FileSystem.Current.OpenAppPackageFileAsync("Gner.json");
                var reader = new StreamReader(stream);
                var contents = await reader.ReadToEndAsync();
                BankList = JsonSerializer.Deserialize<List<BankModel>>(contents);

                return BankList;
            }

        public async Task<ObservableCollection<BankModel>> find(string id)
        {
            if (BankCollection.Count != 0)
            {
                BankCollection.Clear();
            }
            foreach (var item in BankList)
            {
                if (item.Name.ToLower().StartsWith(id.ToLower()))
                {
                    BankCollection.Add(item);
                }
            }
            return BankCollection;
        }
        
    }
}
