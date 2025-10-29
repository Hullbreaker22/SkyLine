using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyLine.Models
{
    public class LoyalitySystem
    {
        [Key]
        public int Loyality_Id_PK { get; set; }

        [ForeignKey(nameof(User))]
        public string User_Id_FK { get; set; } = string.Empty;

        public int Points { get; set; }
        public string TierLevel { get; set; } = "Basic";

        public ApplicationUser? User { get; set; }
    }
}
