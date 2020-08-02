﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Models
{
    public class DisplayPersonModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "FIrst Name Is Too Long.")]
        [MinLength(5, ErrorMessage = "First Name is too short")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(15, ErrorMessage = "Last Name Is Too Long.")]
        [MinLength(5, ErrorMessage = "Last Name is too short")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}