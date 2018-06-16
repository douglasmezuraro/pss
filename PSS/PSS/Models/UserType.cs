using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Models
{
    [Table("UserTypes")]
    public class UserType : Base 
    {
        [Required]
        [MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        [DisplayName("Tipo de usuário")]
        public String Description { get; set; }
    }
}