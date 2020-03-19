using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._4
{
    class Festival
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public DateTime Date { get; set; }

        public List<Artist> Artists { get; }

        public List<Attendee> Attendees { get; }

        public Festival(string name, string location, DateTime date)
        {
            Name = name;
            Location = location;
            Date = date;
            Artists = new List<Artist>();
            Attendees = new List<Attendee>();
        }

        public Festival() : this("A festival", "Antwerp", DateTime.Today)
        {

        }

        #region "Methods List artist"

        public string PrintListArtists()
        {
            StringBuilder output = new StringBuilder();
            if(Artists.Count != 0)
            {
                output.AppendLine($"Artists: ");
                foreach (Artist artist in Artists)
                {
                    output.AppendLine($"{artist}");
                }
            }
            else
            {
                output.AppendLine("There are no artists in the list");
            }
            return output.ToString();
        }

        public Artist FindArtist(string firstname, string lastname)
        {
            string fullname = $"{firstname} {lastname}";
            Artist output = null;
            foreach (Artist artist in Artists)
            {
                if(artist.GetPersonName() == fullname)
                {
                    output = artist;
                }
            }
            return output;
        }

        public bool AddArtist(Artist input)
        {
            if (input != null)
            {
                if (Artists.Count != 0)
                {
                    if (Artists.Contains(input))
                    {
                        return false;
                    }
                    else
                    {
                        Artists.Add(input);
                        return true;
                    }
                }
                else
                {
                    Artists.Add(input);
                    return true;
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public bool RemoveArtist(Artist input)
        {
            if (input != null)
            {
                if (Artists.Count != 0)
                {
                    if (Artists.Contains(input))
                    {
                        Artists.Remove(input);
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

        #endregion "Methods List artist"

        #region "Methods List attendee"

        public string PrintListAttendees()
        {
            StringBuilder output = new StringBuilder();
            if (Attendees.Count != 0)
            {
                output.AppendLine($"Attendees: ");
                foreach (Attendee attendee in Attendees)
                {
                    output.AppendLine($"{attendee}");
                }
            }
            else
            {
                output.AppendLine("There are no attendees in the list");
            }
            return output.ToString();
        }

        public Attendee FindAttendee(string firstname, string lastname)
        {
            string fullname = $"{firstname} {lastname}";
            Attendee output = null;
            foreach (Attendee attendee in Attendees)
            {
                if (attendee.GetPersonName() == fullname)
                {
                    output = attendee;
                }
            }
            return output;
        }

        public bool AddAttendee(Attendee input)
        {
            if (input != null)
            {
                if (Attendees.Count != 0)
                {
                    if (Attendees.Contains(input))
                    {
                        return false;
                    }
                    else
                    {
                        Attendees.Add(input);
                        return true;
                    }
                }
                else
                {
                    Attendees.Add(input);
                    return true;
                }
            }
            else
            {
                throw new ArgumentNullException();
            }
        }

        public bool RemoveAttendee(Attendee input)
        {
            if (input != null)
            {
                if (Attendees.Count != 0)
                {
                    if (Attendees.Contains(input))
                    {
                        Attendees.Remove(input);
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

        #endregion "Methods List attendee"

        public decimal CalculateIncomePrice(decimal price, Attendee attendee)
        { 
            decimal output = price;
            if (Location != attendee.GetAttendeeHomeTown())
            {
                if(attendee.CalculateAge() > 60 || attendee.CalculateAge() < 25 || attendee.GetIfHandicapped())
                {
                    output /= 2;
                }
            }
            else
            {
                output = 0;
            }
            return output;
        }

        public decimal CalculateIncomePrice(Attendee attendee)
        {
            return CalculateIncomePrice(50, attendee);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Name: {Name}");
            output.AppendLine($"Where: {Location}");
            output.AppendLine($"When: {Date:yyyy-MM-dd}");
            output.AppendLine($"{PrintListArtists()}");
            output.AppendLine($"{PrintListAttendees()}");
            return output.ToString();
        }
    }
}
