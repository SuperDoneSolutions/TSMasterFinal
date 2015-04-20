using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(AccountTypeMetadataClass))]
    
    public partial class AccountType
    {

    }

    public class AccountTypeMetadataClass
    {
        [Display(Name = "Account ID")]
        public int accountId { get; set; }

        [Display(Name = "Account Type")]
        public string description { get; set; }
    }
}