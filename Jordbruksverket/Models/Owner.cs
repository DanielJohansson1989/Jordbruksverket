using System.ComponentModel.DataAnnotations;

namespace Jordbruksverket.Models
{
    public class Owner
    {
        [Key]
        public int OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public IEnumerable<Pet> Pets { get; set; }
    }
}
