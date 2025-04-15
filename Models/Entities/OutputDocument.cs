using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Theseus.Models.Entities
{
    public class OutputDocument
    {
        [Required]
        public required string Name { get; set; }

        [Required]
        public required Guid Id { get; set; }

        [Required]
        public required string FilePath { get; set; }

        public required IdentityUser Owner { get; set; }
    }
}