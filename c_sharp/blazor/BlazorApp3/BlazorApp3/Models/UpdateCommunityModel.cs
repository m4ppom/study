using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace CommunitySample.Models
{
    public class UpdateCommunityModel
    {
        
        public string Title { get; set; }
        [StringLength(500, ErrorMessage = "Text Is Too Long.")]
        public string Text { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}
