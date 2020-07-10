using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Author
    {
        public string AuthorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public string City { get; set; }

        public Author()
        {

        }
        public Author(string authorId, string finstName, string lastName, string phoneNumber, string city)
        {

        }

    }
}
