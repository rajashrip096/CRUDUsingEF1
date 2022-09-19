using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDUsingEF1.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "name is requird")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "companyname is requird")]
        public string? CompanyName { get; set; }
        [Required(ErrorMessage = "price is requird")]
        public int Price { get; set; }
    }
}
