using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategotyName { get; set; }    
        public string Description { get; set; }
        public List<Car> Cars { get; set; }
    }
}
