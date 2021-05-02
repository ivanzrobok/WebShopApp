using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Models
{
    public class OrderDetail
    {
        public int ID { get; set; }
        public int OlderID { get; set; }//id заказа
        public int CarID { get; set; }//індифікатор товару який купуємо
        public int Prise { get; set; }
       
        //для бази даних
        public virtual Order order { get; set; }
        public virtual Car car { get; set; }
    }
}
