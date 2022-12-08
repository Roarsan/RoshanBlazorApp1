using Microsoft.EntityFrameworkCore;
using RoshanBlazorApp1.Models;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace RoshanBlazorApp1.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>()
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
                DiscountedPrice = 25,
                ImageURL= "IMG.PNG"

            },
                new Product()
            {
                Id = 2,
                ShoeName="Adidas Gazelle",
                Colour ="Brown",
                Price= 25,
                Size= 7,
                Type= 1,
                Material="COTTON",
                DiscountedPrice = 20,
                ImageURL= "IMG.PNG"

            },
                    new Product()
            {
                Id = 3,
                ShoeName="Adidas Yeezys",
                Colour ="White",
                Price= 45,
                Size= 10,
                Type= 1,
                Material="COTTON",
                DiscountedPrice = 40,
                ImageURL= "IMG.PNG"

            },
                        new Product()
            {
                Id = 4,
                ShoeName="Adidas Galaxy",
                Colour ="Grey",
                Price= 50,
                Size= 8,
                Type= 1,
                Material="COTTON",
                DiscountedPrice = 45,
                ImageURL= "IMG.PNG"

            }

        };
       

        public static List<Product> GetProducts() 
        {
            return Products.ToList(); }


    }
}


