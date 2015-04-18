using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TotalSquashNext.Models;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(UserMetadataClass))]

    public partial class User
    {

    }
    public class UserMetadataClass
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
        
        [Display(Name = "Wins")]
        public Nullable<int> wins { get; set; }

        [Display(Name = "Losses")]
        public Nullable<int> losses { get; set; }

        [Display(Name = "Ties")]
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
        [RegularExpression(@"[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d", ErrorMessage = "Please enter in the form: L7N2Y2")]
        public string postalCode { get; set; }

        [Display(Name = "Strike")]
        public Nullable<int> strike { get; set; }
    }
}