using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(BookingRuleMetadataClass))]

    public partial class BookingRule
    {

    }
    
    
    public class BookingRuleMetadataClass
    {
        [Display(Name = "Booking Rule ID")]
        public int bookingRuleId { get; set; }

        [Display(Name = "Organization ID")]
        public int organizationID { get; set; }

        [Display(Name = "Days In Advance")]
        public int daysInAdvance { get; set; }

        [Display(Name = "Number of Bookings")]
        public int numOfBookings { get; set; }

        [Display(Name = "Number of Strikes")]
        public int numOfStrikes { get; set; }

        [Display(Name = "Day Start")]
        public System.TimeSpan dayStart { get; set; }

        [Display(Name = "Booking Length")]
        public int bookingLength { get; set; }
    }
}