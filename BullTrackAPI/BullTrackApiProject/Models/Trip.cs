using BullTrackAPI.Enums;
using CarryOn.Models;

namespace BullTrackAPI.Models
{
    public class Trip
    {
        public int Id { get; set; }

        public int CarrierId { get; set; }
        public Carrier Carrier { get; set; }

        public DateTime StartDate { get; set; }       // Cuando el viaje comienza (1° retiro)
        public DateTime? EndDate { get; set; }        // Cuando el viaje termina (última entrega)

        public TripStatus Status { get; set; }

        public ICollection<TripPackage> TripPackages { get; set; }
    }
}
