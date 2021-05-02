using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Models
{
    public class ShopCarItem
    {
        public int ID { get; set; }
        public Car Car { get; set; }
        public int Prise { get; set; }
        public string ShopCarID { get; set; }
    }
}
