using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(UserMetadata))]

    public partial class User
    {
    
    }
    public class UserMetaData
    {
        [Display(Name = "User ID")]
        public int id { get; set; }

        [Display(Name = "Username")]
        public string username { get; set; }

        [Display(Name = "Skill ID")]
        public int skillId { get; set; }

        [Display(Name = "Password")]
        public string password { get; set; }

        [Display(Name = "Profile Photo")]
        public string photo { get; set; }

        public Nullable<int> wins { get; set; }
        public Nullable<int> losses { get; set; }
        public Nullable<int> ties { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Street Address")]
        public string streetAddress { get; set; }

        [Display(Name = "City")]
        public string city { get; set; }

        [Display(Name = "Province")]
        public string provinceId { get; set; }

        [Display(Name = "Country")]
        public int countryId { get; set; }

        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }

        [Display(Name = "Email Address")]
        public string emailAddress { get; set; }

        [Display(Name = "Gender")]
        public string gender { get; set; }

        [Display(Name = "Birth Date")]
        public System.DateTime birthDate { get; set; }

        [Display(Name = "Account ID")]
        public int accountId { get; set; }

        [Display(Name = "Locked")]
        public bool locked { get; set; }

        [Display(Name = "Organization")]
        public int organizationId { get; set; }

        [Display(Name = "Postal Code")]
        [RegularExpression(@"[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d", ErrorMessage = "Please enter like: L7N2Y2")]
        public string postalCode { get; set; }

        [Display(Name = "Strike")]
        public Nullable<int> strike { get; set; }
    }
}