using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes2
{
    class Program
    {
        public static Stack<char> LetterLijst = new Stack<char>();

        //checken of de input hoodletter Z is
        public static bool isZ(char letter)
        {
            if (letter == 'Z')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

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
            Console.WriteLine();

            Persoon passagier1 = new Persoon("Staes", "Jonas");
            Persoon passagier2 = new Persoon("Bels", "Senne", new DateTime(2000, 11, 17), Persoon.Geslachten.Man);

            vlucht1.VoegPassagierToe(passagier1);
            vlucht1.VoegPassagierToe(passagier2);

            Console.WriteLine(vlucht1);

            Console.WriteLine(vlucht1.VindPassagier("Bels", "Senne"));

            vlucht1.VerwijderPassagier(passagier2);

            Console.WriteLine(vlucht1);

            Vliegveld vliegveld = new Vliegveld();
            vliegveld.VoegVluchtToe(vlucht1);
            vliegveld.VoegVluchtToe(vlucht2);
            Console.WriteLine(vliegveld.VindVlucht(1));
            Console.WriteLine(vliegveld.ToString());
            vliegveld.VerwijderVlucht(vlucht1);
            Console.WriteLine(vliegveld.ToString());

            Console.WriteLine("\n\n");

            Console.WriteLine("------ klasse Persoon ------");
            Console.WriteLine();

            Persoon persoon1 = new Persoon("Dough", "Jane");
            Persoon persoon2 = new Persoon("Staes", "Jonas", new DateTime(2000, 03, 10), Persoon.Geslachten.Man);
            Persoon persoon3 = new Persoon("Senne", "Bels", new DateTime(2000, 11, 17), Persoon.Geslachten.Man);
            Console.WriteLine(persoon1);
            Console.WriteLine(persoon2);
            Console.WriteLine(persoon3);

            persoon1.Vlucht = new Vlucht();
            Auto auto1Persoon2 = new Auto("Tesla", "Model S", "420", 0, persoon2);
            Auto auto2Persoon2 = new Auto("Tesla", "Model S", "420", 0, persoon2);
            persoon2.VoegAutoToe(auto1Persoon2);
            persoon2.VoegAutoToe(auto2Persoon2);
            persoon3.Vlucht = new Vlucht();
            persoon3.VoegAutoToe(new Auto(persoon3));

            Console.WriteLine("\n");
            Console.WriteLine(persoon1);
            Console.WriteLine(persoon2);
            Console.WriteLine(persoon3);

            persoon2.VerwijderAuto(auto2Persoon2);
            Console.WriteLine(persoon2);


            Console.WriteLine("\n\n");

            Console.WriteLine("------ klasse Auto ------");
            Console.WriteLine();

            Auto auto1 = new Auto(persoon1);
            Console.WriteLine(auto1);
            auto1.AantalKilometers = auto1.BerekenKilometers();
            Console.WriteLine("Met berekende kilometers: " + auto1);

            Console.WriteLine("\n\n");

            Console.WriteLine("------ Afkortingen ------");
            Console.WriteLine();

            AfkortingDictionary afkortingen = new AfkortingDictionary();
            Console.WriteLine(afkortingen.ToString());
            afkortingen.VoegAfkortingToe("LLY", "Love you");
            Console.WriteLine(afkortingen.ToString());
            Console.WriteLine(afkortingen.LeesAfkorting("lly"));
            afkortingen.VerwijderAfkorting("LLY");
            Console.WriteLine(afkortingen.ToString());

            char input = '.';

            do
            {
                bool isLetter = false;
                //aparte whileloop voor input validatie
                while (!isLetter)
                {
                    try
                    {
                        Console.Write("Geef een letter in: ");
                        input = char.Parse(Console.ReadLine());
                        isLetter = true;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Geef slechts 1 letter in");
                    }

                }
                if(isZ(input))
                {
                    //Dit zal enkel lopen als de eerste input Z is
                    try
                    {
                        LetterLijst.Pop();
                    }
                    catch (InvalidOperationException)
                    {
                        Console.WriteLine("De lijst is al leeg");
                    }
                }
                else
                {
                    LetterLijst.Push(input);
                }

            } while (LetterLijst.Count != 0);

            Console.WriteLine("\n\n\u00A9Jonas Staes - AP 2019/2020");          
        }
    }
}
