using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BlazorApp3.Models
{
    public class DisplayCommunityModel
    {
    
        [StringLength(15, ErrorMessage = "Name Is Too Long.")]
        
        public string Name { get; set; }
    
        public string Title { get; set; }
        [StringLength(1000, ErrorMessage = "Text Is Too Long.")]
        public string Text { get; set; }
       
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
