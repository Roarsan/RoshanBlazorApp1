using System.ComponentModel.DataAnnotations;

namespace RoshanBlazorApp1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required,StringLength(30)]

        public string ShoeName { get; set; } = string.Empty;
        [Required, StringLength(255)]
        public string Colour { get; set; } = string.Empty;
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int Size { get; set; }
        [Required, StringLength(30)]
        public string Material { get; set; } = string.Empty;

        [Range(0,6)]
        public int Type { get; set; } = 0;
        [Required]
        public decimal DiscountedPrice { get; set; }
        [StringLength(30)]
        public string ImageURL { get; set; } = string.Empty;    

    }
}
