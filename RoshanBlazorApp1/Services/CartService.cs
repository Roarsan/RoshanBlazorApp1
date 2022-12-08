using RoshanBlazorApp1.Models;

namespace RoshanBlazorApp1.Services
{
    public  class CartService
    {
        public List<Product> SelectedItems { get; set; } = new List<Product>();

        public void AddProductToCart(int Id)
        {
            var product = ProductService.Products.First(product => product.Id == Id);

            if(SelectedItems.Contains(product)is false)
            {
                SelectedItems.Add(product);
            }

        }

        public void AddProductToCart(Product product)
        {
            if (SelectedItems.Contains(product) is false)
            {
                SelectedItems.Add(product);
            }
        }
    }
}
