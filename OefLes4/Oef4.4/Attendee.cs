using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._4
{
    class Attendee : Person
    {
        public DateTime BirthDate { get; set; }

        public string HomeTown { get; set; }

        public bool IsHandicapped { get; set; }

        public Attendee(string lastName, string firstName, string style, DateTime birthDate, string homeTown, bool isHandicapped) : base(lastName, firstName, style)
        {
            BirthDate = birthDate;
            HomeTown = homeTown;
            IsHandicapped = isHandicapped;
        }

        public int CalculateAge(DateTime date)
        {
            int age = date.Year - BirthDate.Year;

            if (date.DayOfYear < BirthDate.DayOfYear)
            {
                age--;
            }
            return age;
        }

        public int CalculateAge()
        {
            return CalculateAge(DateTime.Today);
        }

        public string GetAttendeeHomeTown()
        {
            return HomeTown;
        }

        public bool GetIfHandicapped()
        {
            return IsHandicapped;
        }

        public static Attendee MakeRandomPerson()
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
            List<string> towns = new List<string>
            {
                "Boom",
                "Mol",
                "Brussels",
                "Antwerp"
            };
            string randomLastName = lastnames[generator.Next(lastnames.Count)];
            string randomFirstName = firstnames[generator.Next(firstnames.Count)];
            string randomStyle = styles[generator.Next(styles.Count)];
            int randomYear = generator.Next(1980, 2001);
            int randomMonth = generator.Next(1, 13);
            int randomDay = generator.Next(1, DateTime.DaysInMonth(randomYear, randomMonth) + 1);
            string randomTown = towns[generator.Next(towns.Count)];
            DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
            int randomInt = generator.Next(0, 2);
            bool randomBool;
            if (randomInt > 0)
            {
                randomBool = true;
            }
            else
            {
                randomBool = false;
            }
            return new Attendee(randomLastName, randomFirstName, randomStyle, randomDate, randomTown, randomBool);
        }

        public override string ToString()
        {
            string isHandicapped = IsHandicapped ? "Yes" : "No";
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Age: {CalculateAge()}");
            output.AppendLine($"Home town: {HomeTown}");
            output.AppendLine($"Has a handicap: {isHandicapped}");
            return base.ToString() + output.ToString();
        }
    }
}
