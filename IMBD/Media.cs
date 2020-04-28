using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMBD
{
    abstract class Media
    {
        public static Random generator = new Random();

        #region "Properties"

        public string Title { get; set; }

        private List<decimal> Ratings { get; }

        #endregion "Properties"

        #region "Constructors"

        //nullable type, dit "mag" van de leerkracht omdat dit de beste oplossing hierop is
        //als jullie geen inheritance doen, bestaat dit probleem noet. Maak gewoon 2 constructors
        //1 Met slechts titel en dan 1 die die contstructor chained met rating erbij
        public Media(string titel, decimal? rating)
        {
            Title = titel;
            Ratings = new List<decimal>();
            //een null check, dit is nodig om te kijken of rating effectief een value heeft
            if (rating is decimal Value)
            {
                AddRating(Value);
            }
        }

        #endregion "Constructors"

        #region "Methods"

        #region "Methods Ratings"

        #region "Methods List"

        public string GiveListRatings()
        {
            StringBuilder output = new StringBuilder();
            if(Ratings.Count != 0)
            {
                output.AppendLine("Ratings: ");
                foreach (decimal rating in Ratings)
                {
                    output.AppendLine($"{rating}");
                }
            }
            else
            {
                output.Append("This movie has no ratings");
            }
            return output.ToString();
        }

        public bool RemoveRating(decimal input)
        {
            if(Ratings.Contains(input))
            {
                Ratings.Remove(input);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool AddRating(decimal input)
        {
            if(input >= 0.01M && input <= 5)
            {
                Ratings.Add(input);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion "Methods List"

        #region "Methods average"

        public decimal CalculateAverageRating()
        {
            return Math.Round((Ratings.Sum() / Ratings.Count), 2);
        }

        public decimal CalculateWithoutExtremes()
        {
            decimal min = Ratings.Min();
            decimal max = Ratings.Max();
            Ratings.Remove(min);
            Ratings.Remove(max);
            decimal output = CalculateAverageRating();
            Ratings.Add(min);
            Ratings.Add(max);
            return output;
        }

        #endregion "Methods average"

        #endregion "Methods Ratings"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"{Title} ");
            return output.ToString();
        }

        #endregion "Methods"
    }
}
