using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyBlazorApp1.Shared.Entities;

namespace UdemyBlazorApp1.Client.Helpers
{
    public class RepositoryInMemory : Repository
    {

    }public List<Movie> GetMovies()
    {
        return new List<Movie>()
        {
            new Movie(){Title = "Spider-man : Far From Home", Releasedate = new DateTime(2019,7,2)},
            new Movie(){Title = "Moana", Releasedate = new DateTime(2016, 11, 23)},
            new Movie(){Title = "Inception", Releasedate = new DateTime(2010, 7, 16)}
        };

}
