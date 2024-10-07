using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Jordbruksverket.Models
{
    public class Pet
    {
        [Key]
        public int ChipId { get; set; }
        public DateTime DateOfChip { get; set; }
        public string ChipLoc { get; set; }
        public string PetName { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Color { get; set; }
        public int OwnerId { get; set; }
        [JsonIgnore]
        public Owner Owner { get; set; }
    }
}
