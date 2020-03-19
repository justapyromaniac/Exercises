using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._2
{
    class SportsCar : Car
    {
        public int HorsePower { get; set; }

        private int speeds;

        public int Speeds 
        {
            get { return speeds; } 
            set
            {
                if(value > 8)
                {
                    speeds = 8;
                }
                else
                {
                    speeds = value;
                }
            }
        }


        public SportsCar(string brand, string make, DateTime unUseDate, string numberPlate, int horsePower, int speeds) : base(brand, make, unUseDate, numberPlate)
        {
            HorsePower = horsePower;
            Speeds = speeds;
        }

        public override int CalculateFuelConsumption(int jaren)
        {
            int NieuwVerbruik = base.CalculateFuelConsumption(jaren);
            if(Speeds >= 6)
            {
                NieuwVerbruik += ((base.CalculateFuelConsumption(jaren) / 100) * 20);
            }
            return NieuwVerbruik;
        }

        public override int CalculateFuelConsumption()
        {
            int jaren = DateTime.Today.Year - InUseDate.Year;
            return this.CalculateFuelConsumption(jaren);
        }

        public static Car MakeRandomCar()
        {
            List<string> brands = new List<string>
            {
                "Alfa Romeo",
                "Aston Martin",
                "Bentley",
                "BMW",
                "Bugatti",
                "Ferrari",
                "Jaguar",
                "Lamborghini",
                "Porsche",
                "Tesla"
            };

            List<string> makes = new List<string>
            {
                "4C",
                "DB10",
                "Continental GT",
                "M4 GTS",
                "Chiron",
                "488 Pista",
                "F-Type SVR",
                "Aventador S",
                "Panamera",
                "Roadster"
            };

            string randomBrand = brands[generator.Next(brands.Count)];
            string randomMake = makes[generator.Next(makes.Count)];
            int randomYear = generator.Next(DateTime.Today.Year - 30, DateTime.Today.Year);
            int randomMonth = generator.Next(1, DateTime.Today.Month + 1);
            int randomDay = generator.Next(1, DateTime.Today.Day + 1);
            DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
            string randomNumberPlate = $"{generator.Next(0, 10):0}-{generator.Next(0, 49):X3}-{generator.Next(0,1000):000}";
            int randomHorsePower = generator.Next(100, 501);
            int randomSpeeds = generator.Next(1, 10);
            return new SportsCar(randomBrand, randomMake, randomDate, randomNumberPlate, randomHorsePower, randomSpeeds);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Horse power: {HorsePower}");
            output.AppendLine($"Speeds: {Speeds}");
            return base.ToString() + output.ToString();
        }
    }
}
