using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(ProvinceMetadataClass))]

    public partial class Province
    {

    }

    public class ProvinceMetadataClass
    {
        [Display(Name = "Province ID")]
        public string provinceId { get; set; }

        [Display(Name = "Province")]
        public string provinceName { get; set; }

        [Display(Name = "Country ID")]
        public int countryId { get; set; }
    }
}