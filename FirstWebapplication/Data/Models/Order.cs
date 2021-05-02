using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWebapplication.Data.Models
{
    public class Order
    {
        [BindNever]
        public int ID { get; set; }

        [Display(Name ="Введіть ім'я")]
        [StringLength(maximumLength:20,MinimumLength = 2)]
        [Required(ErrorMessage = "Дожина не більше 20 символів, та не менше 2")]
        public string Name { get; set; }

        [Display(Name = "Введіть Фамілію")]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        [Required(ErrorMessage = "Дожина не більше 20 символів, та не менше 2")]
        public string Surname { get; set; }

        [Display(Name = "Введіть адресу")]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        [Required(ErrorMessage = "Дожина не більше 20 символів, та не менше 2")]
        public string Adress { get; set; }

        [Display(Name = "Введіть номер телефону")]
        [StringLength(maximumLength:15, MinimumLength =10)]
        [Required(ErrorMessage = "Неправильний формат телефону")]
        public string Phone { get; set; }


        [Display(Name = "Введіть Email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        [Required(ErrorMessage = "Дожина не більше 20 символів, та не менше 2")]
        public string Email { get; set; }



        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }
        public List<OrderDetail> orderDetails{get;set;}
    }
}
