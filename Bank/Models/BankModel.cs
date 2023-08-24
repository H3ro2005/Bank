using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class BankModel
    {
        public int Id { get; set; }

        public Color colors { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public string Icon { get; set; }
        
        public int red { get; set; }

        public int green { get; set; }

        public int blue { get; set; }

        public decimal brubli { get; set; }

        public decimal bdolar { get; set; }

        public decimal beuro { get; set; }

        public decimal srubli { get; set; }

        public decimal sdolar { get; set; } 

        public decimal seuro { get; set; }
    }
}
