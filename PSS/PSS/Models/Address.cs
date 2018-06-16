using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Models
{
    [Table("Addresses")]
    [DisplayName("Endereço")]
    public class Address : Base
    {
        [Required]
        [MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required]
        [DisplayName("Número")]
        public int Number { get; set; }

        [Required]
        [DisplayName("CEP")]
        public int PostalCode { get; set; }

        [DisplayName("Complemento")]
        public string Complement { get; set; }

        [DisplayName("Referência")]
        public string Reference { get; set; }

        [Required]
        [DisplayName("Cidade")]
        public int CityId { get; set; }

        [DisplayName("Cidade")]
        public City City { get; set; }
    }
}