using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._5
{
    class Address
    {
        public static Random generator = new Random();

        public string StreetName { get; private set; }

        public int HouseNumber { get; private set; }

        public string City { get; private set; }

        public int PostalCode { get; private set; }

        public Address(string streetName, int houseNumber, string city, int postalCode)
        {
            StreetName = streetName;
            HouseNumber = houseNumber;
            City = city;
            PostalCode = postalCode;
        }

        public static Address MakeRandomAddress()
        {
            List<string> streetnames = new List<string>
            {
                "This street",
                "That street",
                "Something lane",
                "Somewhere boulevard"
            };

            List<string> cities = new List<string>
            {
                "A city",
                "A town",
                "Nowhere",
                "Area 51"
            };

            string randomStreet = streetnames[generator.Next(streetnames.Count)];
            int randomHouseNumber = generator.Next(1, 101);
            string randomCity = cities[generator.Next(cities.Count)];
            int randomPostCode = generator.Next(1000, 10000);
            return new Address(randomStreet, randomHouseNumber, randomCity, randomPostCode);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Street: {StreetName}");
            output.AppendLine($"House number: {HouseNumber}");
            output.AppendLine($"City: {City}");
            output.AppendLine($"Postal code: {PostalCode:####}");
            return output.ToString();
        }
    }
}
