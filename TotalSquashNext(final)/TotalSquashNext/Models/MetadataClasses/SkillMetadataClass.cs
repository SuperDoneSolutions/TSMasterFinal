using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TotalSquashNext.Models
{
    [MetadataType(typeof(SkillMetadataClass))]

    public partial class Skill
    {

    }
    public class SkillMetadataClass
    {
        [Display(Name = "Skill Id")]
        public int skillId { get; set; }

        [Display(Name = "Skill Level")]
        public string description { get; set; }
    }
}