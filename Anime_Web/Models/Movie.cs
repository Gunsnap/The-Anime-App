using System;

namespace Anime_Web.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public int Length { get; set; }
        public string Billede { get; set; }
        public string IMDB { get; set; }

        public Movie()
        {
            Name = "";
            Year = new DateTime();
            Length = 0;
            Billede ="";
            IMDB = "";
        }
    }
}