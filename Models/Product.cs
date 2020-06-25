using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace productsncategories.Models
{
    public class Product
    {
        [Key]
        public int productID {get;set;}

        public string productname {get;set;}

        public decimal price {get;set;}

        public List<Association> categoriesofproduct {get;set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

    }
}
