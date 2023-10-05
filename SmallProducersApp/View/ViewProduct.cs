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
        public string ProductName { get; set; }
        public string CategoryID { get; set; }
        public string UnitType { get; set; }

        public ViewProduct(Product prod)
        {
            Id = prod.ProductNumber;
            ProductName = prod.Name;
            CategoryID = prod.ProductCategory.CategoryName;
            UnitType = prod.UnitType.UnitTypeName;
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
