using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGame
{
    class Game
    {
        public int Money { get; set; }
        public Dice Dice { get; set; }

        public Game(int money, Dice dice)
        {
            Money = money;
            Dice = dice;
        }

        public int MakeBet(int roll)
        {
            int output;
            switch (roll)
            {
                case 1:
                    output = 20;
                    break;
                case 6:
                    output = 15;
                    break;
                default:
                    output = -10;
                    break;
            }
            return Money += output;
        }

        public override string ToString()
        {
            return $"Money: {Money}\nDice used: {Dice}";
        }
    }
}
