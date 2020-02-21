using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes2
{
    class AfkortingDictionary
    {
        public Dictionary<string, string> Afkortingen = new Dictionary<string, string>();

        public AfkortingDictionary()
        {
            Afkortingen.Add("BRB", "Be right back");
            Afkortingen.Add("K", "okay");
            Afkortingen.Add("LOL", "Laughing out loud");
            Afkortingen.Add("SMH", "Shaking my head");
        }

        public string VerwijderAfkorting(string key)
        {
            string output = "";
            if (Afkortingen.ContainsKey(key))
            {
                output = $"De afkorting van {Afkortingen[key]} is succesvol verwijderd";
                Afkortingen.Remove(key);
            }
            else
            {
                output = "Deze afkorting zit niet in de dictionary";
            }
            return output;
        }

        public string VoegAfkortingToe(string key, string value)
        {
            string output = "";
            if(Afkortingen.ContainsKey(key))
            {
                output = $"Deze afkorting wordt al gebruikt voor de afkorting van {Afkortingen[key]}";
            }
            else
            {
                Afkortingen.Add(key, value);
                output = $"De zin {value} is toegevoegd met afkorting {key}";
            }
            return output;
        }

        public string LeesAfkorting(string key)
        {
            StringBuilder output = new StringBuilder();
            if (Afkortingen.ContainsKey(key))
            {
                output.Append(Afkortingen[key]);
            }
            else
            {
                output.Append("Deze afkorting is nog niet toegevoegd in deze dictionary!");
            }
            return output.ToString();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("De dictionary bevat de volgende afkortingen");
            foreach (KeyValuePair<string, string> pair in Afkortingen)
            {
                output.AppendLine($"De afkorting van {pair.Value} met als afkorting {pair.Key}");
            }
            return output.ToString();
        }
    }
}
