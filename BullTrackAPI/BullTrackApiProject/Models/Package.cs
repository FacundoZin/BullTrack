using System.ComponentModel.DataAnnotations;
using System.Security.Claims;

namespace CarryOn.Models
{
    public class Package
    {
        [Key] public int Id { get; set; }

        public string Description { get; set; }
        public decimal Weight { get; set; }

        public Address Destination { get; set; }

        public int ShippingRequestId { get; set; }
        public ShippingRequest ShippingRequest { get; set; }

    }
}
