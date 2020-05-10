using System;
using System.Collections.Generic;
using System.Text;

namespace TooYoung
{
    class Person
    {
        public string FirstName { get; set; }


        private DateTime birthDay;

        public DateTime BirthDay 
        { 
            get { return birthDay; }
            set
            {
                int age = DateTime.Today.Year - value.Year;
                if (age < 18)
                {
                    throw new Exception("Minors not allowed!");
                }
            }
        }

        public Person(string firstName, DateTime birthDay)
        {
            FirstName = firstName;
            BirthDay = birthDay;
        }

        public override string ToString()
        {
            return $"{FirstName}\n{BirthDay.ToShortTimeString()}";
        }
    }
}
