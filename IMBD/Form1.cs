
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillComboBoxes();
            nudReleaseYear.Maximum = DateTime.Today.Year;
        }

        private void FillComboBoxes()
        {
            cbGenres.DataSource = Enum.GetValues(typeof(Movie.Genres));
            cbDirectorSex.DataSource = Enum.GetValues(typeof(Person.Sexes));
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            bool isMovie = rbMovie.Checked;

            if(isMovie)
            {
                gbMovie.Visible = true;
                gbSeries.Visible = false;
                btAddMedia.Text = "Add Movie";
            }
            else
            {
                gbMovie.Visible = false;
                gbSeries.Visible = true;
                btAddMedia.Text = "Add Series";
            }
        }

        private void btAddMedia_Click(object sender, EventArgs e)
        {
            bool isMovie = rbMovie.Checked;
            if(isMovie)
            {
                Person director = new Person(tbDirectorLastName.Text, tbDirectorFirstName.Text, DateTime.Parse(mtbDirectorBirthDate.Text), (Person.Sexes)cbDirectorSex.SelectedItem);
                Media movie = new Movie(tbTitle.Text, null, tbProducer.Text, director, (Movie.Genres)cbGenres.SelectedItem, int.Parse(nudReleaseYear.Value.ToString()));
                cbMedia.Items.Add(movie);
            }
            else
            {
                Media series = new Series(tbTitle.Text, null, int.Parse(nudSeasons.Value.ToString()));
                cbMedia.Items.Add(series);
            }
        }

        private void btAddRating_Click(object sender, EventArgs e)
        {
            Media selectedMedia = (Media)cbMedia.SelectedItem;
            selectedMedia.AddRating(nudRating.Value);
            tbAverageRating.Text = selectedMedia.CalculateAverageRating().ToString();
        }

        private void tbProducer_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbProducer.Text))
            {
                toolTip1.ToolTipTitle = "Invalid input";
                toolTip1.Show("Please input a name!", tbProducer, 5000);
                btAddMedia.Enabled = false;
            }
            else
            {
                btAddMedia.Enabled = true;
            }
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbTitle.Text))
            {
                toolTip1.ToolTipTitle = "Invalid input";
                toolTip1.Show("Please input a name!", tbTitle, 5000);
                btAddMedia.Enabled = false;
            }
            else
            {
                btAddMedia.Enabled = true;
            }
        }
    }
}
