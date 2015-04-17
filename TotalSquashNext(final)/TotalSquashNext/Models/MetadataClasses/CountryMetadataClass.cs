using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(CountryMetadataClass))]

    public partial class Country
    {

    }

    public class CountryMetadataClass
    {
        [Display(Name = "Counrty ID")]
        public int countryId { get; set; }

        [Display(Name = "Country Name")]
        public string countryName { get; set; }
    }
}