using System.ComponentModel.DataAnnotations;

namespace ViewsAndControllers.Models
{
    public class ConversionModel
    {
        [Required]
        public string? From { get; set; }
        [Required]
        public string? To { get; set; }
        [Required]
        public double Amount { get; set; }
        public double Result { get; set; }
    }
}
