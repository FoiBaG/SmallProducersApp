using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallProducersApp.Data;

namespace SmallProducersApp.Models
{
    public class ProductCategory
    {
        [Key]
        
        public int CategoryID { get; set; }
        [Required]
        public string CategoryName { get; set; }
        public float Iva {  get; set; }

        public ProductCategory(string Name, float tax)
        {
            this.CategoryName = Name;
            this.Iva = tax;
        }

        public ProductCategory()
        {

        }
        public void Add()
        {
            try
            {
                SmallProducersContext sp = new SmallProducersContext();

                this.CategoryName = FilterCategoryName(this.CategoryName);

                if(this.Iva > 120)
                {
                    throw new Exception("IVa invalido");
                }      

                var x = sp.ProductCategory.Add(this);
                sp.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public static List<ProductCategory> GetAll()
        {
            SmallProducersContext sp = new SmallProducersContext();
            var x = sp.ProductCategory.ToList();
            return x;

        }
        public static ProductCategory Get(int id)
        {
            SmallProducersContext sp = new SmallProducersContext();
            ProductCategory x = sp.ProductCategory.First(c => c.CategoryID == id);
            return x;
        }
        public static List<ProductCategory> Get(string Name)
        {
            SmallProducersContext sp = new SmallProducersContext();
            var x = sp.ProductCategory.Where(c => c.CategoryName == Name).ToList();
            return x;
        }
        public static void Delete(int id)
        {
            ProductCategory cat = Get(id);
            if (cat != null)
            {
                SmallProducersContext sp = new SmallProducersContext();
                var x = sp.ProductCategory.Remove(cat);
                sp.SaveChanges();
            }
        }
        public static void Edit(int id, ProductCategory newdata)
        {
            ProductCategory edit = Get(id);
            if (edit != null)
            {
                edit.CategoryName = newdata.CategoryName;
                edit.Iva = newdata.Iva;
                SmallProducersContext sp = new SmallProducersContext();
                var x = sp.ProductCategory.Update(edit);
                sp.SaveChanges();
            }
        }

        private static string FilterCategoryName (string categoryName)
        {
            categoryName = categoryName.Trim();

            categoryName = char.ToUpper(categoryName[0]) + categoryName.Substring(1).ToLower();

            return categoryName;
        }
    }
}
