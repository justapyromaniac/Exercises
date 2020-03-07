using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes3
{
    class Werknemer
    {
        //om de loonsverhoging random te kunnen berekenen
        static Random generator = new Random();

        #region "Properties en fields"

        public string Naam { get; set; }

        public string Voornaam { get; set; }

        //een field om het personeelsnummer automatisch te verhogen
        private static int teller = 1;

        //Private omdat dit autoincrement
        public int PersoneelNummer { get; private set; }

        public int Anciënniteit { get; set; }

        //Checkt of de werknemer nog een loonsverhoging mag krijgen
        //Private zodat dit enkel met de methode kan worden aangepast
        public bool Voldoende { get; private set; }

        //private zodat de methodes gebruikt moeten worden
        public decimal Salaris { get; private set; }

        #endregion "Properties en fields"

        #region "Constructors"

        //anciënniteit = 1 zorgt ervoor dat wanneer je geen anciëniteit invult het 1 is
        public Werknemer(string naam, string voornaam, decimal loonsverhoging, int anciënniteit = 1)
        {
            Naam = naam;
            Voornaam = voornaam;
            PersoneelNummer = teller++;
            Anciënniteit = anciënniteit;
            //Default value van voldoende setten
            Voldoende = true;
            //dit moet in de constructor no het setten van de bool zodat het die bool kan lezen
            BerekenSalaris(loonsverhoging);
        }

        #endregion "Constructors"

        #region "Methodes"

        public static Werknemer MaakRandomWerknemer()
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
            decimal randomLoonsVerhoging = generator.Next(50, 401);
            int randomAnciënniteit = generator.Next(1, 11);
            return new Werknemer(randomNaam, randomVoorNaam, randomLoonsVerhoging, randomAnciënniteit);
        }

        #region "Methodes Salaris"

        public decimal BerekenSalaris(decimal LoonsVerhoging, int anciënniteit)
        {
            const int BASISSALARIS = 200;
            if (Voldoende)
            {
                Salaris = (LoonsVerhoging + BASISSALARIS) * anciënniteit;
            }
            else
            {
                Salaris = BASISSALARIS * anciënniteit;
            }
           
            return Salaris;
        }

        public decimal BerekenSalaris(decimal basisSalaris)
        {
            return BerekenSalaris(basisSalaris, Anciënniteit);
        }

        #endregion "Methodes Salaris"

        //Om de property voldoende aan te passen
        #region "Methodes voldoende"

        public bool SetOnvoldoende()
        {
            return Voldoende = false;
        }

        public bool SetVoldoende()
        {
            return Voldoende = true;
        }

        #endregion "Methodes voldoende"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Naam: {Naam} {Voornaam}");
            output.AppendFormat("Personeelsnummer: P{0:00000}\n", PersoneelNummer);
            output.AppendLine($"Anciënniteit: {Anciënniteit} jaren");
            output.AppendLine($"Salaris: {Salaris}");
            return output.ToString(); 
        }

        #endregion "Methodes"
    }
}
