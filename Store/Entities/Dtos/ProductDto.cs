using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductID { get; init; }
        [Required(ErrorMessage = "ProductName is required.")]
        public String? ProductName { get; init; }
        [Required(ErrorMessage = "Price is required.")]
        public decimal Price { get; init; }

        public int? CategoryID { get; init; }


    }
}