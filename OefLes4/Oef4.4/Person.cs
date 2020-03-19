using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._4
{
    class Person
    {
        public static Random generator = new Random();
        public string LastName { get; private set; }

        public string FirstName { get; private set; }

        public List<string> Styles { get; }

        public Person(string lastName, string firstName, string style)
        {
            LastName = lastName;
            FirstName = firstName;
            Styles = new List<string>();
            Styles.Add(style);
            FillListStyles();
        }

        private bool FillListStyles()
        {
            Styles.Add("R&B");
            Styles.Add("Rock");
            Styles.Add("Dance");
            return true;
        }

        public string GetPersonName()
        {
            return $"{FirstName} {LastName}";
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {FirstName} {LastName}");
            output.AppendLine($"Styles: ");
            foreach (string style in Styles)
            {
                output.AppendLine($"{style}");
            }
            return output.ToString();
        }
    }
}
