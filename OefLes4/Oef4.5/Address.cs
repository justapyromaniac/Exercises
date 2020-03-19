using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._5
{
    class Address
    {
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

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Street: {StreetName}");
            output.AppendLine($"House number: {HouseNumber}");
            output.AppendLine($"City: {City}");
            output.AppendLine($"Postal code: {PostalCode}");
            return output.ToString();
        }
    }
}
