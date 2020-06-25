using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using productsncategories.Models;

namespace productsncategories.Controllers
{

    public class HomeController : Controller
    {
        private MyContext _context { get; set; }

        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("category/{categoryID}")]
        public IActionResult categorypage(int categoryID)
        {
            Category cat = _context.categories
                .Include(p => p.productsincategory)
                .ThenInclude(a => a.navproduct)
                .FirstOrDefault(c => c.categoryID == categoryID);
            //Category getcat = _context.categories.FirstOrDefault(c => c.categoryID == categoryID);
            //var catwithprods = _context.categories
            //    .Include(category => category.acats)
            //    .ThenInclude(prod => prod.Product)
            //    .FirstOrDefault(category => category.categoryID == categoryID);

            //ViewBag.categorywithproducts = catwithprods;
            List<Product> allproducts = _context.products.ToList();
            List<Product> someprods = new List<Product>();
            foreach(Association a in cat.productsincategory)
            {
                someprods.Add(a.navproduct);
            }
            ViewBag.AllProducts=_context.products.Except(someprods);
            return View("categorypage", cat);
        }
        [HttpGet("products/{productID}")]
        public IActionResult productpage(int productID)
        {
            Product prod = _context.products
                .Include(c => c.categoriesofproduct)
                .ThenInclude(a => a.navcategory)
                .FirstOrDefault(p => p.productID == productID);
            //ViewBag.thisprod = getprod;
            List<Category> somecats = new List<Category>();
            foreach(Association a in prod.categoriesofproduct)
            {
                somecats.Add(a.navcategory);
            }
            ViewBag.AllCategories=_context.categories.Except(somecats);
            //List<Product> AllProducts=_context.products.Include(c=>c.categoriesofproduct).ThenInclude(c=>c.navproduct).ToList();

    
            //ViewBag.notonproduct = _context.categories
            //    .Include( c => c.productsincategory)
            //    .Where( c => c.productsincategory.All( a => a.productID != productID )).ToList();
            
            return View(prod);
        }
        [HttpGet("products")]
        public IActionResult products()
        {
            List<Product> allproducts = _context.products.ToList();
            ViewBag.allproducts = allproducts;
            return View("products");
        }
        [HttpGet("categories")]
        public IActionResult categories()
        {
            List<Category> allcategories = _context.categories.ToList();
            ViewBag.allcategories = allcategories;
            return View("categories");
        }
        [HttpPost("createcategory")]
        public IActionResult createcategory(Category newcategory)
        {
            _context.categories.Add(newcategory);
            _context.SaveChanges();
        
            return Redirect("categories");
        }
        [HttpPost("createproduct")]
        public IActionResult createproduct(Product newproduct)
        {
            _context.products.Add(newproduct);
            _context.SaveChanges();
        
            return Redirect("products");
        }
        [HttpPost("products/{productID}/add")]
        public IActionResult addtocategory(int categoryId, int productId)
        {
            Association categorized = new Association();
            categorized.productID = productId;
            categorized.categoryID = categoryId;
            _context.Add(categorized);
            _context.SaveChanges();
            return Redirect("/products");


        }
        [HttpPost("category/{categoryID}/add")]
        public IActionResult addproduct(int categoryId, int productId)
        {
            Association addprod= new Association();
            addprod.productID = productId;
            addprod.categoryID = categoryId;
            _context.Add(addprod);
            _context.SaveChanges();
            return Redirect("/categories");


        }
        [HttpGet("delete/{associationID}")]
        public IActionResult remove(int associationID)
        {
            Association todelete = _context.associations
                .FirstOrDefault(t => t.associationID == associationID);
                _context.associations.Remove(todelete);
                _context.SaveChanges();
            return Redirect("/products");

        }

        

        
    }
}
