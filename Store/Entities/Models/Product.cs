using System.ComponentModel.DataAnnotations;

namespace Entities.Models;

public class Product
{

    public int ProductID { get; set; }
    [Required(ErrorMessage = "ProductName is required.")]
    public String? ProductName { get; set; }
    [Required(ErrorMessage = "Price is required.")]
    public decimal Price { get; set; }

    public String? Summary { get; set; } = String.Empty;

    public String? ImageUrl { get; set; }

    public int? CategoryID { get; set; } // ForeginKey

    public Category? category { get; set; } // Navigation property
}
