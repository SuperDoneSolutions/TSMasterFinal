using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using TotalSquashNext.Models;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(UserMatchMetadataClass))]

    public partial class UserMatch
    {

    }
    public class UserMatchMetadataClass
    {
        [Display(Name = "User ID")]
        public int userId { get; set; }

        [Display(Name = "Game ID")]
        public int gameId { get; set; }

        [Display(Name = "Score")]
        public Nullable<int> score { get; set; }
    }
}