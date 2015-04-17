using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(OrganizationMetadataClass))]

    public partial class Organization
    {

    }

    public class OrganizationMetadataClass
    {
        [Display(Name = "Organization Type")]
        public int organizationId { get; set; }

        [Display(Name = "Organization Name")]
        public string orgName { get; set; }

        [Display(Name = "Organization Address")]
        public string orgAddress { get; set; }

        [Display(Name = "Organization City")]
        public string orgCity { get; set; }

        [Display(Name = "Organization Phone Number")]
        public string orgPhoneNumber { get; set; }
    }
}