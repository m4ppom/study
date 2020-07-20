using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyBlazorApp1.Shared.Entities;

namespace UdemyBlazorApp1.Client.Helpers
{
    public interface Repository
    {
        new List<Movie> GetMovies(); 
    }
}
