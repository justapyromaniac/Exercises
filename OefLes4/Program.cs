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
        static Random generator = new Random();
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

            store.RemoveProduct(product1);
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

            festival.RemoveArtist(artist1);
            Console.WriteLine(festival);

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

            festival.RemoveAttendee(attendee1);
            Console.WriteLine(festival);

            #endregion "Testing methods"

            #endregion "Exercise 4.4"

            #region "Exercise 4.5"

            Console.WriteLine("----- Exercise 4.5 -----");
            Console.WriteLine();

            #region "Initializing objects"

            Console.WriteLine("----- Class Customer -----");
            Console.WriteLine();

            Console.WriteLine("----- Initializing customers -----");
            Console.WriteLine();

            const int AMOUNT5 = 10;

            List<Customer> customers = new List<Customer>();

            //Creating the customers
            for (int i = 0; i < AMOUNT5; i++)
            {
                customers.Add(Customer.MakeRandomCustomer());
            }

            const int AMOUNTOFACCOUNTS = 4;
            int randomNumber = generator.Next(0, 2);
            //adding bankaccounts to the customers
            foreach (Customer customer in customers)
            {
                for (int j = 0; j < AMOUNTOFACCOUNTS; j++)
                {
                    //to randomize what account is added
                    //adds a savingsaccount
                    if (randomNumber <= 0)
                    {
                        customer.AddBankAccount(SavingsAccount.MakeRandomAccount());
                    }
                    //adds an investementaccount
                    else if (randomNumber > 0)
                    {
                        customer.AddBankAccount(InvestmentAccount.MakeRandomAccount());
                    }
                }
            }

            const int AMOUNTOFTRANSACTIONS = 6;

            foreach (Customer customer in customers)
            {
                foreach (BankAccount bankAccount in customer.BankAccounts)
                {
                    int randomYear = generator.Next(DateTime.Today.Year - 80, DateTime.Today.Year + 1);
                    int randomMonth = generator.Next(1, 13);
                    int randomDay = generator.Next(1, DateTime.DaysInMonth(randomYear, randomMonth) + 1);
                    DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
                    decimal randomValue = (decimal)generator.Next(100, 100000) / 100;
                    for (int k = 0; k < AMOUNTOFTRANSACTIONS; k++)
                    {
                        if (bankAccount.GetType() == typeof(SavingsAccount))
                        {
                            bankAccount.DepositMoney(randomValue, randomDate);
                        }
                        else if (bankAccount.GetType() == typeof(InvestmentAccount))
                        {
                            if (randomNumber <= 0)
                            {
                                bankAccount.DepositMoney(randomValue, randomDate);
                            }
                            else if (randomNumber > 0)
                            {
                                TimeSpan randomPeriod = new TimeSpan(generator.Next(30, 1826), 0, 0, 0);
                                ((InvestmentAccount)bankAccount).InvestMoney(randomValue, randomPeriod, randomDate);
                            }
                        }
                    }
                }
            }

            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer);
            }

            Console.WriteLine("----- Class Bank -----");
            Console.WriteLine();

            Console.WriteLine("----- Initializing bank -----");
            Console.WriteLine();

            Bank bank = new Bank("A bank", Address.MakeRandomAddress());
            Console.WriteLine(bank);

            #endregion "Initializing objects"

            #region "Testing methods"

            Console.WriteLine("----- Testing methods -----");
            Console.WriteLine();

            Console.WriteLine("----- Adding customers -----");
            Console.WriteLine();

            foreach (Customer customer in customers)
            {
                bank.AddCustomer(customer);
            }
            Console.WriteLine(bank);

            Console.WriteLine("----- Listing customers -----");
            Console.WriteLine();

            Console.WriteLine(bank.ListCustomers());

            Console.WriteLine("----- Finding a customer -----");
            Console.WriteLine();

            Customer customer1 = bank.FindCustomer(1);
            Console.WriteLine(customer1);

            Console.WriteLine("----- Removing a customer -----");
            Console.WriteLine();

            bank.RemoveCustomer(customer1);
            Console.WriteLine(bank);

            Console.WriteLine("----- Adding a customer -----");
            Console.WriteLine();

            bank.AddCustomer(customer1);
            Console.WriteLine(bank);

            Console.WriteLine("----- Listing all bankaccounts of customer 1-----");
            Console.WriteLine();

            Console.WriteLine(customer1.ListBankAccounts());
            Console.WriteLine();

            Console.WriteLine("----- Finding a bankaccount -----");
            Console.WriteLine();

            BankAccount bankAccount1 = customer1.FindBankAccount(1);
            Console.WriteLine(bankAccount1);

            Console.WriteLine("----- Removing a bankaccount -----");
            Console.WriteLine();

            customer1.RemoveBankAccount(bankAccount1);
            Console.WriteLine(customer1);

            Console.WriteLine("----- Adding a bankaccount -----");
            Console.WriteLine();

            customer1.AddBankAccount(bankAccount1);
            Console.WriteLine(customer1);

            Console.WriteLine("----- Listing all transactions of bankaccount 1 -----");
            Console.WriteLine();

            Console.WriteLine(bankAccount1.ListTransactions());

            Console.WriteLine("----- Finding a transaction -----");
            Console.WriteLine();

            Transaction transaction1 = bankAccount1.FindTransaction(1);
            Console.WriteLine(transaction1);

            Console.WriteLine("----- Removing a transaction -----");
            Console.WriteLine();

            bankAccount1.RemoveTransaction(transaction1);
            Console.WriteLine(bankAccount1);

            Console.WriteLine("----- Adding a transaction -----");
            Console.WriteLine();

            bankAccount1.AddTransaction(transaction1);
            Console.WriteLine(bankAccount1);

            Console.WriteLine("----- Making a savings account -----");
            Console.WriteLine();

            SavingsAccount savingsAccount = SavingsAccount.MakeRandomAccount();
            Console.WriteLine(savingsAccount);

            Console.WriteLine("----- Depositing money to the account -----");
            Console.WriteLine();

            int AMOUNTOFDEPOSITS1 = 10;

            for (int i = 0; i < AMOUNTOFDEPOSITS1; i++)
            {
                int randomYear = generator.Next(DateTime.Today.Year - 80, DateTime.Today.Year + 1);
                int randomMonth = generator.Next(1, 13);
                int randomDay = generator.Next(1, DateTime.DaysInMonth(randomYear, randomMonth) + 1);
                DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
                decimal randomValue = (decimal)generator.Next(100, 100000) / 100;
                savingsAccount.DepositMoney(randomValue, randomDate);
            }

            Console.WriteLine(savingsAccount.ListTransactions());
            Console.WriteLine();
            Console.WriteLine($"Account balance: \u20AC {savingsAccount.CalculateAccountBalance():N}");
            Console.WriteLine();

            Console.WriteLine("----- Withrawing money from account -----");
            Console.WriteLine();

            int AMOUNTOFWITHDRAWALS1 = 10;

            try
            {
                for (int i = 0; i < AMOUNTOFWITHDRAWALS1; i++)
                {
                    int randomYear = generator.Next(DateTime.Today.Year - 80, DateTime.Today.Year + 1);
                    int randomMonth = generator.Next(1, 13);
                    int randomDay = generator.Next(1, DateTime.DaysInMonth(randomYear, randomMonth) + 1);
                    DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
                    decimal randomValue = (decimal)generator.Next(10, 10000) / 100;
                    savingsAccount.WithdrawMoney(randomValue, randomDate);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Insufficient funds");
            }

            Console.WriteLine(savingsAccount.ListTransactions());
            Console.WriteLine();
            Console.WriteLine($"Account balance: \u20AC {savingsAccount.CalculateAccountBalance():N}");
            Console.WriteLine();

            Console.WriteLine("----- Making an investement account -----");
            Console.WriteLine();

            InvestmentAccount investmentAccount = InvestmentAccount.MakeRandomAccount();
            Console.WriteLine(investmentAccount);

            Console.WriteLine("----- Depositing money into the account -----");
            Console.WriteLine();

            int AMOUNTOFDEPOSITS2 = 5;

            for (int i = 0; i < AMOUNTOFDEPOSITS2; i++)
            {
                int randomYear = generator.Next(DateTime.Today.Year - 80, DateTime.Today.Year + 1);
                int randomMonth = generator.Next(1, 13);
                int randomDay = generator.Next(1, DateTime.DaysInMonth(randomYear, randomMonth) + 1);
                DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
                decimal randomValue = (decimal)generator.Next(100, 100000) / 100;
                investmentAccount.DepositMoney(randomValue, randomDate);
            }

            Console.WriteLine(investmentAccount.ListTransactions());
            Console.WriteLine();
            Console.WriteLine($"Account balance: \u20AC {investmentAccount.CalculateAccountBalance():N}");
            Console.WriteLine();


            Console.WriteLine("----- Investing money into the account -----");
            Console.WriteLine();

            int AMOUNTOFINVESTEMENTS = 5;

            for (int i = 0; i < AMOUNTOFINVESTEMENTS; i++)
            {
                int randomYear = generator.Next(DateTime.Today.Year - 80, DateTime.Today.Year + 1);
                int randomMonth = generator.Next(1, 13);
                int randomDay = generator.Next(1, DateTime.DaysInMonth(randomYear, randomMonth) + 1);
                DateTime randomDate = new DateTime(randomYear, randomMonth, randomDay);
                decimal randomValue = (decimal)generator.Next(100, 100000) / 100;
                TimeSpan randomPeriod = new TimeSpan(generator.Next(30, 1826), 0, 0, 0);
                investmentAccount.InvestMoney(randomValue, randomPeriod, randomDate);
            }

            Console.WriteLine(investmentAccount.ListTransactions());
            Console.WriteLine();
            Console.WriteLine($"Account balance: \u20AC {investmentAccount.CalculateAccountBalance():N}");
            Console.WriteLine();


            #endregion "Testing methods"

            #endregion "Exercise 4.5"
        }
    }
}
