using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(BookingMetadataClass))]

  public partial class Booking
  {

  }
  
    public class BookingMetadataClass
    {
        [Display(Name = "Court ID")]
        public int courtId { get; set; }

        [Display(Name = "Booking Number")]
        public int bookingNumber { get; set; }

        [Display(Name = "Booking Date")]
        public System.DateTime bookingDate { get; set; }

        [Display(Name = "Booking Code")]
        public int bookingCode { get; set; }

        [Display(Name = "User ID")]
        public int userId { get; set; }

        [Display(Name = "Date")]
        public System.DateTime date { get; set; }

        [Display(Name = "Booking Rules ID")]
        public int bookingRulesId { get; set; }

        [Display(Name = "Building ID")]
        public int buildingId { get; set; }

        [Display(Name = "Checked In")]
        public Nullable<bool> checkedIn { get; set; }
    }
}