
using BullTrackAPI.Enums;

namespace CarryOn.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public int PackageId { get; set; }
        public Package Package { get; set; }

        public int UserId { get; set; } // quien hace el reclamo
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public ClaimStatus Status { get; set; }
    }
}
