using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace CarryOn.Models
{
    [Owned]
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string ZipCode { get; set; }
    }
}
