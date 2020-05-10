using System;
using System.Text;

namespace OefLes4.Oef4._2
{
    abstract class Car
    {
        public static Random generator = new Random();
        public string Brand { get; set; }

        public string Model { get; set; }

        public int KilometerCount { get; set; }

        public DateTime InUseDate { get; set; }

        public string LicensePlate { get; set; }

        protected Car(string brand, string model, DateTime inUseDate, string licensePlate)
        {
            Brand = brand;
            Model = model;
            InUseDate = inUseDate;
            LicensePlate = licensePlate;
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
            output.AppendLine($"Brand and make: {Brand} {Model}");
            output.AppendLine($"Numberplate: {LicensePlate}");
            output.AppendLine($"In use since: {InUseDate:yyyy-MM-dd}");
            output.AppendLine($"Kilometer count: {KilometerCount} km");
            output.AppendLine($"Fuel used: {CalculateFuelConsumption()} L");
            return output.ToString(); 
        }
    }
}
