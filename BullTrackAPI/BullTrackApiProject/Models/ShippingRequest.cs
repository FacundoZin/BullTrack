using System.ComponentModel.DataAnnotations;

namespace CarryOn.Models
{
    public class ShippingRequest
    {
        [Key] public int Id { get; set; }   

        public int SenderId { get; set; }
        public User Sender { get; set; }

        public int ReceiverId { get; set; }
        public User Receiver { get; set; }

        public Address OriginAddress { get; set; }
        public Address DestinationAddress { get; set; }

        public DateTime RequestedDate { get; set; }
        public ICollection<Package> Packages { get; set; }
    }
}
