using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes2
{
    class Auto
    {
        //Properties start

        public string Merk { get; set; }

        public string Type { get; set; }

        public string Nummerplaat { get; set; }

        public int AantalKilometers { get; set; }

        public Persoon Eigenaar { get; set; }

        //Properties end
        //Constructors start

        //Constructor om een volledige auto aan te maken
        public Auto(string merk, string type, string nummerplaat, int aantalKilometers, Persoon eigenaar)
        {
            Merk = merk;
            Type = type;
            Nummerplaat = nummerplaat;
            AantalKilometers = aantalKilometers;
            Eigenaar = eigenaar;
        }

        //Constructor om een standaard auto aan te maken met een eigenaar
        public Auto(Persoon eigenaar) : this("ONBEKEND", "ONBEKEND", "1-AAA-000", 0, eigenaar)
        {

        }

        //Simpele constructor om een standaard auto met standaard eigenaar te maken
        public Auto() : this ("ONBEKEND", "ONBEKEND", "1-AAA-000", 0, new Persoon("John", "Doe"))
        {

        }

        //Constructors end
        //Methods start

        public int BerekenKilometers(int jaren)
        {
            const int KILOMETERSPERJAAR = 20000;
            AantalKilometers = jaren * KILOMETERSPERJAAR;
            return AantalKilometers;
        }

        //Constructor chaining om een default aantal jaren te hebben
        public int BerekenKilometers()
        {
            int jaren = 10;
            return BerekenKilometers(jaren);
        }

        //Methods end

        public override string ToString()
        {
            return $"De auto met {Nummerplaat} heeft {AantalKilometers} kilometers en is van {Eigenaar.GeefNaam()}.";
        }

    }
}
