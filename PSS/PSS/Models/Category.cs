using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Models
{
    [Table("Categories")]
    public class Category : Base
    {
        [Required][MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        public string Name { get; set; }
    }
}