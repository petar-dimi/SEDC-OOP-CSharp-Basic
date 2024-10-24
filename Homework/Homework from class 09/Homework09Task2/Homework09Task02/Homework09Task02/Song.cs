using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework09Task02
{
    public class Song
    {
        public string Title { get; set; }
        public double Length { get; set; } 
        public Genre Genre { get; set; }

        public Song(string title, double length, Genre genre)
        {
            Title = title;
            Length = length;
            Genre = genre;
        }
    }
}
