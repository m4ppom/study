using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.Models
{
    public class DisplayCommunityModel
    {
        [Required]
        [StringLength(15, ErrorMessage = "Name Is Too Long.")]
        [MinLength(3, ErrorMessage = "Name is too short")]
        public string Name { get; set; }
        [StringLength(1000, ErrorMessage = "Text Is Too Long.")]
        public string Text { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
