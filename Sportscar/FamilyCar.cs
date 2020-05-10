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

        public FamilyCar(string brand, string model, DateTime inUseDate, string licensePlate, int seats, decimal trunkSpace) : base(brand, model, inUseDate, licensePlate)
        {
            Seats = seats;
            TrunkSpace = trunkSpace;
        }

        public override int CalculateFuelConsumption(int years)
        {
            int NieuwVerbruik = base.CalculateFuelConsumption(years);
            if (Seats >= 7)
            {
                NieuwVerbruik += ((base.CalculateFuelConsumption(years) / 100) * 10);
            }
            return NieuwVerbruik;
        }

        public override int CalculateFuelConsumption()
        {
            int years = DateTime.Today.Year - InUseDate.Year;
            return this.CalculateFuelConsumption(years);
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
