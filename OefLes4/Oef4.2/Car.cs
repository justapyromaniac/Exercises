using System;
using System.Text;

namespace OefLes4.Oef4._2
{
    abstract class Car
    {
        public static Random generator = new Random();
        public string Brand { get; set; }

        public string Make { get; set; }

        public int KilometerCount { get; set; }

        public DateTime InUseDate { get; set; }

        public string NumberPlate { get; set; }

        protected Car(string brand, string make, DateTime inUseDate, string numberPlate)
        {
            Brand = brand;
            Make = make;
            InUseDate = inUseDate;
            NumberPlate = numberPlate;
            KilometerCount = CalculateKilometers();
        }

        public int CalculateKilometers(int years)
        {
            const int KILOMETERSPERYEAR = 20000;
            KilometerCount = years * KILOMETERSPERYEAR;
            return KilometerCount;
        }

        public int CalculateKilometers()
        {
            int years = DateTime.Today.Year - InUseDate.Year;
            return CalculateKilometers(years);
        }

        public virtual int CalculateFuelConsumption(int years)
        {
            const int KILOMETERSPERYEAR = 20000;
            int totalKilometers = KILOMETERSPERYEAR * years;
            //5 liter  / 100 kilometer. Dus eerst zien hoeveel keer 100 km is gereden en dan * 5.
            //ints omdat het aantalkilometers nooit een kommagetal zal zijn
            //20000 / 100 is 200, dit is de kleinste mogelijkhijd
            int totalFuelUsed = (totalKilometers / 100) * 5;
            return totalFuelUsed;
        }

        public virtual int CalculateFuelConsumption()
        {
            int years = DateTime.Today.Year - InUseDate.Year;
            return CalculateFuelConsumption(years);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Brand and make: {Brand} {Make}");
            output.AppendLine($"Numberplate: {NumberPlate}");
            output.AppendLine($"In use since: {InUseDate:yyyy-MM-dd}");
            output.AppendLine($"Kilometer count: {KilometerCount} km");
            output.AppendLine($"Fuel used: {CalculateFuelConsumption()} L");
            return output.ToString(); 
        }
    }
}
