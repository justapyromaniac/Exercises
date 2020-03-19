using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._1
{
    class Cat : Pet
    {
        public enum FurTypes { @short, @long }

        public FurTypes Fur { get; set; }

        public Cat(string name, decimal weight, DateTime birthDate, FurTypes fur) : base(name, weight, birthDate)
        {
            Fur = fur;
        }

        public override string MakeNoise()
        {
            return "Meow meow";
        }

        #region "Make random pet"

        public static Pet MakeRandomPet()
        {
            List<string> names = new List<string>
            {
                "Beans",
                "Misty",
                "Oreo",
                "Milo",
                "Cheeto",
                "Mr.Pirate",
                "Lallewallewowo",
                "Kato",
                "Afrolatje"
            };
            string randomName = names[generator.Next(names.Count)];
            int randomYear = generator.Next(DateTime.Today.Year - 10, DateTime.Today.Year + 1);
            int randomMonth = generator.Next(1, DateTime.Today.Month + 1);
            int randomDay = generator.Next(1, DateTime.Today.Day + 1);
            DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
            decimal randomWeight = ((decimal)generator.Next(100, 2001)) / 100;
            if (randomYear >= DateTime.Today.Year)
            {
                randomWeight /= 10;
            }
            FurTypes randomFur = (FurTypes)generator.Next(2);
            return new Cat(randomName, randomWeight, randomDate, randomFur);
        }

        #endregion "Make random pet"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Fur: {Fur}");
            return base.ToString() + output.ToString();
        }
    }
}
