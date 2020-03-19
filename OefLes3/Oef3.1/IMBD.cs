using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes3
{
    class IMBD
    {
        #region "Properties"

        private List<Film> Films { get; }

        private List<Serie> Series { get; }

        #endregion "Properties"

        #region "Constructors"

        public IMBD()
        {
            Films = new List<Film>();
            Series = new List<Serie>();
        }

        #endregion "Constructors"

        #region "Methodes"

        #region "Methodes Films"

        public string GeefFilms()
        {
            StringBuilder output = new StringBuilder();
            if(Films.Count != 0)
            {
                output.AppendLine("Films: ");
                foreach (Film film in Films)
                {
                    output.AppendLine($"{film}");
                }
            }
            else
            {
                output.AppendLine("De lijst van films is leeg");
            }
            return output.ToString();
        }
        public Film VindFilm(Media input)
        {
            Film output = null;
            foreach (Film film in Films)
            {
                if(film == input)
                {
                    output = film;
                }
            }
            return output;
        }

        public bool VoegFilmToe(Media input)
        {
            if(input != null)
            {
                if (Films.Count != 0)
                {
                    if (Films.Contains(input))
                    {
                        return false;
                    }
                    else
                    {
                        Films.Add((Film)input);
                        return true;
                    }
                }
                else
                {
                    Films.Add((Film)input);
                    return true;
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
            
        }

        public bool VerwijderFilm(Media input)
        {
            if (input != null)
            {
                if (Films.Count != 0)
                {
                    if (Films.Contains(input))
                    {
                        Films.Remove((Film)input);
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
            else
            {
                throw new ArgumentNullException();
            }
        }

        #endregion "Methodes Films"

        #region "Methodes Series"

        public string GeefSeries()
        {
            StringBuilder output = new StringBuilder();
            if (Series.Count != 0)
            {
                output.AppendLine("Series: ");
                foreach (Serie serie in Series)
                {
                    output.AppendLine($"{serie}");
                }
            }
            else
            {
                output.AppendLine("De lijst van series is leeg");
            }
            return output.ToString();
        }
        public Serie VindSerie(Media input)
        {
            Serie output = null;
            foreach (Serie serie in Series)
            {
                if (serie == input)
                {
                    output = serie;
                }
            }
            return output;
        }

        public bool VoegSerieToe(Media input)
        {
            if(input != null)
            {
                if(Series.Count != 0)
                {
                    if (Series.Contains(input))
                    {
                        return false;
                    }
                    else
                    {
                        Series.Add((Serie)input);
                        return true;
                    }
                }
                else
                {
                    Series.Add((Serie)input);
                    return true;
                }              
            }  
            else
            {
                return false;
            }
        }

        public bool VerwijderSerie(Media input)
        {
            if(input != null)
            {
                if(Series.Count != 0)
                {
                    if (Series.Contains(input))
                    {
                        Series.Remove((Serie)input);
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
            else
            {
                return false;
            }
        }

        #endregion "Methodes Series"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine("IMBD: ");
            output.AppendLine(GeefFilms());
            output.AppendLine(GeefSeries());
            return output.ToString();
        }

        #endregion "Methodes"
    }
}
