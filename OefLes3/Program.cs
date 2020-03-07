using OefLes3.Oef3._2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes3
{
    class Program
    {
        static Random generator = new Random();
        static void Main(string[] args)
        {

            #region "Oef 3.1"

            const int UNDERMINIMUM = 0;
            const int OVERMAXIMUM = 7;

            const int MINIMUM = 1;
            const int MAXIMUM = 6;

            #region "Objecten toevoegen"

            Console.WriteLine("------ Oef 3.1 ------");
            Console.WriteLine();

            #region "Films"

            Media film1 = Film.MaakRandomMedia();
            Media film2 = Film.MaakRandomMedia();
            Media film3 = Film.MaakRandomMedia();
            Media film4 = Film.MaakRandomMedia();

            Console.WriteLine("----- Films -----");
            Console.WriteLine();

            Console.WriteLine("----- Films aanmaken -----");
            Console.WriteLine();
            Console.WriteLine(film1);
            Console.WriteLine(film2);
            Console.WriteLine(film3);
            Console.WriteLine(film4);
            Console.WriteLine();

            #endregion "Films"

            #region "Serie"

            Media serie1 = Serie.MaakRandomMedia();
            Media serie2 = Serie.MaakRandomMedia();
            Media serie3 = Serie.MaakRandomMedia();
            Media serie4 = Serie.MaakRandomMedia();

            Console.WriteLine("----- Series -----");
            Console.WriteLine();

            Console.WriteLine("----- Series aanmaken -----");
            Console.WriteLine();
            Console.WriteLine(serie1);
            Console.WriteLine(serie2);
            Console.WriteLine(serie3);
            Console.WriteLine(serie4);
            Console.WriteLine();
          

            #endregion "Serie"

            #region "IMBD"

            IMBD imbd = new IMBD();
            Console.WriteLine("------ IMBD -----");
            Console.WriteLine();

            Console.WriteLine("----- Lijst films tonen -----");
            Console.WriteLine();
            Console.WriteLine(imbd.GeefFilms());
            Console.WriteLine();

            Console.WriteLine("----- Films toevoegen -----");
            Console.WriteLine();
            Console.WriteLine(imbd.VoegFilmToe(film1));
            Console.WriteLine(imbd.VoegFilmToe(film2));
            Console.WriteLine(imbd.VoegFilmToe(film3));
            Console.WriteLine(imbd.VoegFilmToe(film4));
            Console.WriteLine();

            Console.WriteLine("----- Lijst films tonen -----");
            Console.WriteLine();
            Console.WriteLine(imbd.GeefFilms());
            Console.WriteLine();

            Console.WriteLine("----- Lijst series tonen -----");
            Console.WriteLine();
            Console.WriteLine(imbd.GeefSeries());
            Console.WriteLine();

            Console.WriteLine("----- Series toevoegen -----");
            Console.WriteLine();
            Console.WriteLine(imbd.VoegSerieToe(serie1));
            Console.WriteLine(imbd.VoegSerieToe(serie2));
            Console.WriteLine(imbd.VoegSerieToe(serie3));
            Console.WriteLine(imbd.VoegSerieToe(serie4));
            Console.WriteLine();

            Console.WriteLine("----- Lijst series tonen -----");
            Console.WriteLine();
            Console.WriteLine(imbd.GeefSeries());
            Console.WriteLine();

            Console.WriteLine("----- Volledige IMBD tonen -----");
            Console.WriteLine();
            Console.WriteLine(imbd);
            Console.WriteLine();

            #endregion "IMBD"

            #endregion "Objecten toevoegen"

            #region "Methodes testen"

            #region "Test film"

            Console.WriteLine("----- Testen van methodes Films -----");
            Console.WriteLine();

            Console.WriteLine("----- Lijst films -----");
            Console.WriteLine();
            Console.WriteLine(imbd.GeefFilms());
            Console.WriteLine();

            Console.WriteLine("----- Opzoeken film -----");
            Console.WriteLine();
            Console.WriteLine(imbd.VindFilm(film1));
            Console.WriteLine();

            #region "Ratings"

            Console.WriteLine("----- Ratings -----");
            Console.WriteLine();

            Console.WriteLine("----- Lijst ratings tonen -----");
            Console.WriteLine();
            Console.WriteLine(film1.GeefLijstRatings());
            Console.WriteLine();

            Console.WriteLine("----- Ratings toevoegen -----");
            Console.WriteLine();
            Console.WriteLine(film1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(film1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(film1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(film1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(film1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(film1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(film1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(film1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(film1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(film1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine();
            Console.WriteLine($"Gemiddelde: {film1.BerekenGemiddeldeRating()}");
            Console.WriteLine($"Gemiddelde zonder extremen: {film1.BerekenZonderExtremen()}");
            Console.WriteLine();

            Console.WriteLine("----- Lijst ratings tonen -----");
            Console.WriteLine(film1.GeefLijstRatings());
            Console.WriteLine();
            Console.WriteLine(film1);
            Console.WriteLine();

            Console.WriteLine("----- Ratings verwijderen -----");
            Console.WriteLine();
            Console.WriteLine(film1.VerwijderRating(generator.Next(MINIMUM, MAXIMUM)));
            Console.WriteLine(film1.VerwijderRating(generator.Next(MINIMUM, MAXIMUM)));
            Console.WriteLine(film1.VerwijderRating(generator.Next(MINIMUM, MAXIMUM)));
            Console.WriteLine(film1.VerwijderRating(generator.Next(MINIMUM, MAXIMUM)));
            Console.WriteLine();
            Console.WriteLine($"Gemiddelde: {film1.BerekenGemiddeldeRating()}");
            Console.WriteLine($"Gemiddelde zonder extremen: {film1.BerekenZonderExtremen()}");
            Console.WriteLine();

            Console.WriteLine("----- Lijst ratings tonen -----");
            Console.WriteLine();
            Console.WriteLine(film1.GeefLijstRatings());
            Console.WriteLine();
            Console.WriteLine(film1);
            Console.WriteLine();

            #endregion "Ratings"

            #region "Acteurs"

            Console.WriteLine("----- Acteurs -----");
            Console.WriteLine();

            Console.WriteLine("----- Lijst acteurs tonen -----");
            Console.WriteLine();
            Console.WriteLine(film1.GeefLijstActeurs());
            Console.WriteLine();

            Console.WriteLine("----- Acteurs aanmaken -----");
            Console.WriteLine();
            Persoon acteur1 = Persoon.MaakRandomPersoon();
            Persoon acteur2 = Persoon.MaakRandomPersoon();
            Persoon acteur3 = Persoon.MaakRandomPersoon();
            Persoon acteur4 = Persoon.MaakRandomPersoon();
            Console.WriteLine(acteur1);
            Console.WriteLine(acteur2);
            Console.WriteLine(acteur3);
            Console.WriteLine(acteur4);
            Console.WriteLine();

            Console.WriteLine("----- Actaurs toevoegen -----");
            Console.WriteLine();
            Console.WriteLine(film1.VoegActeurToe(acteur1));
            Console.WriteLine(film1.VoegActeurToe(acteur2));
            Console.WriteLine(film1.VoegActeurToe(acteur3));
            Console.WriteLine(film1.VoegActeurToe(acteur4));
            Console.WriteLine();

            Console.WriteLine("----- Lijst acteurs tonen -----");
            Console.WriteLine();
            Console.WriteLine(film1.GeefLijstActeurs());
            Console.WriteLine();

            Console.WriteLine("----- Acteur verwijderen -----");
            Console.WriteLine();
            Console.WriteLine(film1.VerwijderActeur(acteur1));
            Console.WriteLine();

            Console.WriteLine("----- Lijst acteurs tonen -----");
            Console.WriteLine();
            Console.WriteLine(film1.GeefLijstActeurs());
            Console.WriteLine();

            #endregion "Acteurs"

            imbd.VerwijderFilm(film1);
            Console.WriteLine("----- Film verwijderen -----");
            Console.WriteLine();
            Console.WriteLine(imbd.GeefFilms());
            Console.WriteLine();

            #endregion "Test film"

            #region "Test serie"

            Console.WriteLine("----- Testen van methodes Series -----");
            Console.WriteLine();
            Console.WriteLine("----- Lijst series -----");
            Console.WriteLine();
            Console.WriteLine(imbd.GeefSeries());
            Console.WriteLine();
            Console.WriteLine("----- Opzoeken serie -----");
            Console.WriteLine();
            Console.WriteLine(imbd.VindSerie(serie1));
            Console.WriteLine();

            #region "Ratings"

            Console.WriteLine("----- Ratings -----");
            Console.WriteLine();
            Console.WriteLine("----- Lijst ratings tonen -----");
            Console.WriteLine();
            Console.WriteLine(serie1.GeefLijstRatings());
            Console.WriteLine();

            Console.WriteLine("----- Ratings toevoegen -----");
            Console.WriteLine();
            Console.WriteLine(serie1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(serie1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(serie1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(serie1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(serie1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(serie1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(serie1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(serie1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(serie1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine(serie1.VoegRatingToe(generator.Next(UNDERMINIMUM, OVERMAXIMUM)));
            Console.WriteLine();
            Console.WriteLine($"Gemiddelde: {serie1.BerekenGemiddeldeRating()}");
            Console.WriteLine($"Gemiddelde zonder extremen: {serie1.BerekenZonderExtremen()}");
            Console.WriteLine();

            Console.WriteLine("----- Lijst ratings tonen -----");
            Console.WriteLine(serie1.GeefLijstRatings());
            Console.WriteLine();
            Console.WriteLine(serie1);
            Console.WriteLine();

            Console.WriteLine("----- Ratings verwijderen -----");
            Console.WriteLine();
            Console.WriteLine(serie1.VerwijderRating(generator.Next(MINIMUM, MAXIMUM)));
            Console.WriteLine(serie1.VerwijderRating(generator.Next(MINIMUM, MAXIMUM)));
            Console.WriteLine(serie1.VerwijderRating(generator.Next(MINIMUM, MAXIMUM)));
            Console.WriteLine(serie1.VerwijderRating(generator.Next(MINIMUM, MAXIMUM)));
            Console.WriteLine();
            Console.WriteLine($"Gemiddelde: {serie1.BerekenGemiddeldeRating()}");
            Console.WriteLine($"Gemiddelde zonder extremen: {serie1.BerekenZonderExtremen()}");
            Console.WriteLine();

            Console.WriteLine("----- Lijst ratings tonen -----");
            Console.WriteLine();
            Console.WriteLine(serie1.GeefLijstRatings());
            Console.WriteLine();
            Console.WriteLine(serie1);
            Console.WriteLine();

            #endregion "Ratings"

            #region "Acteurs"

            Console.WriteLine("----- Acteurs -----");
            Console.WriteLine();
            Console.WriteLine("----- Lijst acteurs tonen -----");
            Console.WriteLine();
            Console.WriteLine(serie1.GeefLijstActeurs());
            Console.WriteLine();

            Console.WriteLine("----- Acteurs aanmaken -----");
            Console.WriteLine();
            Persoon acteur5 = Persoon.MaakRandomPersoon();
            Persoon acteur6 = Persoon.MaakRandomPersoon();
            Persoon acteur7 = Persoon.MaakRandomPersoon();
            Persoon acteur8 = Persoon.MaakRandomPersoon();
            Console.WriteLine(acteur5);
            Console.WriteLine(acteur6);
            Console.WriteLine(acteur7);
            Console.WriteLine(acteur8);
            Console.WriteLine();

            Console.WriteLine("----- Acteurs toevoegen -----");
            Console.WriteLine();
            Console.WriteLine(serie1.VoegActeurToe(acteur5));
            Console.WriteLine(serie1.VoegActeurToe(acteur6));
            Console.WriteLine(serie1.VoegActeurToe(acteur7));
            Console.WriteLine(serie1.VoegActeurToe(acteur8));
            Console.WriteLine();

            Console.WriteLine("----- Lijst acteurs tonen -----");
            Console.WriteLine();
            Console.WriteLine(serie1.GeefLijstActeurs());
            Console.WriteLine();

            Console.WriteLine("----- Acteur verwijderen -----");
            Console.WriteLine();
            Console.WriteLine(serie1.VerwijderActeur(acteur5));
            Console.WriteLine();

            Console.WriteLine("----- Lijst acteurs tonen -----");
            Console.WriteLine();
            Console.WriteLine(serie1.GeefLijstActeurs());
            Console.WriteLine();

            #endregion "Acteurs"

            imbd.VerwijderSerie(serie1);
            Console.WriteLine("----- Serie verwijderen -----");
            Console.WriteLine();
            Console.WriteLine(imbd.GeefSeries());
            Console.WriteLine();

            #endregion "Test serie"

            #endregion "Methodes testen"

            #endregion "Oef 3.1"

            #region "Oef 3.2"

            #region "Objecten aanmaken"

            Console.WriteLine("----- Oef 3.2 -----");
            Console.WriteLine();

            Werknemer werknemer1 = Werknemer.MaakRandomWerknemer();
            Werknemer werknemer2 = Werknemer.MaakRandomWerknemer();
            Werknemer werknemer3 = Werknemer.MaakRandomWerknemer();
            Werknemer werknemer4 = Werknemer.MaakRandomWerknemer();

            Console.WriteLine("----- Werknemers -----");
            Console.WriteLine();

            Console.WriteLine("----- Werknemers aanmaken -----");
            Console.WriteLine();
            Console.WriteLine(werknemer1);
            Console.WriteLine(werknemer2);
            Console.WriteLine(werknemer3);
            Console.WriteLine(werknemer4);
            Console.WriteLine();

            Departement departement = new Departement();
            Console.WriteLine("----- Departement -----");
            Console.WriteLine();

            Console.WriteLine("----- Lijst werknemers tonen -----");
            Console.WriteLine();
            Console.WriteLine(departement.GeefWerknemers());
            Console.WriteLine();

            Console.WriteLine("----- Werknemers toevoegen -----");
            Console.WriteLine();
            Console.WriteLine(departement.VoegWerknemerToe(werknemer1));
            Console.WriteLine(departement.VoegWerknemerToe(werknemer2));
            Console.WriteLine(departement.VoegWerknemerToe(werknemer3));
            Console.WriteLine(departement.VoegWerknemerToe(werknemer4));
            Console.WriteLine();

            Console.WriteLine("----- Lijst werknemers tonen -----");
            Console.WriteLine();
            Console.WriteLine(departement.GeefWerknemers());
            Console.WriteLine();

            Console.WriteLine("----- Volledig departement tonen -----");
            Console.WriteLine();
            Console.WriteLine(departement);
            Console.WriteLine();

            #endregion "Objecten aanmaken"

            #region "Testen methodes"

            Console.WriteLine("----- Testen van methodes werknemers ------");
            Console.WriteLine();

            Console.WriteLine("----- Lijst werknemers -----");
            Console.WriteLine();
            Console.WriteLine(departement.GeefWerknemers());
            Console.WriteLine();

            Console.WriteLine("----- Opzoeken werknemer -----");
            Console.WriteLine();
            Console.WriteLine(departement.VindWerknemer(werknemer1));
            Console.WriteLine();

            Console.WriteLine("----- Salaris berekenen -----");
            Console.WriteLine();

            Console.WriteLine("----- Werknemer deed voldoende -----");
            Console.WriteLine();

            Console.WriteLine("----- Salaris met anciëniteit megegeven -----");
            decimal loonsVerhoging = generator.Next(50, 401);
            Console.WriteLine();
            Console.WriteLine($"Anciëniteit 25 jaar en loonsverhoging {loonsVerhoging}: {werknemer1.BerekenSalaris(loonsVerhoging, 25)}");
            Console.WriteLine();

            Console.WriteLine("----- Salaris zonder anciëniteit megegeven -----");
            Console.WriteLine();
            Console.WriteLine($"loonsverhoging {loonsVerhoging}: {werknemer1.BerekenSalaris(loonsVerhoging)}");
            Console.WriteLine();

            Console.WriteLine("----- Werknemer deed onvoldoende -----");
            Console.WriteLine();
            werknemer1.SetOnvoldoende();

            Console.WriteLine("----- Salaris met anciëniteit megegeven -----");
            Console.WriteLine();
            Console.WriteLine($"Anciëniteit 25 jaar: {werknemer1.BerekenSalaris(loonsVerhoging, 25)}");
            Console.WriteLine();

            Console.WriteLine("----- Salaris zonder anciëniteit megegeven -----");
            Console.WriteLine();
            Console.WriteLine($"Basissalaris: {werknemer1.BerekenSalaris(loonsVerhoging)}");
            Console.WriteLine();

            #endregion "Testen methodes"

            #endregion "Oef 3.2"

            Console.WriteLine("\n\n\u00A9Jonas Staes - AP 2019/2020");
        }
    }
}
