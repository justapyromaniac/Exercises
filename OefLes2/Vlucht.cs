using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes2
{
    class Vlucht
    {
        //Properties start

        //enums zijn mini klassen, dus met hoofdletter. 
        public enum Bestemmingen { Frankrijk, Engeland, Duitsland }

        public enum Vertrekken { België }

        //statisch nummer in de klasse, altijd hetzelfde voor elke instantie
        static private int teller = 1;

        //property om vluchtnummer in op te slaan, private set omdat dit niet kan worden aangepast door gebruiker
        public int Vluchtnummer { get; private set; }

        public Bestemmingen BestemmingPlaats { get; set; }

        public Vertrekken VertrekPlaats { get; set; }

        public DateTime VertrekTijd { get; set; }

        public DateTime AankomstTijd { get; set; }

        //Geen contructor om een vlucht met passagiers te maken, dit wordt behandeld met methodes
        //op deze manier heeft elke vlucht een lege lijst van passagiers
        public List<Persoon> Passagiers { get; set; } = new List<Persoon>();

        //Properties end
        //Constructors start

        //Volledige constructor om een vlucht aan te maken
        public Vlucht(Bestemmingen bestemmingPlaats, Vertrekken vertrekPlaats, DateTime vertrekTijd, DateTime aankomstTijd)
        {
            //property setten met increment teller, dit verhoogt voor elke nieuwe klasse
            Vluchtnummer = teller++;
            BestemmingPlaats = bestemmingPlaats;
            VertrekPlaats = vertrekPlaats;
            VertrekTijd = vertrekTijd;
            AankomstTijd = aankomstTijd;
        }

        //constructor chaining
        //Simpele constructor om een vlucht aan te maken
        public Vlucht() : this(Bestemmingen.Frankrijk, Vertrekken.België, DateTime.Today, DateTime.Today.AddHours(2))
        {

        }

        //Constructors end
        //Methods start
            //Methods Vlucht start

        //methodes hebben altijd een wekwoord in de naam
        public string BerekenVluchtduur()
        {
            TimeSpan vluchtduur = AankomstTijd - VertrekTijd;
            //de $ is een string interpolation, gewoon string . format maar simpeler, gebruik dit
            return $"De vlucht duurt {vluchtduur.ToString()} (d.uu-mm-ss)";
        }

            //Methods Vlucht end
            //Methods Passagiers start

        //Deze methodes dienen om de lijst van passagiers te veranderen
        public bool VoegPassagierToe(Persoon passagier)
        {
            if(passagier != null)
            {
                Passagiers.Add(passagier);
                return true;
            }
            return false;
        }

        public bool VerwijderPassagier(Persoon passagier)
        {
            if(passagier != null)
            {
                Passagiers.Remove(passagier);
                return true;
            }
            return false;
        }

        public Persoon VindPassagier(string naam, string voornaam)
        {
            string volledigeNaam = $"{voornaam} {naam}";
            Persoon output = null;
            foreach(Persoon passagier in Passagiers)
            {
                if(passagier.GeefNaam() == volledigeNaam)
                {
                    output = passagier;
                }
            }
            return output;
        }

        public string GeefPassagiersLijst()
        {
            StringBuilder output = new StringBuilder();
            output.Append("\nOp deze vlucht vliegen de volgende passagiers: ");
            foreach (Persoon passagier in Passagiers)
            {
                output.Append($"\n{passagier.GeefNaam()}");
            }
            return output.ToString();
        }

            //Methods Passagiers end
        //Methods end

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Vlucht {Vluchtnummer} vliegt van {VertrekPlaats} naar {BestemmingPlaats}.");
            if(Passagiers.Count != 0)
            {
                output.AppendLine("Op deze vlucht vliegen de volgende passagiers: ");
                foreach(Persoon passagier in Passagiers)
                {
                    output.AppendLine($"{passagier.GeefNaam()}");
                }
            }
            return output.ToString(); 
        }
    }
}
