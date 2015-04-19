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
        [Required]
        public int id { get; set; }

        [Display(Name = "Username")]
        [RegularExpression(@"^[a-zA-z0-9]*$", ErrorMessage="Sorry, your username can only contain letters and numbers, no special characters.")]
        [Required]
        public string username { get; set; }

        [Display(Name = "Skill Level")]
        [Required]
        public int skillId { get; set; }

        [Display(Name = "Password")]
        [Required]
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
        [Required]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string lastName { get; set; }

        [Display(Name = "Street Address")]
        [Required]
        public string streetAddress { get; set; }

        [Display(Name = "City")]
        [Required]
        public string city { get; set; }

        [Display(Name = "Province")]
        [Required]
        public string provinceId { get; set; }

        [Display(Name = "Country")]
        [Required]
        public int countryId { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        public string phoneNumber { get; set; }

        [Display(Name = "Email Address")]
        [Required]
        public string emailAddress { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public string gender { get; set; }

        [Display(Name = "Birth Date")]
        [Required]
        public System.DateTime birthDate { get; set; }

        [Display(Name = "Account Type")]
        [Required]
        public int accountId { get; set; }

        [Display(Name = "Locked")]
        public bool locked { get; set; }

        [Display(Name = "Organization")]
        [Required]
        public int organizationId { get; set; }

        [Display(Name = "Postal Code")]
        [RegularExpression(@"[A-Za-z]\d[A-Za-z] ?\d[A-Za-z]\d", ErrorMessage = "Please enter in the form: L7N2Y2")]
        [Required]
        public string postalCode { get; set; }

        [Display(Name = "Strike")]

        public Nullable<int> strike { get; set; }
    }
}