using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bank.Services
{
    public class CardData
    {
        List<CardModel> CardList = new();

        public async Task<List<CardModel>> GetMainList()
        {
            if (CardList?.Count > 0)
                return CardList;

            var stream = await FileSystem.Current.OpenAppPackageFileAsync("Gin.json");
            var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            CardList = JsonSerializer.Deserialize<List<CardModel>>(contents);

            return CardList;
        }
    }
}
