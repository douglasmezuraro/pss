using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Models
{
    [Table("Addresses")]
    public class Address : Base
    {
        [Required] [MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        public string Name { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int PostalCode { get; set; }

        public string Complement { get; set; }

        public string Reference { get; set; }

        [Required]
        public int CityId { get; set; }

        public City City { get; set; }

    }
}