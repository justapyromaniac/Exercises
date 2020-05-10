using OefLes4.Oef4._2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garage
{
    public partial class Form1 : Form
    {
        private bool isSportsCar;
        private List<Car> Cars = new List<Car>();
        public Form1()
        {
            InitializeComponent();
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            isSportsCar = rbSportsCar.Checked;
            if(isSportsCar)
            {
                lblHorsePower.Text = "Horse power";
                lblSpeeds.Text = "Speed settings";
            }   
            else
            {
                lblHorsePower.Text = "Seats";
                lblSpeeds.Text = "Trunk space";
            }
        }

        private void btAddCar_Click(object sender, EventArgs e)
        {
            if(isSportsCar)
            {
                Car sportscar = new SportsCar(tbBrand.Text, tbModel.Text, DateTime.Parse(mtbInUseDate.Text), mtbLicensePlate.Text, int.Parse(nudHorsePower.Value.ToString()), int.Parse(nudSpeedSettings.Value.ToString()));
                Cars.Add(sportscar);
            }
            else
            {
                Car familycar = new FamilyCar(tbBrand.Text, tbModel.Text, DateTime.Parse(mtbInUseDate.Text), mtbLicensePlate.Text, int.Parse(nudHorsePower.Value.ToString()), int.Parse(nudSpeedSettings.Value.ToString()));
                Cars.Add(familycar);
            }
            lbCars.Items.Clear();
            foreach (Car car in Cars)
            {
                lbCars.Items.Add(car);
            }
        }

        private void btRemoveCar_Click(object sender, EventArgs e)
        {
            foreach (Car car in lbCars.Items)
            {
                if(car.LicensePlate == mtbFindLicensePlate.Text)
                {
                    DialogResult result = MessageBox.Show(car.ToString(), "Remove this car?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        Cars.Remove(car);
                    }
                }
            }
            lbCars.Items.Clear();
            foreach (Car car in Cars)
            {
                lbCars.Items.Add(car);
            }
        }
    }
}
