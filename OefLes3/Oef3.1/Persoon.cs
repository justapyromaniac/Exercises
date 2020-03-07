using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes3
{
    class Persoon
    {
        //alle code die niet meteen met een persoon te maken heeft verwijderd
        //Dit is niet nodig in deze oefening
        #region "Properties en fields"

        static Random generator = new Random();

        public enum Geslachten
        {
            Man, Vrouw
        }
        public string Naam { get; set; }

        public string Voornaam { get; set; }

        public DateTime GeboorteDatum { get; set; }

        public Geslachten Geslacht { get; set; }

        #endregion "Properties en fields"

        #region "Constructors"

        //Basic alles input constructor voor slechts een persoon
        public Persoon(string naam, string voornaam, DateTime geboorteDatum, Geslachten geslacht)
        {
            Naam = naam;
            Voornaam = voornaam;
            GeboorteDatum = geboorteDatum;
            Geslacht = geslacht;
        }

        //simpele constructor voor een persoon
        public Persoon(string naam, string voornaam) : this(naam, voornaam, new DateTime(2000, 1, 1), Geslachten.Vrouw)
        {

        }

        #endregion "Constructors"

        #region "Methodes"

        #region "Methodes persoon"

        //om random personen te maken
        public static Persoon MaakRandomPersoon()
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
            Geslachten randomGeslacht = (Geslachten)generator.Next(2);
            return new Persoon(randomNaam, randomVoorNaam, randomDate, randomGeslacht);
        }

        public int BerekenLeeftijd(DateTime datum)
        {
            int leeftijd = datum.Year - GeboorteDatum.Year;

            if (datum.DayOfYear < GeboorteDatum.DayOfYear)
            {
                leeftijd--;
            }
            return leeftijd;
        }

        public int BerekenLeeftijd()
        {
            //method chaining, gebruik de gecallde methode in return als deze methode gebruikt wordt
            return this.BerekenLeeftijd(DateTime.Today);
        }

        public string GeefNaam()
        {
            return $"{Voornaam} {Naam}";
        }

        #endregion "Methodes persoon"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{Naam} {Voornaam} is {BerekenLeeftijd()} jaar oud");
            return output.ToString();
        }

        #endregion "Methodes"

    }
}
