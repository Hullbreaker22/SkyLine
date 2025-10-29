using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyLine.Models
{
   public enum Cabin
    {
        Economy,
        Comfortable_Economy,
        Business,
        VIP 
    };
    public class Fare
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(flight))]
        public  int flightId { get; set; }
        public Flight? flight { get; set; }
        public Cabin CabinClass { get; set; }
        public double price { get; set; }
        public int MyProperty { get; set; }

    }
}
