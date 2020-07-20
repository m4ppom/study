using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyBlazorApp1.Shared.Entities;

namespace UdemyBlazorApp1.Client.Pages
{
    public partial class Counter
    {
        [Inject] SingletonServices singleton { get; set; }
        [Inject] TransientServices transient { get; set; }
        private List<Movie> movies;
        protected override void OnInitialized()
        {
            movies = new List<Movie>()
        {
            new Movie() {Title = "Koker", Releasedate = new DateTime(2020, 6, 2)},
            new Movie() {Title = "Avengers", Releasedate = new DateTime(2016, 11, 23)},
        };
        }


        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            transient.Value = currentCount;
            singleton.Value = currentCount;
        }
    }
}
