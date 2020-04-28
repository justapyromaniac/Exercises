using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMBD
{
    class Series : Media
    {
        #region "Properties"

        public int Seasons { get; set; }

        #endregion "Properties"

        #region "Constructors"

        public Series(string titel, decimal? rating, int seasons) : base(titel, rating)
        {
            Seasons = seasons;
        }

        #endregion "Constructors"

        #region "Methods"

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            return base.ToString(); 
        }

        #endregion "Methods"
    }
}
