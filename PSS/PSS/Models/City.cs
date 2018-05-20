using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Models
{
    [Table("Cities")]
    public class City : Base
    {
        [Required][MaxLength(DescriptionMaxLength)]
        public string Name { get; set; }

        [Required]
        public int StateId { get; set; }

        public State State { get; set; }

    }
}