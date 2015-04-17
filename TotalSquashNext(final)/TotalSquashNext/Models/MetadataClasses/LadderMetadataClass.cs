using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(LadderMetadataClass))]

    public partial class Ladder
    {

    }
    
    public class LadderMetadataClass
    {
        [Display(Name = "Ladder Type")]
        public int ladderId { get; set; }

        [Display(Name = "Ladder Description")]
        public string ladderDescription { get; set; }

        [Display(Name = "Ladder Rule ID")]
        public int ladderRuleId { get; set; }
    }
}