using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Models
{
    public class Autinfo
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [Required]
        public int Userid { get; set; }
        [Required]
        public string bank { get; set; }

        [Required]
        public decimal cardid { get; set; }

        public int bankcardid { get; set; }

        [Required]
        public int password { get; set; }

        public double dram { get; set; } = 5000;

        public double rubli { get; set; } = 0;

        public double dolar { get; set; } = 0;

        public double euro { get; set; } = 0;

      
    }
}
