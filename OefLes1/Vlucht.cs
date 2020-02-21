using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Vlucht
    {
        //extra 2: bestemmingen limiteren
        //enums zijn mini klassen, dus met hoofdletter. 
        public enum Bestemmingen { Frankrijk, Engeland, Duitsland }

        //extra 2: vertrekken limiteren
        public enum Vertrekken { België }

        //extra 1: automatische verhoging
        //statisch nummer in de klasse, altijd hetzelfde voor elke instantie
        static private int teller = 0;

        //extra 1: automatische verhoging
        //property om vluchtnummer in op te slaan, private set omdat dit niet kan worden aangepast door gebruiker
        public int Vluchtnummer { get; private set; }

        public Bestemmingen BestemmingPlaats { get; set; }

        public Vertrekken VertrekPlaats { get; set; }

        public DateTime VertrekTijd { get; set; }

        public DateTime AankomstTijd { get; set; }

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
        public Vlucht() : this(Bestemmingen.Frankrijk, Vertrekken.België, new DateTime(2020, 04, 10, 12, 0, 0), new DateTime(2020, 04, 10, 13, 0, 0))
        {

        }

        //methodes hebben altijd een wekwoord in de naam
        public string BerekenVluchtduur()
        {
            TimeSpan vluchtduur = AankomstTijd - VertrekTijd;
            //de $ is een string interpolation, gewoon string . format maar simpeler, gebruik dit
            return $"De vlucht duurt {vluchtduur.ToString()} (d.uu-mm-ss)";
        }

        public override string ToString()
        {
            return $"Vlucht {Vluchtnummer} vliegt van {VertrekPlaats} naar {BestemmingPlaats}."; 
        }
    }
}
