using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes3
{
    //Een basis klasse, deze wordt geinherit door film en serie
    //Dit is voor volgende les, ik doe het nu al omdat dit makkelijker werkt
    //Dit is niet nodig voor de oefening, kopieer de code here in the klassen film en serie
    abstract class Media
    {
        public static Random generator = new Random();

        #region "Properties"

        public string Titel { get; set; }

        private List<Persoon> Acteurs { get; }

        private List<decimal> Ratings { get; }

        #endregion "Properties"

        #region "Constructors"

        //nullable type, dit "mag" van de leerkracht omdat dit de beste oplossing hierop is
        //als jullie geen inheritance doen, bestaat dit probleem noet. Maak gewoon 2 constructors
        //1 Met slechts titel en dan 1 die die contstructor chained met rating erbij
        public Media(string titel, decimal? rating)
        {
            Titel = titel;
            Ratings = new List<decimal>();
            Acteurs = new List<Persoon>();
            //een null check, dit is nodig om te kijken of rating effectief een value heeft
            if (rating is decimal Value)
            {
                VoegRatingToe(Value);
            }
        }

        #endregion "Constructors"

        #region "Methodes"

        #region "Methodes Ratings"

        #region "Methodes Lijst"

        public string GeefLijstRatings()
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
                output.Append("De lijst van ratings is leeg");
            }
            return output.ToString();
        }

        public bool VerwijderRating(decimal input)
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

        public bool VoegRatingToe(decimal input)
        {
            if(input >= 1 && input <= 5)
            {
                Ratings.Add(input);
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion "Methodes Lijst"

        #region "Methodes gemiddelde"

        public decimal BerekenGemiddeldeRating()
        {
            return Math.Round((Ratings.Sum() / Ratings.Count), 2);
        }

        public decimal BerekenZonderExtremen()
        {
            decimal min = Ratings.Min();
            decimal max = Ratings.Max();
            Ratings.Remove(min);
            Ratings.Remove(max);
            decimal output = BerekenGemiddeldeRating();
            Ratings.Add(min);
            Ratings.Add(max);
            return output;
        }

        #endregion "Methodes gemiddelde"

        #endregion "Methodes Ratings"

        #region "Methodes acteurs"

        public string GeefLijstActeurs()
        {
            StringBuilder output = new StringBuilder();
            if(Acteurs.Count != 0)
            {
                output.AppendLine("Acteurs: ");
                foreach (Persoon acteur in Acteurs)
                {
                    output.AppendLine($"\t{acteur.GeefNaam()}");
                }
            }
            else
            {
                output.AppendLine("De lijst van acteurs is leeg");
            }
            return output.ToString();
        }

        public Persoon VindActeur(Persoon input)
        {
            Persoon output = null;
            foreach (Persoon acteur in Acteurs)
            {
                if (acteur == input)
                {
                    output = acteur;
                }
            }
            return output;
        }

        public bool VoegActeurToe(Persoon acteur)
        {
            if(acteur != null)
            {
                if(Acteurs.Contains(acteur))
                {
                    return false;
                }
                else
                {
                    Acteurs.Add(acteur);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool VerwijderActeur(Persoon acteur)
        {
            if (acteur != null)
            {
                if (Acteurs.Contains(acteur))
                {
                    Acteurs.Remove(acteur);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #endregion "Methodes acteurs"

        //abstracte methode, dit zal je zien bij inheritance
        public static Media MaakRandomMedia()
        {
            return null;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Titel: {Titel}");
            if(Ratings.Count != 0)
            {
                output.AppendLine($"Rating: {BerekenGemiddeldeRating()}");
            }
            return output.ToString();
        }

        #endregion "Methodes"
    }
}
