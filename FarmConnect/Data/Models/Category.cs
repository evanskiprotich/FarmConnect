using System.ComponentModel.DataAnnotations;

namespace FarmConnect.Data.Models
{
    public class Category:MainModel
    {
        public Category() // For Less memory consumption
        {
            this.Products = new HashSet<Product>();
        }

        [Required]
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
