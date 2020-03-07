using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes3.Oef3._2
{
    class Departement
    {
        public string Naam { get; set; }

        public List<Werknemer> Werknemers { get; }

        public Departement(string naam)
        {
            Naam = naam;
            Werknemers = new List<Werknemer>();
        }

        public Departement() : this("Wetenschappen en techniek")
        {

        }

        #region "Methodes"

        #region "Methodes Werknemers"

        public string GeefWerknemers()
        {
            StringBuilder output = new StringBuilder();
            if(Werknemers.Count != 0)
            {
                output.AppendLine($"In dit departement werken: ");
                foreach (Werknemer werknemer in Werknemers)
                {
                    output.AppendLine(werknemer.ToString());
                }
            }
            else
            {
                output.AppendLine("De lijst werknemers is leeg");
            }
            return output.ToString();
        }

        public Werknemer VindWerknemer(Werknemer input)
        {
            Werknemer output = null;
            foreach (Werknemer werknemer in Werknemers)
            {
                if(werknemer == input)
                {
                    output = werknemer;
                }
            }
            return output;
        }

        public bool VoegWerknemerToe(Werknemer input)
        {
            if(input != null)
            {
                if(Werknemers.Contains(input))
                {
                    return false;
                }
                else
                {
                    Werknemers.Add(input);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public bool VerwijderWerknemer(Werknemer input)
        {
            if (input != null)
            {
                if (Werknemers.Contains(input))
                {
                    Werknemers.Remove(input);
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

        #endregion "Methodes Werknemers"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Departement {Naam}");
            if(Werknemers.Count != 0)
            {
                output.AppendLine(GeefWerknemers());
            }
            return output.ToString();
        }

        #endregion "Methodes"
    }
}
