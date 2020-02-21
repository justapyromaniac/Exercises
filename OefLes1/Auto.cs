using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Auto
    {
        public string Merk { get; set; }

        public string Type { get; set; }

        public string Nummerplaat { get; set; }

        public int AantalKilometers { get; set; }

        public Auto(string merk, string type, string nummerplaat, int aantalKilometers)
        {
            Merk = merk;
            Type = type;
            Nummerplaat = nummerplaat;
            AantalKilometers = aantalKilometers;
        }

        public Auto() : this ("ONBEKEND", "ONBEKEND", "1-AAA-000", 0)
        {

        }

        public int BerekenKilometers(int jaren)
        {
            const int KILOMETERSPERJAAR = 20000;
            AantalKilometers = jaren * KILOMETERSPERJAAR;
            return AantalKilometers;
        }

        public int BerekenKilometers()
        {
            int jaren = 10;
            return this.BerekenKilometers(jaren);
        }

        public override string ToString()
        {
            return $"De auto met {Nummerplaat} heeft {AantalKilometers} kilometers.";
        }

    }
}
