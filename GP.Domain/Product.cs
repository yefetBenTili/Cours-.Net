using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Product : Concept
    {
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public Category? MYCategory { get; set; } = null;
        public List<Provider> Providers { get; set; }

        public override void GetDetails()
        {
            Console.WriteLine("Product name: {0},price: {1}",Name,Price);
        }

        public virtual void GetMyType()
        {
            Console.WriteLine("UNKNOWN");
        }
    }
}
