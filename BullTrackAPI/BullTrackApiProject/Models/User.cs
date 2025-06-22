using BullTrackAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarryOn.Models
{
    public abstract class User
    {
        [Key] public int Id { get; set; }

        [Required] public string Name { get; set; }

        [Required] public string Email { get; set; }

        [Required] public string PhoneNumber { get; set; }

        public DateOnly RegisterDate { get; set; }

        public AuthProvider AuthProvider { get; set; } = AuthProvider.Google;
    }
}
