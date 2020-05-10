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


        public SportsCar(string brand, string make, DateTime inUseDate, string licensePlate, int horsePower, int speeds) : base(brand, make, inUseDate, licensePlate)
        {
            HorsePower = horsePower;
            Speeds = speeds;
        }

        public override int CalculateFuelConsumption(int years)
        {
            int NieuwVerbruik = base.CalculateFuelConsumption(years);
            if(Speeds >= 6)
            {
                NieuwVerbruik += ((base.CalculateFuelConsumption(years) / 100) * 20);
            }
            return NieuwVerbruik;
        }

        public override int CalculateFuelConsumption()
        {
            int jaren = DateTime.Today.Year - InUseDate.Year;
            return this.CalculateFuelConsumption(jaren);
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
