using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4.Oef4._3
{
    class NonFoodProduct : Product
    {
        public DateTime WarrantyPeriod { get; set; }

        public bool IsFragile { get; set; }

        public bool NeedsBatteries { get; set; }

        public NonFoodProduct(string name, string supplier, decimal price, DateTime warrantyPeriod, bool isFragile, bool needsBatteries) : base(name, supplier, price)
        {
            WarrantyPeriod = warrantyPeriod;
            IsFragile = isFragile;
            NeedsBatteries = needsBatteries;
        }

        public static Product MakeRandomProduct()
        {
            List<string> products = new List<string>();

            List<string> suppliers = new List<string>
            {
                "Aus Electronics Ltd.",
                "Scents and wax",
                "US glassworks co.",
                "G&N",
                "Inconspicuous opticians inc.",
                "Pineapple \u00A9",
                "Borstch"
            };
            string randomSupplier = suppliers[generator.Next(suppliers.Count)];
            decimal randomPrice = ((decimal)generator.Next(10, 1000)) / 100;
            int randomYear = generator.Next(0,6);
            DateTime randomDate = DateTime.Today.AddYears(randomYear);
            bool randomIsFragile, randomNeedsBatteries;
            int randomInt1 = generator.Next(0, 2), randomInt2 = generator.Next(0, 2);
            if (randomInt1 > 0 && randomInt2 < 1)
            {
                randomIsFragile = true;
                randomNeedsBatteries = false;
                products.AddRange(new List<string>
                {
                    "Cherry Scented candles",
                    "Ornamental vase",
                    "Peach scented candles",
                    "Candles",
                    "Glasses",
                    "Cups",
                    "Drawing paper",
                    "Pencils"
                });
            }
            else if(randomInt1 < 1 && randomInt2 < 1)
            {
                randomIsFragile = false;
                randomNeedsBatteries = false;
                products.AddRange(new List<string> 
                { 
                    "T-shirt",
                    "Brand T-shirt",
                    "Pants",
                    "Shorts",
                    "Shirt",
                    "Sweaters",
                    "Hoodie",
                    "Socks"
                });
            }
            else if(randomInt1 < 1 && randomInt2 > 0)
            {
                randomIsFragile = false;
                randomNeedsBatteries = true;
                products.AddRange(new List<string>
                {
                    "Toy robot",
                    "LED strip",
                    "Pocket watch",
                    "Flashlight",
                    "Powertools",
                    "Powered gardening tools"
                }) ;
            }
            else
            {
                randomIsFragile = true;
                randomNeedsBatteries = true;
                products.AddRange(new List<string> 
                { 
                    "Laptop",
                    "Alarm clock",
                    "Lavalamp",
                    "Powered display",
                    "Desk lamp",
                    "Radio",
                    "Portable Music player",
                    "Tablet",
                    "Smartphone"
                });
            }
            string randomName = products[generator.Next(products.Count)];
            products.Clear();
            return new NonFoodProduct(randomName, randomSupplier, randomPrice, randomDate, randomIsFragile, randomNeedsBatteries);
        }

        public override string ToString()
        {
            string isFragile = IsFragile ? "Yes" : "No";
            string needsBatteries = NeedsBatteries ? "Yes" : "No";
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Warranty valid until: {WarrantyPeriod:yyyy-MM-dd}");
            output.AppendLine($"Is this product fragile: {isFragile}");
            output.AppendLine($"Requires batteries: {needsBatteries}");
            return base.ToString() + output.ToString();
        }
    }
}
