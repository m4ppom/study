using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class AuthorService
    {
        public DateTime CreationDate { get; set; }

        public List<Author> Authors { get; set; }

        public AuthorService()
        {
            CreationDate = DateTime.Now;

            Authors = new List<Author>();

            Authors.Add(new Author("1", "Jin G C", "White", "010 1234 5678", "YongIn"));
            Authors.Add(new Author("8412641", "Kim J H", "Green", "010 3456 7891", "Suwon"));
            Authors.Add(new Author("8648224", "No K H", "Carson", "010 5678 9102", "Sungnam"));
            Authors.Add(new Author("8264849", "Kim K T", "Straight", "010 8910 1244", "Seoul"));
            Authors.Add(new Author("1554588", "Bae W J", "Green", "010 9874 5465", "Hanam"));
            Authors.Add(new Author("6798125", "Kim H J", "White", "010 9797 4545", "Busan"));
        }
        public List<Author> GetAuthors()
        {
            return Authors;
        }

        public Author GetAuthorById(string authorID)
        {
            return Authors.Where(auth => auth.AuthorId == authorID).FirstOrDefault();
        }

        public DateTime GetCreatedDate()
        {
            return CreationDate;
        }

        public string GetVersion()
        {
            return "v1";
        }

    }
}
