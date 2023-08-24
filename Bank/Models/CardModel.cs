using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class CardModel
    {
        public int Id { get; set; }

        public string BankName { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CardId { get; set; }

        public Color Colors { get; set; }

        public int red { get; set; }

        public int green { get; set; }

        public int blue { get; set; }
    }
}
