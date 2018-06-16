using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Models
{
    [Table("Users")]
    public class User : Base
    {
        protected const int CPFLength = 14;
        protected const int PasswordMinLength = 8;
        protected const int PasswordMaxLength = 16;
        
        [Required]
        [MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        [DisplayName("Nome")]
        public string Name { get; set; }

        [Required]
        [MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        [DisplayName("Sobrenome")]
        public string LastName { get; set; }

        [Required]
        [MinLength(CPFLength), MaxLength(CPFLength)]
        public string CPF { get; set; }

        [Required]
        [DisplayName("Telefone")]
        public string Phone { get; set; }

        [Required]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Nascimento")]
        public DateTime Birth { get; set; }

        [Required]
        [MinLength(PasswordMinLength), MaxLength(PasswordMaxLength)]
        [DisplayName("Senha")]
        public string Password { get; set; }

        [Required]
        [DisplayName("Tipo")]
        public int UserTypeId { get; set; }

        public UserType UserType { get; set; }

        [Required]
        [DisplayName("Endereço")]
        public int AddressId { get; set; }

        public Address Address { get; set; }

        [Required]
        [DisplayName("Gênero")]
        public int GenderId { get; set; }

        public Gender Gender { get; set; }
    }
}