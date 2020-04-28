using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMBD
{
    class Movie : Media
    {
        #region "Properties"

        public enum Genres { Action, Fantasy, Comedy, Crime, Drama, Mystery, Romance }

        public string Producer { get; set; }

        public Person Director { get; set; }

        public Genres Genre { get; set; }

        public int ReleaseYear { get; set; }

        #endregion "Properties"

        #region "Constructors"

        public Movie(string title, decimal? rating, string producer, Person director, Genres genre, int releaseYear) : base(title, rating)
        {
            Producer = producer;
            Director = director;
            Genre = genre;
            ReleaseYear = releaseYear;
        }

        #endregion "Constructors"

        #region "Methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{ReleaseYear}");
            return base.ToString() + output.ToString();
        }

        #endregion "Methods"
    }
}
