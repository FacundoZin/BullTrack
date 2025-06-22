using BullTrackAPI.Enums;
using System.ComponentModel.DataAnnotations;

namespace CarryOn.Models
{
    public class Carrier : User
    {
        [Required] public string Dni { get; set; }

        public byte[]? DniFrontPhoto { get; set; }
        public byte[]? SelfiePhoto { get; set; }

        [Required] public string VehiclePlate { get; set; } public string VehicleModel { get; set; }

        public byte[]? VehiclePhoto { get; set; }

        public bool IsVerified { get; set; } = false;

        public VerificationStatus VerificationStatus { get; set; } = VerificationStatus.Pending;

        public ICollection<Shipment> Shipments { get; set; }
    }
}
