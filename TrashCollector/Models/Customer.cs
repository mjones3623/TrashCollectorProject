using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCoded { get; set; }
        public string PhoneNumber { get; set; }
        public string PickupDay { get; set; }
        public DateTime OneTimePickUpDate { get; set; }
        public int Balance { get; set; }
        public DateTime TempSuspendStart { get; set; }
        public DateTime TempSuspendEnd { get; set; }
        public int PriceForPickup { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }
    }
}
