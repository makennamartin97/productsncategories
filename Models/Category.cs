using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace productsncategories.Models
{
    public class Category
    {
        [Key]
        public int categoryID {get;set;}
        
        public string categoryname {get;set;}

        public List<Association> productsincategory {get;set;}
        //public List<Product> productsincategory {get;set;}

        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

    }
}