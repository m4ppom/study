using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class CommunityModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string EmailAddress { get; set; }
        public int Id { get; set; }
        public DateTime CreatedDate { get; }
        public int Answered { get; set; }

    }
}
