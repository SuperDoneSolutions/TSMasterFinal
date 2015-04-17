using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(CourtMetadataClass))]

    public partial class Court
    {

    }
    
    public class CourtMetadataClass
    {
        [Display(Name = "Court ID")]
        public int courtId { get; set; }

        [Display(Name = "Court Description")]
        public string courtDescription { get; set; }

        [Display(Name = "Court Image")]
        public string courtImage { get; set; }

        [Display(Name = "Doubles Court")]
        public bool doublesCourt { get; set; }

        [Display(Name = "Building ID")]
        public int buildingId { get; set; }
    }
}