using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallProducersApp.Models;

namespace SmallProducersApp.View
{
    public class ViewProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string Unitsssssssssss { get; set; }

        public ViewProduct(Product prod)
        {
            Id = prod.ProductID;
            Name = prod.Name;
            CategoryName = prod.ProductCategory.CategoryName;
            Unitsssssssssss = prod.UnitType;
        }

        public static List<ViewProduct> GetViewFromList(List<Product> products)
        {
            List<ViewProduct> viewProducts = new List<ViewProduct>();

            foreach (Product prod in products)
            {
                ViewProduct viewProduct = new ViewProduct(prod);
                viewProducts.Add(viewProduct);
            }

            return viewProducts;
        }
    }
}
