using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp3.Helpers
{
    public class RepositoryInMemory : Repository
    {

    }
    public List<BoardItem> GetBoards()
    {
        return new List<BoardItem>
        {
            new BoardItem() { Title = "urgent1", Text="1", Name="name1", Releasedate = new DateTime(2019,7,23) },
            new BoardItem() { Title = "urgent2", Text="2", Name="name2", Releasedate = new DateTime(2020,3,2) },
            new BoardItem() { Title = "urgent3", Text="3", Name="name3", Releasedate = new DateTime(2020,6,11) },
        };
    }
}
