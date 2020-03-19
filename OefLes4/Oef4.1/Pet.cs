using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._1
{
    abstract class Pet
    {
        public static Random generator = new Random();

        public string Name { get; set; }

        public decimal Weight { get; set; }

        public DateTime BirthDate { get; set; }

        public Pet(string name, decimal weight, DateTime birthDate)
        {
            Name = name;
            Weight = weight;
            BirthDate = birthDate;
        }

        #region "Show exact age"
        //purely for display

        public string ShowExactAge(DateTime date)
        {
            int ageYears = date.Year - BirthDate.Year;
            int ageMonths = date.Month - BirthDate.Month;
            int ageDays = date.Day - BirthDate.Day;

            if (date.DayOfYear < BirthDate.DayOfYear)
            {
                ageYears--;
            }

            if(date.Month < BirthDate.Month)
            {
                ageMonths--;
            }

            if(date.Day < BirthDate.Day)
            {
                ageDays--;
            }
            return $"{ageYears:###0} years {ageMonths:#0} months {ageDays:#0} days";
        }

        public string ShowExactAge()
        {
            return ShowExactAge(DateTime.Today);
        }

        #endregion

        public int CalculateAge(DateTime date)
        {
            int age = date.Year - BirthDate.Year;

            if (date.DayOfYear < BirthDate.DayOfYear)
            {
                age--;
            }
            return age;
        }

        public int CalculateAge()
        {
            return CalculateAge(DateTime.Today);
        }

        public virtual string MakeNoise()
        {
            return "Grom grom";
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Weight: {Weight:#0.##} kg");
            output.AppendLine($"Age: {ShowExactAge()}");
            return output.ToString(); 
        }
    }
}
