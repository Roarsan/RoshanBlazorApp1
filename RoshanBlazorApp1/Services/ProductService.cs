using RoshanBlazorApp1.Models;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace RoshanBlazorApp1.Services
{
    public class ProductService
    {
        public static List<Product> ProductList = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                ShoeName="Adidas Waffle",
                Colour ="Black",
                Price= 30,
                Size= 9,
                Type= 1,
                Material="COTTON",
                DiscountedPrice = 20,
                ImageURL= "IMG.PNG"

            }
            
        }
    }
}
