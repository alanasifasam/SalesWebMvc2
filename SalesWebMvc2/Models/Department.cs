using System.Collections.Generic;
namespace SalesWebMvc2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();
        
        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
