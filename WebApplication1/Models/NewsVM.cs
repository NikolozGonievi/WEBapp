using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public  static class NewsVM
    {
        public static List<News> data = new List<News>()
        {
            new News()
            {
                Id=1,
                Title="ambavi 1 ",
                Description="raashsgdfhsghsdfgsdfgsdfsdfhs",
                Tumb = "2.jpg"
            },
            new News()
            {
                Id=2,
                Title="ambavi 2 ",
                Description="sdsgdfghsfghfghsfghsgh",
                Tumb ="News.png"
            },
            new News()
            {
                Id=3,
                Title="ambavi 3",
                Description = "sdfsdfsdfsgadfgsfg",
                Tumb="bbc.png"
            }

        };
    }
}
