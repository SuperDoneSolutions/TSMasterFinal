using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(UserLadderMetadataClass))]

    public partial class UserLadder
    {

    }
    
    public class UserLadderMetadataClass
    {
        [Display(Name = "Position")]    
        public int position { get; set; }

        [Display(Name = "User ID")]
        public int userId { get; set; }

        [Display(Name = "Ladder Type")]
        public int ladderId { get; set; }
    }
}