using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(MatchMetadataClass))]

    public partial class Match
    {

    }
    
    public class MatchMetadataClass
    {
        [Display(Name = "Match Type")]
        public int matchId { get; set; }

        [Display(Name = "Booking Number")]
        public int bookingNumber { get; set; }
    }
}