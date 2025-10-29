using System.ComponentModel.DataAnnotations;

namespace SkyLine.Models
{
    public class AirPort
    {
        [Required]
        [Key]
        public int Id  { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }

        public int cityId { get; set; }
        public City city { get; set; } 
    }
}
