using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class ProductDTO
    {
        [Required]
        [MaxLength(30)]
        public string? ProductName { get; set; }

        [Required]
        public IFormFile? ImageFile { get; set; }


    }
}
