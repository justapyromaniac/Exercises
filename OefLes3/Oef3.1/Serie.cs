using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes3
{
    class Serie : Media
    {
        #region "Properties"

        public int Seizoenen { get; set; }

        #endregion "Properties"

        #region "Constructors"

        public Serie(string titel, decimal? rating, int seizoenen) : base(titel, rating)
        {
            Seizoenen = seizoenen;
        }

        #endregion "Constructors"

        #region "Methodes"

        public static Media MaakRandomMedia()
        {
            List<string> titels = new List<string>
            {
                "The witcher",
                "Rick and morty"
            };
            string randomTitel = titels[generator.Next(titels.Count)];
            decimal randomRating = generator.Next(0, 7);
            int randomSeizoenen = generator.Next(1, 10);
            return new Serie(randomTitel, randomRating, randomSeizoenen);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Aantal seizoenen: {Seizoenen}");
            return base.ToString(); 
        }

        #endregion "Methodes"
    }
}
