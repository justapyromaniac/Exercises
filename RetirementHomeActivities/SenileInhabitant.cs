using System;
using System.Collections.Generic;
using System.Text;

namespace RetirementHomeActivities
{
    class SenileInhabitant : Inhabitant
    {
        public SenileInhabitant(string firstName, string lastName, int roomNumber)
            :base(firstName, lastName, roomNumber, Floors.Floor4)
        {

        }

        public override bool CheckFloor(Floors floor)
        {
            if(floor != Floors.Floor4)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public override string AddActivity(Activity activity)
        {
            if(activity.ActivityType != ActivityTypes.Handywork)
            {
                return "Senile inhabitans are only allowed to do handywork!";
            }
            else
            {
                return base.AddActivity(activity);
            }
        }

        public override string ToString()
        {
            return $"(D) {base.ToString()}";
        }
    }
}
