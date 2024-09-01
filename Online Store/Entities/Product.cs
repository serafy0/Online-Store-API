using System.ComponentModel.DataAnnotations;

namespace Online_Store.Entities
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Price { get; set; }

        public int Quantity { get; set; }
        public ICollection<Order>? Orders { get; set; } = new List<Order>();



    }
}
