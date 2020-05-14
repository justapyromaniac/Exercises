using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetirementHomeActivities
{
    public partial class Form1 : Form
    {
        List<Inhabitant> inhabitants;
        public Form1()
        {
            InitializeComponent();
            inhabitants = new List<Inhabitant>();

            inhabitants.Add(new Inhabitant("Karen", "White", 10, Floors.Floor3));
            inhabitants.Add(new Inhabitant("Susan", "Black", 20));
            inhabitants.Add(new SenileInhabitant("Tracy", "Gray", 2));

            cbActivities.DataSource = Enum.GetValues(typeof(ActivityTypes));
            cbInhabitants.DataSource = inhabitants;
        }

        private void btAddActivity_Click(object sender, EventArgs e)
        {
            Inhabitant selectedInhabitant = (Inhabitant)cbInhabitants.SelectedItem;

            Activity activity = new Activity((ActivityTypes)cbActivities.SelectedItem, DateTime.Parse(mtbActivityDate.Text));
            string feedback = selectedInhabitant.AddActivity(activity);
            MessageBox.Show(feedback, "Feedback", MessageBoxButtons.OK);
        }
    }
}
