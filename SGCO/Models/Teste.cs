﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGCO.Models
{
    public class Teste
    {
        [Key]
        public int Id { get; set; }
        public String Fruta { get; set; }
        public String Animal { get; set; }
    }
}