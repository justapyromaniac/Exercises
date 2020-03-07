using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes3
{
    //Dit is inheritance
    class Film : Media
    {
        #region "Properties"

        public enum Genres { actie, fantasy }

        public string Producer { get; set; }

        public Persoon Regisseur { get; set; }

        public Genres Genre { get; set; }

        public int ReleaseJaar { get; set; }

        #endregion "Properties"

        #region "Constructors"

        public Film(string titel, decimal? rating, string producer, Persoon regisseur, Genres genre, int releaseJaar) : base(titel, rating)
        {
            Producer = producer;
            Regisseur = regisseur;
            Genre = genre;
            ReleaseJaar = releaseJaar;
        }

        #endregion "Constructors"

        #region "Methodes"

        public new static Media MaakRandomMedia()
        {
            List<string> titels = new List<string>
            {
                "Lord of the rings",
                "Terminator",
            };
            List<string> producers = new List<string>
            {
                "Paramount",
                "Netflix",
                "Warner bros"
            };
            string randomTitel = titels[generator.Next(titels.Count)];
            decimal randomRating = generator.Next(0, 7);
            string randomProducer = producers[generator.Next(titels.Count)];
            Persoon randomPersoon = Persoon.MaakRandomPersoon();
            Genres randomGenre = (Genres)generator.Next(1);
            int randomJaar = generator.Next(1980, DateTime.Today.Year);
            return new Film(randomTitel, randomRating, randomProducer, randomPersoon, randomGenre, randomJaar);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Producer: {Producer}");
            output.AppendLine($"Regissuer: {Regisseur.GeefNaam()}");
            output.AppendLine($"Genre: {Genre}");
            output.AppendLine($"Release jaar: {ReleaseJaar}");
            return base.ToString() + output.ToString();
        }

        #endregion "Methodes"
    }
}
