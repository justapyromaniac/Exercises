using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGame
{
    public partial class Form1 : Form
    {
        private const int STARTINGMONEY = 100;
        private Dice dice;
        private Game game;
        private List<float> rolls = new List<float>();
        private int counter = 0;
        public Form1()
        {
            InitializeComponent();
            dice = new Dice(6);
            game = new Game(STARTINGMONEY, dice);
            tbGameOutput.Text = $"Click the button to start! Money: {STARTINGMONEY}";
        }

        private void btGame_Click(object sender, EventArgs e)
        {
            counter++;
            lblRolls.Text = $"Rolls: {counter}";
            int roll = game.Dice.TossDice();
            rolls.Add(roll);
            lbRolls.Items.Add(roll);
            tbAverage.Text = $"Your roll average: {(rolls.Sum() / rolls.Count()):0.00}";
            if (game.MakeBet(roll) > 0)
            {
                tbGameOutput.Text = $"You rolled a {roll}. Current balance: {game.Money}";
            }
            else
            {
                tbGameOutput.Text = "Game Over";
                btGame.Enabled = false;
            }
        }
    }
}
