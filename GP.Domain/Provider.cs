using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GP.Domain
{
    public class Provider : Concept
    {
        private string confirmPassword;
        public string ConfirmPassword
        {
            get
            {
                return confirmPassword;
            }
            set
            {
                if (value.Equals(password))
                    confirmPassword = value;
                else
                    Console.WriteLine("Error the confirmPassword and password need to be identical");
            }
        }
        public DateTime DateCreated { get; set; }
        public string Email { get; set; }
        public int Id { get; set; }
        public bool IsApproved { get; set; } = false;
        private string password;
        public string Password {
            get
            {
                return password;
            }
            set
            {
                if (value.Length >= 5 && value.Length <= 20)
                    password = value;
                else
                    Console.WriteLine("Error the password needs to be between 5 and 20");
            }
        }
        public string UserName { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public override void GetDetails()
        {
            Console.WriteLine("Provider email: {0}, Products:", Email);
            foreach (Product p in Products)
                p.GetDetails();
        }

        public static void SetIsApproved(Provider P)
        {
            P.IsApproved = P.Password == P.ConfirmPassword;
        }

        public static void SetIsApproved(string password, string confirmPassword, ref bool isApproved)
        {
            isApproved = password == confirmPassword;
        }

        public bool Login(string username, string password, string? email = null)
        {
            if (UserName.Equals(username) && Password.Equals(password) && (email is null || Email.Equals(email)))
                return true;
            return false;
        }

        public void GetProducts(string filterType, string filterValue)
        {
            foreach (Product p in Products)
            {
                if(filterType=="DateProd" && p.DateProd.Equals(Convert.ToDateTime(filterValue)))
                {
                    p.GetDetails();
                }
                else if (filterType == "Price" && p.Price.Equals(Convert.ToDouble(filterValue)))
                {
                    p.GetDetails();
                }
                else if (filterType == "ProductId" && p.ProductId.Equals(Convert.ToInt32(filterValue)))
                {
                    p.GetDetails();
                }
                else if (filterType == "Quantity" && p.Quantity.Equals(Convert.ToInt32(filterValue)))
                {
                    p.GetDetails();
                }
                else if (filterType == "Description" && p.Description.Equals(filterValue))
                {
                    p.GetDetails();
                }
                else if (p.Name.Equals(filterValue))
                {
                    p.GetDetails();
                }
                
            }
        }
    }
}
