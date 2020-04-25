using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._4
{
    class Festival
    {
        public enum PeopleTypes { Attendee, Artist }

        private Dictionary<PeopleTypes, string> PeopeTypesStrings = new Dictionary<PeopleTypes, string>
        {
            { PeopleTypes.Artist, "Artist" },
            { PeopleTypes.Attendee, "Attendee" }
        };

        public string Name { get; set; }

        public string Location { get; set; }

        public DateTime Date { get; set; }

        //Tnese two lists are the slower but simpler way to do it
        public List<Artist> Artists { get; }

        public List<Attendee> Attendees { get; }

        //This one list is the harder but more efficient and faster way to do it
        //public List<Person> People { get; set; }

        public Festival(string name, string location, DateTime date)
        {
            Name = name;
            Location = location;
            Date = date;
            Artists = new List<Artist>();
            Attendees = new List<Attendee>();
            //People = new List<Person>();
        }

        public Festival() : this("A festival", "Antwerp", DateTime.Today)
        {

        }

        //Methods for the single list
        #region "Methods list people"

        //public string ListPeople(PeopleTypes type)
        //{
        //    if(People.Count == 0)
        //    {
        //        return "There are no people coming to this festival";
        //    }
        //    else
        //    {
        //        StringBuilder output = new StringBuilder();
        //        output.AppendLine($"{PeopeTypesStrings[type]}: \n");
        //        for (int i = 0; i < People.Count; i++)
        //        {
        //            if (type == PeopleTypes.Artist)
        //            {
        //                //Checks the type of the current person vs a constant
        //                //the type will be the child class
        //                if (People[i].GetType() == typeof(Artist))
        //                {
        //                    output.AppendLine($"{People[i]}");
        //                }
        //            }
        //            //else if for possible future additions of people
        //            else if (type == PeopleTypes.Attendee)
        //            {
        //                if (People[i].GetType() == typeof(Attendee))
        //                {
        //                    output.AppendLine($"{People[i]}");
        //                }
        //            }
        //        }
        //        return output.ToString();
        //    }
        //}

        //public string ListPeople()
        //{
        //    if (People.Count == 0)
        //    {
        //        return "There are no people coming to this festival";
        //    }
        //    else
        //    {
        //        StringBuilder output = new StringBuilder();
        //        output.AppendLine($"People: \n");
        //        foreach (Person person in People)
        //        {
        //            output.AppendLine($"{person}");
        //        }
        //        return output.ToString();
        //    }
        //}

        //public Person FindPerson(string firstname, string lastname, PeopleTypes type)
        //{
        //    string fullName = $"{firstname} {lastname}";
        //    Person output = null;
        //    foreach(Person person in People)
        //    {
        //        if (type == PeopleTypes.Artist)
        //        {
        //            if (person.GetPersonName() == fullName)
        //            {
        //                output = person;
        //            }
        //        }
        //        else if (type == PeopleTypes.Attendee)
        //        {
        //            if (person.GetPersonName() == fullName)
        //            {
        //                output = person;
        //            }
        //        }
        //    }
        //    return output;
        //}

        //public bool AddPerson(Person input)
        //{
        //    if(input != null)
        //    {
        //        if(People.Count != 0)
        //        {
        //            if(People.Contains(input))
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                People.Add(input);
        //                return true;
        //            }
        //        }
        //        else
        //        {
        //            People.Add(input);
        //            return true;
        //        }
        //    }
        //    else
        //    {

        //        throw new Exception("Please input a valid person");
        //    }
        //}

        //public bool RemovePerson(Person input)
        //{
        //    if (input != null)
        //    {
        //        if (People.Count != 0)
        //        {
        //            if (People.Contains(input))
        //            {
        //                People.Add(input);
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {

        //        throw new Exception("Please input a valid person");
        //    }
        //}

        #endregion

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
