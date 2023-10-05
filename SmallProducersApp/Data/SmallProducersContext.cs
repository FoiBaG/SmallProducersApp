
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using SmallProducersApp.Models;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace SmallProducersApp.Data
{
    public class SmallProducersContext : DbContext
    {
        public SmallProducersContext()
        {

        }
        public SmallProducersContext(DbContextOptions<SmallProducersContext> options) : base(options)
        {
        }

        public DbSet<Models.ProductCategory> ProductCategory { get; set; }
        public DbSet<Models.Product> Product { get; set; }
        public DbSet<Models.UnitType> UnitType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            // Get the connection string from the App.config file.
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionStringName"].ConnectionString;

            optionsBuilder.UseSqlServer(@connectionString);
        }

        
    }
}
