using System;
using System.ComponentModel.DataAnnotations;

namespace PSS.Models
{
    public class User : Base
    {
        protected const int CPFLength = 14;
        
        [Required][MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        public string Name { get; set; }

        [Required][MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        public string LastName { get; set; }

        [Required][MinLength(CPFLength), MaxLength(CPFLength)]
        public string CPF { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public DateTime Birth { get; set; }

        [Required]
        public int UserTypeId { get; set; }

        public UserType UserType { get; set; }

        [Required]
        public int AddressId { get; set; }

        public Address Address { get; set; }

    }
}