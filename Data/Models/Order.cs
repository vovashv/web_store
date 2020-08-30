using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace web_store.Data.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }

        public List<OrderDetail> OrderLines { get; set; }

        [Required(ErrorMessage = "Вкажіть ім'я")]
        [Display(Name = "Ім'я")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Вкажіть прізвище")]
        [Display(Name = "Прізвище")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Вкажіть адресу")]
        [StringLength(100)]
        [Display(Name = "Адреса")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Адреса")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Вкажіть поштовий код вашого міста")]
        [Display(Name = "Поштовий код міста")]
        [StringLength(10, MinimumLength = 4)]
        public string ZipCode { get; set; }

        [StringLength(10)]
        [Display(Name = "Місто")]
        [Required(ErrorMessage = "Вкажіть місто доставки")]

        public string State { get; set; }

        [Required(ErrorMessage = "Країна")]
        [Display(Name = "Країна доставки")]
        [StringLength(50)]
        public string Country { get; set; }

        [Required(ErrorMessage = "Вкажіть номкр мобільного телефону (+380*********)")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "Не коректно введено адресу")]
        public string Email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal OrderTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}
