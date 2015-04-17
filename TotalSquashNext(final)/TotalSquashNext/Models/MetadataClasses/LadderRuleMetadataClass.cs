using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(LadderRuleMetadataClass))]

    public partial class LadderRule
    {

    }


    public class LadderRuleMetadataClass
    {
        [Display(Name = "Ladder Rule Type")]
        public int LadderRuleId { get; set; }

        [Display(Name = "Challenge Range")]
        public int challengeRange { get; set; }

        [Display(Name = "Challenge Lower")]
        public bool challengeLower { get; set; }

        [Display(Name = "Number of Ladders")]
        public int numLadders { get; set; }
    }
}