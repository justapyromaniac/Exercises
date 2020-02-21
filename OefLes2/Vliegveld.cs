using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes2
{
    //klasse om meerdere vliegtuigen in een collection te steken, gewoon omdat het vreemd is om dit te doen in vluchten
    class Vliegveld
    {
        //Fields start

        public Dictionary<int, Vlucht> Vliegtuigen = new Dictionary<int, Vlucht>();

        //Fields end
        //Constructors start


        //Constructor om de methodes to kunnen gebruiken
        public Vliegveld()
        {

        }

        //Constructors end
        //Methods start

        //Deze methodes dienen om de dictionary van vluchten aan te passen
        //Elke vlucht heeft een vluchtnummer dat increment, dus vraag enkel om die vlucht
        public bool VoegVluchtToe(Vlucht vlucht)
        {
            if (vlucht != null)
            {
                Vliegtuigen.Add(vlucht.Vluchtnummer, vlucht);
                return true;
            }
            return false;
        }

        public bool VerwijderVlucht(Vlucht vlucht)
        {
            if (vlucht != null)
            {
                Vliegtuigen.Remove(vlucht.Vluchtnummer);
                return true;
            }
            return false;
        }

        public Vlucht VindVlucht(int vluchtNummer)
        {
            Vlucht output = null;
            if (Vliegtuigen.ContainsKey(vluchtNummer))
            {
                output = Vliegtuigen[vluchtNummer];
            }
            return output;
        }
        //Methods end

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("Op dit vliegveld staan de volgende vliegtuigen");
            foreach(KeyValuePair<int, Vlucht> pair in Vliegtuigen)
            {
                output.AppendLine($"Vlucht {pair.Key}");
            }
            return output.ToString();
        }
    }
}
