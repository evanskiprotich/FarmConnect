using System.ComponentModel.DataAnnotations;

namespace FarmConnect.Data.Models
{
    public class Product:MainModel
    {
        [Required]
        [MaxLength(60,ErrorMessage = "Max Length should not be more than 60 characters")]
        [MinLength(3, ErrorMessage = "Min Length of Product should be at least 3 characters")]
        public string Name { get; set; }


        [MaxLength(100, ErrorMessage="Max Length should not be more than 100 chacters")] 
        public string Description { get; set; }


        [Required]
        [Range(0, 999999, ErrorMessage ="Can not be 0 and cannot be more than 99999")]
        public decimal Cost { get; set; }


        [Required]
        [Range(0, 999999, ErrorMessage = "Can not be 0 and cannot be more than 99999")]
        public decimal Price { get; set; }


        [Required]
        [Range(0, 10000,ErrorMessage = "not be 0 and cannot be more than 10000")]
        public int Count { get; set; }


        public string ImageURL { get; set; }


        public Guid CategoryId { get; set; }

        public Category Category { get; set; }
    }


}
