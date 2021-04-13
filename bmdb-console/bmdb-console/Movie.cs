using System;
using System.Collections.Generic;
using System.Text;

namespace bmdb_console
{
    class Movie
    {
        public Movie(int id, string title, string rating, int year, string director)
        {
            this.id = id;
            this.title = title;
            this.rating = rating;
            this.year = year;
            this.director = director;
        }

        public int id { get; set; }
        public String title { get; set; }
        public String rating { get; set; }
        public int year { get; set; }
        public String director { get; set; }



        public override string ToString()
        {
            return base.ToString();
        }
    }
}
