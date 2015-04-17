using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(BuildingMetadataClass))]

    public partial class Building
    {

    }

    public class BuildingMetadataClass
    {
        [Display(Name = "Building ID")]
        public int buildingId { get; set; }

        [Display(Name = "Building Address")]
        public string address { get; set; }

        [Display(Name = "Organization ID")]
        public int organizationId { get; set; }
    }
}