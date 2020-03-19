using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._3
{
    class FoodProduct : Product
    {
        public DateTime ExpirarionDate { get; set; }

        public int TemperatureToStore { get; set; }

        //if this returns false, it's price/kg alse it's price/L
        //The current school code doesn't do this, it returns the price multiplied by a division of input weight / 1000
        //If someone gets how that would lead to what's asked, explain because I think it's just stupid
        public bool IsLiquid { get; set; }

        public FoodProduct(string name, string supplier, decimal price, DateTime expirationDate, int temperatureToStore, bool isLiquid) : base(name, supplier, price)
        {
            ExpirarionDate = expirationDate;
            TemperatureToStore = temperatureToStore;
            IsLiquid = isLiquid;
        }

        public static Product MakeRandomProduct()
        {
            List<string> names = new List<string>();

            List<string> suppliers = new List<string>
            {
                "The juice factory",
                "Breakfast foods gallore",
                "The breadery",
                "Canned foods co.",
                "Sweets and sweetness",
                "Land of the rising food",
                "The orchard",
                "Spiffco",
                "Student meal supplier",
                "The bottling plant",
                "Generic food inc."
            };
            string randomName = ""; 
            string randomSupplier = suppliers[generator.Next(suppliers.Count)];
            decimal randomPrice = ((decimal)generator.Next(10, 1000)) / 100;
            int randomYear = generator.Next(DateTime.Today.Year, DateTime.Today.Year + 6);
            int randomMonth = generator.Next(1, DateTime.Today.Month + 1);
            int randomDay = generator.Next(1, DateTime.Today.Day + 1);
            DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
            int randomTemp = generator.Next(1, 11);
            bool randomBool;
            int randomInt = generator.Next(0, 2);
            if(randomInt > 0)
            {
                randomBool = true;
                names.AddRange(new List<string>
                {
                    "Bottled water",
                    "Carbonated water",
                    "Milk",
                    "Soda",
                    "Fruit juice",
                    "Multivitamin juice",
                    "Beer",
                    "Ale",
                    "Wine",
                    "Cherry beer"
                });
            }
            else
            {
                randomBool = false;
                names.AddRange(new List<string>
                {
                    "Cherries",
                    "Strawberries",
                    "Dumplings",
                    "Tofu",
                    "Okonomiyaki",
                    "Takoyaki",
                    "Soba",
                    "Noodles",
                    "Sponge cake",
                    "Fruit cake",
                    "Apple pie",
                    "Whole grain bread",
                    "Fruit mix cornflakes",
                    "Kiwis",
                    "Lemon tea",
                    "Chocolate",
                    "Fruit salad",
                    "Premade salad",
                    "Pretzels",
                    "Canned soup",
                    "Canned veggies",
                    "Peach jelly",
                    "Honey",
                    "Assorted nuts and grains",
                    "Oatmeal"
                });  
            }
            randomName = names[generator.Next(names.Count)];
            names.Clear();
            return new FoodProduct(randomName, randomSupplier, randomPrice, randomDate, randomTemp, randomBool);
        }

        public override string GetSalePrice()
        {
            StringBuilder output = new StringBuilder();
            if(IsLiquid)
            {
                output.Append($"{base.GetSalePrice()}/L");
            }
            else
            {
                output.Append($"{base.GetSalePrice()}/kg");
            }
            return output.ToString();
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Use before: {ExpirarionDate:yyyy-MM-dd}");
            output.AppendLine($"Store at {TemperatureToStore}\u00B0C");
            return base.ToString() + output.ToString();
        }
    }
}
