using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Models
{
    [Table("Cities")]
    public class City : Base
    {
        [Required]
        [MaxLength(DescriptionMaxLength)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Estado")]
        public int StateId { get; set; }

        public State State { get; set; }
    }
}