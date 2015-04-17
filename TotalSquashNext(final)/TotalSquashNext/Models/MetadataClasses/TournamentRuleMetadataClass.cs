using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(TournamentRuleMetadataClass))]

    public partial class TournamentRule
    {

    }
    
    public class TournamentRuleMetadataClass
    {
        [Display(Name = "Tournament Rule ID")]
        public int tournamentRuleId { get; set; }

        [Display(Name = "Placeholder")]
        public string placeholder { get; set; }
    }
}