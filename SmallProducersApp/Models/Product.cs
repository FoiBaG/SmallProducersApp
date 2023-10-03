using SmallProducersApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SmallProducersApp.Models
{
    public  class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        public int ProductNumber { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string UnitType { get; set; }

        [Required]
        public int CategoryID { get; set; } // Foreign key to ProductCategory

        [ForeignKey("CategoryID")] // This specifies the foreign key relationship
        public ProductCategory ProductCategory { get; set; }

        public Product()
        {

        }

        public void Add()
        {
            try
            {
                SmallProducersContext sp = new SmallProducersContext();

                //this.ProductID = null;

                var x = sp.Product.Add(this);
                sp.SaveChanges();
            }
            catch(Exception ex)
            {

                throw ex;
            }

        }
        public static List<Product> GetAll()
        {
            SmallProducersContext sp = new SmallProducersContext();
            var x = sp.Product.Include(p => p.ProductCategory).ToList();
            //var x = sp.Product.ToList();
            return x;

        }
        public static Product Get(int id)
        {
            SmallProducersContext sp = new SmallProducersContext();
            Product x = sp.Product.First(c => c.ProductID == id);
            return x;
        }
        public static List<Product> Get(string name)
        {
            SmallProducersContext sp = new SmallProducersContext();
            var x = sp.Product.Where(c => c.Name == name).ToList();
            return x;
        }
        public static void Delete(int id)
        {
            Product cat = Get(id);
            if (cat != null)
            {
                SmallProducersContext sp = new SmallProducersContext();
                var x = sp.Product.Remove(cat);
                sp.SaveChanges();
            }
        }
        public static void Edit(int id, Product newdata)
        {
            Product edit = Get(id);
            if (edit != null)
            {
                edit.Name = newdata.Name;
                edit.CategoryID = newdata.CategoryID;

                SmallProducersContext sp = new SmallProducersContext();
                var x = sp.Product.Update(edit);
                sp.SaveChanges();
            }
            else
            {
                throw new Exception("O produto com o id " + id.ToString() + " não foi encontrado na base de dados.");
            }
        }

    }
}
