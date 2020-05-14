using System;
using System.Collections.Generic;
using System.Text;

namespace RetirementHomeActivities
{
    enum Floors { Floor1, Floor2, Floor3, Floor4 }
    class Inhabitant
    {
        private static Random generator = new Random();
        private Floors floor;
        private List<Activity> Activities;
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int RoomNumber { get; set; }

        public Floors Floor 
        {
            get { return floor; } 
            set 
            { 
                if(CheckFloor(value))
                {
                    floor = value;
                }
                else
                {
                    throw new Exception("This floor is only for senile inhabitants.");
                }
            } 
        }

        public Inhabitant(string firstName, string lastName, int roomNumber, Floors floor)
        {
            FirstName = firstName;
            LastName = lastName;
            RoomNumber = roomNumber;
            Floor = floor;
            Activities = new List<Activity>();
        }

        public Inhabitant(string firstName, string lastName, int roomNumber)
            :this(firstName, lastName, roomNumber, (Floors)generator.Next(0,3))
        {

        }

        public virtual bool CheckFloor(Floors floor)
        {
            if(floor == Floors.Floor4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckActivity(Activity activity)
        {
            bool exists = false;
            foreach (Activity item in Activities)
            {
                if(activity.Date == item.Date && activity.ActivityType == item.ActivityType)
                {
                    exists =  true;
                }
            }
            return exists;
        }

        public virtual string AddActivity(Activity activity)
        {
            if(activity.Date < DateTime.Today)
            {
                return "Activities cannot lie in the past";
            }
            else if(CheckActivity(activity))
            {
                return "This activity already exists";
            }
            else
            {
                Activities.Add(activity);
                return "Activity added.";
            }
        }

        public void RemoveActivity(Activity activity)
        {
            List<Activity> ActivitiesToDelete = new List<Activity>();
            foreach (Activity item in Activities)
            {
                if(activity.ActivityType == item.ActivityType && activity.Date == item.Date)
                {
                    ActivitiesToDelete.Add(item);
                }
            }
            foreach (Activity item in ActivitiesToDelete)
            {
                Activities.Remove(item);
            }
        }

        public int CalculateCostActivities()
        {
            int output = 0;
            foreach (Activity item in Activities)
            {
                output += item.Price;
            }
            return output;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
