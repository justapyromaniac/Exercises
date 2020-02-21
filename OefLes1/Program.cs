using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ klasse Vlucht ------");
            Console.WriteLine();

            Vlucht vlucht1 = new Vlucht();
            Vlucht vlucht2 = new Vlucht(Vlucht.Bestemmingen.Duitsland, Vlucht.Vertrekken.België, new DateTime(2020, 4, 10, 9, 30, 0), new DateTime(2020, 4, 11, 19, 40, 0));
            Console.WriteLine(vlucht1);
            Console.WriteLine(vlucht1.BerekenVluchtduur());
            Console.WriteLine();
            Console.WriteLine(vlucht2);
            Console.WriteLine(vlucht2.BerekenVluchtduur());

            Console.WriteLine("\n\n");

            Console.WriteLine("------ klasse Persoon ------");
            Console.WriteLine();

            Persoon persoon1 = new Persoon("Dough", "Jane");
            Persoon persoon2 = new Persoon("Staes", "Jonas", new DateTime(2000, 03, 10), Persoon.Geslachten.Man);
            Console.WriteLine(persoon1);
            Console.WriteLine(persoon2);

            Console.WriteLine("\n\n");

            Console.WriteLine("------ klasse Auto ------");
            Console.WriteLine();

            Auto auto1 = new Auto();
            Console.WriteLine(auto1);
            auto1.AantalKilometers = auto1.BerekenKilometers();
            Console.WriteLine("Met berekende kilometers: " + auto1);
            Console.WriteLine("\n\n\u00A9Jonas Staes - AP 2019/2020");
        }
    }
}
