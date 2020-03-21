using OefLes4.Oef4._1;
using OefLes4.Oef4._2;
using OefLes4.Oef4._3;
using OefLes4.Oef4._4;
using OefLes4.Oef4._5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OefLes4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region "Exercise 4.1"

            Console.WriteLine("----- Exercise 4.1 -----");
            Console.WriteLine();

            #region "Initializing objects"

            Console.WriteLine("----- Class pet -----");
            Console.WriteLine();

            Console.WriteLine("----- Initialize pets -----");
            Console.WriteLine();

            const int AMOUNT1 = 10;

            List<Pet> pets = new List<Pet>();

            for (int i = 0; i < AMOUNT1; i++)
            {
                pets.Add(Cat.MakeRandomPet());
                pets.Add(Dog.MakeRandomPet());
            }

            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet);
            }

            #endregion "Initializing objects"

            #region "Test methods"

            Console.WriteLine("----- Testing of pet methods -----");
            Console.WriteLine();

            Console.WriteLine("----- Make noise -----");
            Console.WriteLine();

            foreach (Pet pet in pets)
            {
                Console.WriteLine(pet.MakeNoise());
                Console.WriteLine();
            }

            #endregion "Test methods"

            #endregion "Exercise 4.1"

            #region "Exercise 4.2"

            Console.WriteLine("----- Exercise 4.2 -----");
            Console.WriteLine();

            #region "Initializing objects"

            Console.WriteLine("----- Class car -----");
            Console.WriteLine();

            Console.WriteLine("----- Initialize sportscars -----");
            Console.WriteLine();

            const int AMOUNT2 = 10;

            List<Car> cars = new List<Car>();

            for (int i = 0; i < AMOUNT2; i++)
            {
                cars.Add(SportsCar.MakeRandomCar());
                cars.Add(FamilyCar.MakeRandomCar());
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }

            #endregion "Initializing objects"

            #region "Test methods"

            Console.WriteLine("----- Testing of car methods -----");
            Console.WriteLine();

            Console.WriteLine("----- Testing fuel consumption -----");
            Console.WriteLine();

            foreach (Car car in cars)
            {
                Console.WriteLine(car.CalculateFuelConsumption());
                Console.WriteLine();
            }

            Console.WriteLine("----- Testing kilometer count -----");
            Console.WriteLine();

            foreach (Car car in cars)
            {
                Console.WriteLine(car.CalculateKilometers());
                Console.WriteLine();
            }

            #endregion "Test methods"

            #endregion "Oef 4.2"

            #region "Exercise 4.3"

            Console.WriteLine("----- Exercise 4.3 -----");
            Console.WriteLine();

            #region "Initalizing objects"

            Console.WriteLine("----- Class Product -----");
            Console.WriteLine();

            Console.WriteLine("----- Initializing products -----");
            Console.WriteLine();

            const int AMOUNT3 = 10;

            List<Product> products = new List<Product>();

            for (int i = 0; i < AMOUNT3; i++)
            {
                products.Add(FoodProduct.MakeRandomProduct());
                products.Add(NonFoodProduct.MakeRandomProduct());
            }

            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine("----- Class Store -----");
            Console.WriteLine();

            Console.WriteLine("----- Initializing store -----");
            Console.WriteLine();

            Store store = new Store();

            #endregion "Initalizing objects"

            #region "Testing methods"

            Console.WriteLine("----- Testing of store methods -----");
            Console.WriteLine();

            Console.WriteLine("----- Adding products -----");
            Console.WriteLine();

            foreach (Product product in products)
            {
                store.AddProduct(product);
            }

            Console.WriteLine(store);

            Console.WriteLine("----- Finding a product -----");
            Console.WriteLine();

            //List to contain the names of all the products
            List<string> names = new List<string>();

            foreach (Product product in products)
            {
                names.Add(product.GetProductName());
            }

            Product product1 = store.FindProduct(names[0]);
            Console.WriteLine($"Product 1: \n{product1}");

            Console.WriteLine("----- Removing the product -----");
            Console.WriteLine();

            Console.WriteLine(store.RemoveProduct(product1));
            Console.WriteLine();

            Console.WriteLine("----- Displaying the store -----");
            Console.WriteLine();
            Console.WriteLine(store);

            #endregion "Testing methods"

            #endregion "Exercise 4.3"

            #region "Exercise 4.4"

            Console.WriteLine("----- Exercise 4.4 -----");
            Console.WriteLine();

            #region "Initalizing objects"

            Console.WriteLine("----- Class Person -----");
            Console.WriteLine();

            Console.WriteLine("----- Initializing people -----");
            Console.WriteLine();

            const int AMOUNT4 = 10;

            List<Attendee> attendees = new List<Attendee>();
            List<Artist> artists = new List<Artist>();

            for (int i = 0; i < AMOUNT4; i++)
            {
                attendees.Add(Attendee.MakeRandomPerson());
                artists.Add(Artist.MakeRandomPerson());
            }

            foreach (Person artist in artists)
            {
                Console.WriteLine(artist);
                Console.WriteLine();
            }

            foreach (Person attendee in attendees)
            {
                Console.WriteLine(attendee);
                Console.WriteLine();
            }

            Console.WriteLine("----- Class Festival -----");
            Console.WriteLine();

            Console.WriteLine("----- Initializing festival -----");
            Console.WriteLine();

            Festival festival = new Festival();

            #endregion "Initalizing objects"

            #region "Testing methods"

            Console.WriteLine("----- Testing of festival methods -----");
            Console.WriteLine();

            Console.WriteLine("----- Adding artists -----");
            Console.WriteLine();

            foreach (Artist artist in artists)
            {
                festival.AddArtist(artist);
            }

            Console.WriteLine(festival);

            Console.WriteLine("----- Finding an artist -----");
            Console.WriteLine();

            //List to contain the names of all the products

            Artist artist1 = festival.FindArtist(artists[0].FirstName, artists[0].LastName);
            Console.WriteLine($"Artist 1: \n{artist1}");

            Console.WriteLine("----- Removing the artist -----");
            Console.WriteLine();

            Console.WriteLine(festival.RemoveArtist(artist1));
            Console.WriteLine();

            Console.WriteLine("----- Adding attendees -----");
            Console.WriteLine();

            foreach (Attendee attendee in attendees)
            {
                festival.AddAttendee(attendee);
            }

            Console.WriteLine(festival);

            Console.WriteLine("----- Calculating income prices -----");
            Console.WriteLine();

            decimal incomePrice = 50;
            Console.WriteLine($"Standard price: {incomePrice}");

            foreach (Attendee attendee in attendees)
            {
                Console.WriteLine("-----");
                Console.WriteLine(attendee);
                Console.WriteLine($"Income price: {festival.CalculateIncomePrice(incomePrice, attendee)}");
                Console.WriteLine("-----");
                Console.WriteLine();
            }

            Console.WriteLine("----- Finding an attendee -----");
            Console.WriteLine();

            //List to contain the names of all the products

            Attendee attendee1 = festival.FindAttendee(attendees[0].FirstName, attendees[0].LastName);
            Console.WriteLine($"Attendee 1: \n{attendee1}");

            Console.WriteLine("----- Removing the attendee -----");
            Console.WriteLine();

            Console.WriteLine(festival.RemoveAttendee(attendee1));
            Console.WriteLine();

            Console.WriteLine("----- Displaying the festival -----");
            Console.WriteLine();
            Console.WriteLine(festival);

            #endregion "Testing methods"

            #endregion "Exercise 4.4"

            BankAccount test = new SavingsAccount(DateTime.Today, 0.01M, 0.1M);
            test.DepositMoney(100, DateTime.Today.AddYears(-2));
            test.DepositMoney(100, DateTime.Today.AddDays(-4));
            test.DepositMoney(100, DateTime.Today.AddDays(-3));
            test.DepositMoney(100, DateTime.Today.AddDays(-2));
            test.DepositMoney(100, DateTime.Today.AddDays(-1));
            test.DepositMoney(100);
            Console.WriteLine(test);

            Console.WriteLine(typeof(SavingsAccount));
        }
    }
}
