using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._4
{
    class Artist : Person
    {
        public Artist(string lastName, string firstName, string style) : base(lastName, firstName, style)
        {
        }

        public static Artist MakeRandomPerson()
        {
            List<string> lastnames = new List<string>
            {
                "Jones",
                "Free",
                "HayWood",
                "Dooley",
                "Jameson"
            };
            List<string> firstnames = new List<string>
            {
                "Morgan",
                "Jack",
                "Trevor",
                "Brian",
                "Peter"
            };
            List<string> styles = new List<string>
            {
                "EDM",
                "Pop",
                "Electronic"
            };
            string randomLastName = lastnames[generator.Next(lastnames.Count)];
            string randomFirstName = firstnames[generator.Next(firstnames.Count)];
            string randomStyle = styles[generator.Next(styles.Count)];
            return new Artist(randomLastName, randomFirstName, randomStyle);
        }
    }
}
