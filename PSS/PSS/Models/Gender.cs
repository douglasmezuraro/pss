using System.ComponentModel.DataAnnotations;

namespace PSS.Models
{
    public class Gender : Base
    {
        [Required][MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }

    }
}