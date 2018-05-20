using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Models
{
    [Table("States")]
    public class State : Base
    {
        private const int UFLength = 2;

        [Required][MaxLength(DescriptionMaxLength)]
        public string Name { get; set; }

        [Required][MinLength(UFLength), MaxLength(UFLength)]
        public string UF { get; set; }
    }
}