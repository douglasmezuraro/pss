using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Models
{
    [Table("Genders")]
    public class Gender : Base
    {
        [Required][MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

    }
}