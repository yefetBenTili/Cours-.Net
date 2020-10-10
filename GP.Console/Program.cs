using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GP.Domain;
using GP.Data;

namespace GP.Console
{
  class Program
  {
    static void Main(string[] args)
    {
      /*Provider P1 = new Provider { Password = "123", ConfirmPassword = "123" };
      System.Console.WriteLine(P1.IsApproved);
      //Provider.SetIsApproved(P1);
      //Provider.SetIsApproved(P1.Password, P1.ConfirmPassword, P1.IsApproved);
      //System.Console.WriteLine(P1.IsApproved);

      string password = "123";
      string confirmPassword = "123";
      bool isApproved = false;
      Provider.SetIsApproved(password, confirmPassword, ref isApproved);
      System.Console.WriteLine(isApproved);
      System.Console.ReadLine();*/

      Category CAT1 = new Category { Name = "Category1" };
      Category CAT2 = new Category { Name = "Category2" };
      Category CAT3 = new Category { Name = "Category3" };

      Product PROD1 = new Product() { Name = "Product1", MYCategory = CAT1, DateProd = new DateTime(2020, 12, 12) };
      Product PROD2 = new Product() { Name = "Product2", MYCategory = CAT1, DateProd = new DateTime(2019, 9, 12) };
      Product PROD3 = new Biological() { Name = "Product3", MYCategory = CAT3, DateProd = new DateTime(2020, 10, 1) };
      Product PROD4 = new Product() { Name = "Product4", DateProd = new DateTime(2019, 6, 30) };
      Product PROD5 = new Chemical() { Name = "Prodcut5", MYCategory = CAT2, DateProd = new DateTime(2020, 11, 5) };
      Product PROD6 = new Product() { Name = "Prodcut6", MYCategory = CAT3, DateProd = new DateTime(2020, 15, 22) };

      Provider PROV1 = new Provider { UserName = "Provider1", Password = "0000", ConfirmPassword = "12345", Email = "Provider1@mail" };
      PROV1.Products.Add(PROD1);
      PROV1.Products.Add(PROD2);
      PROV1.Products.Add(PROD3);
      Provider PROV2 = new Provider { UserName = "Provider2", Password = "0001", ConfirmPassword = "12345", Email = "Provider2@mail" };
      PROV2.Products.Add(PROD1);
      PROV2.Products.Add(PROD5);
      Provider PROV3 = new Provider { UserName = "Provider3", Password = "0011", ConfirmPassword = "12345", Email = "Provider3@mail" };
      PROV3.Products.Add(PROD1);
      PROV3.Products.Add(PROD4);
      Provider PROV4 = new Provider { UserName = "Provider4", Password = "01111", ConfirmPassword = "12345", Email = "Provider4@mail" };
      PROV4.Products.Add(PROD6);
      PROV4.Products.Add(PROD4);
      Provider PROV5 = new Provider { UserName = "Provider", Password = "11111", ConfirmPassword = "12345", Email = "Provider5@mail" };
      PROV5.Products.Add(PROD6);
      PROV5.Products.Add(PROD4);


      PROV1.GetProducts("Name", "Provider2");
      System.Console.WriteLine();
      PROV1.GetProducts("DateProd", "2020/12/12");
      System.Console.ReadLine();

      /*Product Prod = new Product()
      {
          Name = "Product1",
          DateProd = DateTime.Now
      };

      MyDBContext context = new MyDBContext();

      context.addProduct(Prod);*/
    }
  }
}
