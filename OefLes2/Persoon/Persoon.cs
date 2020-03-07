using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes2
{
    class Persoon
    {
        #region "Properties en fields"

        public enum Geslachten
        {
            Man, Vrouw
        }
        public string Naam { get; set; }

        public string Voornaam { get; set; }

        public DateTime GeboorteDatum { get; set; }

        public Geslachten Geslacht { get; set; }

        public Vlucht Vlucht { get; set; }

        //Geen contructor om een persoon met autos te maken, dit wordt behandeld met methodes
        public List<Auto> Autos { get; }

        #endregion "Properties en fields"

        #region "Constructors"

        //Basic alles input constructor voor slechts een persoon
        public Persoon(string naam, string voornaam, DateTime geboorteDatum, Geslachten geslacht)
        {
            Naam = naam;
            Voornaam = voornaam;
            GeboorteDatum = geboorteDatum;
            Geslacht = geslacht;
            //op deze manier heeft elke persoon een lege lijst van autos
            Autos = new List<Auto>();
        }

        //Constructor voor een passagier
        public Persoon(string naam, string voornaam, DateTime geboorteDatum, Geslachten geslacht, Vlucht vlucht) :this(naam, voornaam, geboorteDatum, geslacht)
        {
            Vlucht = vlucht;
        }

        //simpele constructor voor een passagier
        public Persoon(string naam, string voornaam, Vlucht vlucht) : this(naam, voornaam, new DateTime(2000, 1, 1), Geslachten.Vrouw, vlucht)
        {

        }

        //simpele constructor voor een persoon
        public Persoon(string naam, string voornaam) : this(naam, voornaam, new DateTime(2000, 1, 1), Geslachten.Vrouw)
        {

        }

        #endregion Constructors"

        #region "Methodes"

        #region "Methodes Persoon"

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

        #endregion "Methodes Persoon"

        #region "Methodes autos"

        public string GeefAutos()
        {
            StringBuilder output = new StringBuilder();
            if (Autos.Count != 0)
            {
                output.AppendLine("Deze persoon heeft de volgende autos: ");
                foreach (Auto auto in Autos)
                {
                    output.AppendLine($"een {auto.GeefAuto()}");
                }
            }
            else
            {
                output.AppendLine("Deze persoon heeft geen autos");
            }
            return output.ToString();
        }

        public Auto VindAuto(Auto input)
        {
            Auto output = null;
            foreach (Auto auto in Autos)
            {
                if(auto == input)
                {
                    output = auto;
                }
            }
            return output;
        }

        //Deze methodes dienen om de lijst van autos te veranderen
        public bool VoegAutoToe(Auto auto)
        {
            //geen check ofdat een auto al in de lijst zit, als ze 2 teslas willen dan mag dat
            if(auto != null)
            {
                Autos.Add(auto);
                return true;
            }
            return false;
        }

        public bool VerwijderAuto(Auto auto)
        {
            if(auto != null)
            {
                if(Autos.Contains(auto))
                {
                    Autos.Remove(auto);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        #endregion "Methodes autos"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{Naam} {Voornaam} is {BerekenLeeftijd()} jaar oud");
            //Een check of de persoon een passagier is en/of de persoon autos heeft
            if (Vlucht != null)
            {
                output.AppendLine($"en vliegt op vlucht {Vlucht.GeefVlucht()}");
            }
            if(Autos.Count != 0)
            {
                output.AppendLine(GeefAutos());
            }
            return output.ToString();
        }

        #endregion "Methodes"
    }
}
