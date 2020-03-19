using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._2
{
    class FamilyCar : Car
    {
        public int seats;
        public int Seats 
        { 
            get { return seats; } 
            set
            {
                if(value >= 7)
                {
                    seats = 7;
                }
                else
                {
                    seats = value;
                }
            }
        }

        public decimal TrunkSpace { get; set; }

        public FamilyCar(string brand, string make, DateTime inUseDate, string numberPlate, int seats, decimal trunkSpace) : base(brand, make, inUseDate, numberPlate)
        {
            Seats = seats;
            TrunkSpace = trunkSpace;
        }

        public override int CalculateFuelConsumption(int jaren)
        {
            int NieuwVerbruik = base.CalculateFuelConsumption(jaren);
            if (Seats >= 7)
            {
                NieuwVerbruik += ((base.CalculateFuelConsumption(jaren) / 100) * 10);
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
            string randomNumberPlate = $"{generator.Next(0, 10):0}-{generator.Next(0, 49):X3}-{generator.Next(0, 1000):000}";
            int randomTrunkSpace = generator.Next(40, 110);
            int randomSeats = generator.Next(4, 10);
            return new FamilyCar(randomBrand, randomMake, randomDate, randomNumberPlate, randomSeats, randomTrunkSpace);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Seats: {Seats}");
            output.AppendLine($"Trunk space: {TrunkSpace}");
            return base.ToString() + output.ToString();
        }
    }
}
