namespace FarmConnect.Data.Models
{
    public class MainModel
    {
        public MainModel() { 
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; } // Guid is better it prevents from attacks
    }
}
