using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;

namespace GP.Data
{
    public class MyDBContext : DbContext
    {
        public DbSet<Biological> Biologicals { get; set; }
        public DbSet<Chemical> Chemicals { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Category> Categories { get; set; }

        public MyDBContext() : base("name=MaChaine")
        {

        }

        public void addProduct(Product P)
        {
            Products.Add(P);
            SaveChanges(); // Pour ajouter à la base de données
        }
    }
}
