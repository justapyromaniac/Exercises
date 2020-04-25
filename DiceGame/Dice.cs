using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    public class Dice
    {
        static readonly Random generator = new Random();

        public int Sides { get; set; }

        public Dice(int sides)
        {
            Sides = sides;
        }

        public int TossDice(int amount)
        {
            List<int> values = new List<int>();
            for (int index = 0; index < amount; index++)
            {
                values.Add(generator.Next(1, (Sides + 1)));
            }
            return values.Sum();
        }

        public int TossDice()
        {
            return TossDice(1);
        }

        public override string ToString()
        {
            return $"Sides: {Sides}";
        }
    }
}
