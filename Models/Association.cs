using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace productsncategories.Models
{
    public class Association
    {
        [Key]
        public int associationID {get;set;}
        public int productID {get;set;}
        public int categoryID {get;set;}
        public Product navproduct {get;set;}
        public Category navcategory {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}