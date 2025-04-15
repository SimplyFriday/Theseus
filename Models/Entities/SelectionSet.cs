using System.ComponentModel.DataAnnotations;

namespace Theseus.Models.Entities
{
    public class SelectionSet
    {
        [Required]
        public required string Name { get; set; }

        public List<SelectionSetItem> SelectionSetItems { get; set; } = new List<SelectionSetItem>();

    }
}