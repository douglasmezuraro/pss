using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PSS.Models
{
    [Table("UserTypes")]
    public class UserType : Base 
    {
        [Required][MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        public String Description { get; set; }

    }
}