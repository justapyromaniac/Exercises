using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Persoon
    {
        //THERE ARE 2 GENDERS
        public enum Geslachten
        {
            Man, Vrouw
        }
        public string Naam { get; set; }

        public string Voornaam { get; set; }

        public DateTime GeboorteDatum { get; set; }

        public Geslachten Geslacht { get; set; }

        public Persoon(string naam, string voornaam, DateTime geboorteDatum, Geslachten geslacht)
        {
            Naam = naam;
            Voornaam = voornaam;
            GeboorteDatum = geboorteDatum;
            Geslacht = geslacht;
        }

        public Persoon(string naam, string voornaam) : this(naam, voornaam, new DateTime(2000, 1, 1), Geslachten.Vrouw)
        {

        }

        //extra 1: methode om leeftijd te berekenen met meegegeven datum. 
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

        public override string ToString()
        {
            return $"{Naam} {Voornaam} is {BerekenLeeftijd()} jaar oud.";
        }
    }
}
