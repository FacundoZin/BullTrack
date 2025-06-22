using BullTrackAPI.Enums;
using CarryOn.Models;

namespace BullTrackAPI.Models
{
    public class TripPackage
    {
        public int TripId { get; set; }
        public Trip Trip { get; set; }

        public int PackageId { get; set; }
        public Package Package { get; set; }

        public ShippingStatus DeliveryStatus { get; set; } = ShippingStatus.pending;
    }
}
