using System;
using System.ComponentModel.DataAnnotations;

namespace PSS.Models
{
    public class UserType : Base 
    {
        [Required][MinLength(DescriptionMinLength), MaxLength(DescriptionMaxLength)]
        public String Description { get; set; }

    }
}