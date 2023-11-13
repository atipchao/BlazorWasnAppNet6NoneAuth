﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasnAppNet6NoneAuth.Shared.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
