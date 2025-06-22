using CarryOn.Models;

namespace BullTrackAPI.Models
{
    public class Client
    {
        public ICollection<ShippingRequest> PendingShipments { get; set; } 
    }
}
