using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(BookingTypeMetadataClass))]

    public partial class BookingType
    {

    }
    
    public class BookingTypeMetadataClass
    {
        [Display(Name = "Booking Code")]
        public int bookingCode { get; set; }

        [Display(Name = "Description")]
        public string description { get; set; }
    }
}