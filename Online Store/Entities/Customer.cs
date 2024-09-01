using Microsoft.Extensions.Hosting;

namespace Online_Store.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; } = new List<Order>();



    }
}
