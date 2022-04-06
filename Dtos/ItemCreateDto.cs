using System.ComponentModel.DataAnnotations;

namespace Application.Dtos
{
    public record ItemCreateDto
    {
        [Required(ErrorMessage ="Name is required")]
        [MinLength(3, ErrorMessage = "Length is too small")]
        [MaxLength(100, ErrorMessage ="Length is too big")]
        public string Name { get; init; }
        [Required(ErrorMessage ="Price is Required")]
        [Range(1,int.MaxValue,ErrorMessage = "Value must be positive")]
        public decimal Price { get; init; }
    }
}