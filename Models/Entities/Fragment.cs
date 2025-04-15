using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Theseus.Models.Entities
{
    public class Fragment
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        public required string FragmentPath { get; set; }

        public List<CombinationRule> combinationRules { get; set; } = new List<CombinationRule>();
    }
}