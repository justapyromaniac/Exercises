using System;
using System.Collections.Generic;
using System.Text;

namespace RetirementHomeActivities
{
    enum ActivityTypes { Handywork, MemoryTraining, Exercise }
    class Activity
    {
        private const int PRICE = 5;

        public ActivityTypes ActivityType { get; set; }

        public DateTime Date { get; set; }

        public int Price { get; private set; }

        public Activity(ActivityTypes activityType, DateTime date)
        {
            ActivityType = activityType;
            Date = date;
            Price = PRICE;
        }
    }
}
