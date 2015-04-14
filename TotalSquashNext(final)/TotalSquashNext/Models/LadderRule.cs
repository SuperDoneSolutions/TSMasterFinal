//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TotalSquashNext.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class LadderRule
    {
        public LadderRule()
        {
            this.Ladders = new HashSet<Ladder>();
        }
        [Display(Name = "Ladder Rules")]
        public int LadderRuleId { get; set; }
        [Display(Name = "Challenge Range")]
        public int challengeRange { get; set; }
        [Display(Name = "Challenge Lower")]
        public bool challengeLower { get; set; }
        [Display(Name = "Number of Ladders")]
        public int numLadders { get; set; }
    
        public virtual ICollection<Ladder> Ladders { get; set; }
    }
}
