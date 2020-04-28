using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMBD
{
    class Person
    {
        #region "Properties and fields"

        static Random generator = new Random();

        public enum Sexes
        {
            Man, Woman
        }
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public DateTime BirthDate { get; set; }

        public Sexes Sex { get; set; }

        #endregion "Properties and fields"

        #region "Constructors"

        //Basic alles input constructor voor slechts een persoon
        public Person(string lastName, string firstName, DateTime birthDate, Sexes sex)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
            Sex = sex;
        }

        //simpele constructor voor een persoon
        public Person(string lastName, string firstName) : this(lastName, firstName, new DateTime(2000, 1, 1), Sexes.Woman)
        {

        }

        #endregion "Constructors"

        #region "Methodes"

        #region "Methodes persoon"

        public static Person MakeRandomPerson()
        {
            List<string> namen = new List<string>
            {
                "Jones", 
                "Free", 
                "HayWood", 
                "Dooley", 
                "Jameson"
            };
            List<string> voornamen = new List<string>
            {
                "Morgan",
                "Jack",
                "Trevor",
                "Brian", 
                "Peter"
            };
            string randomNaam = namen[generator.Next(namen.Count)];
            string randomVoorNaam = voornamen[generator.Next(voornamen.Count)];
            int randomYear = generator.Next(1980, 2001);
            int randomMonth = generator.Next(1, 13);
            int randomDay = generator.Next(1, DateTime.DaysInMonth(randomYear, randomMonth) + 1);
            DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
            Sexes randomGeslacht = (Sexes)generator.Next(2);
            return new Person(randomNaam, randomVoorNaam, randomDate, randomGeslacht);
        }

        public int CalculateAge(DateTime datum)
        {
            int leeftijd = datum.Year - BirthDate.Year;

            if (datum.DayOfYear < BirthDate.DayOfYear)
            {
                leeftijd--;
            }
            return leeftijd;
        }

        public int CalculateAge()
        {
            return CalculateAge(DateTime.Today);
        }

        public string GetName()
        {
            return $"{FirstName} {LastName}";
        }

        #endregion "Methodes persoon"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{FirstName} {LastName} is {CalculateAge()} years old");
            return output.ToString();
        }

        #endregion "Methodes"

    }
}
