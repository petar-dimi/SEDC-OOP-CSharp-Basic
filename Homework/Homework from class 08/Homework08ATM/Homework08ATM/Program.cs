namespace Homework08ATM
{
    internal class Program
    {
        static List<Customer> customers = new List<Customer>();

        static void Main(string[] args)
        {
           
            customers.Add(new Customer("Bob Bobsky", 1234123412341234, 4325, 650m));
            customers.Add(new Customer("Alice Wonderland", 5678567856785678, 1234, 1200m));

            Console.WriteLine("Welcome to the ATM app");

            while (true)
            {
                // Step 1: Card number input and search
                Console.Write("Please enter your card number (format: 1234-1234-1234-1234): ");
                string cardInput = Console.ReadLine().Replace("-", ""); // Remove dashes
                if (long.TryParse(cardInput, out long cardNumber))
                {
                    Customer customer = FindCustomerByCardNumber(cardNumber);

                    if (customer != null)
                    {
                        // Step 2: Pin input and authentication
                        Console.Write("Enter Pin: ");
                        if (int.TryParse(Console.ReadLine(), out int pin) && customer.Authenticate(pin))
                        {
                            Console.WriteLine($"Welcome {customer.FullName}!");

                            // Step 3: Operations loop
                            while (true)
                            {
                                Console.WriteLine("What would you like to do:");
                                Console.WriteLine("1. Check Balance");
                                Console.WriteLine("2. Cash Withdrawal");
                                Console.WriteLine("3. Cash Deposit");
                                Console.WriteLine("4. Exit");

                                string option = Console.ReadLine();

                                if (option == "1")
                                {
                                    // Check balance
                                    Console.WriteLine($"Your current balance is: {customer.CheckBalance():C}");
                                }
                                else if (option == "2")
                                {
                                    // Cash withdrawal
                                    Console.Write("Enter amount to withdraw: ");
                                    if (decimal.TryParse(Console.ReadLine(), out decimal amount))
                                    {
                                        Console.WriteLine(customer.Withdraw(amount));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid amount entered.");
                                    }
                                }
                                else if (option == "3")
                                {
                                    // Cash deposit
                                    Console.Write("Enter amount to deposit: ");
                                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                                    {
                                        Console.WriteLine(customer.Deposit(depositAmount));
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid amount entered.");
                                    }
                                }
                                else if (option == "4")
                                {
                                    // Exit the ATM session
                                    Console.WriteLine("Thank you for using the ATM app.");
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Invalid option, please choose again.");
                                }

                                // Ask if they want to perform another operation
                                Console.Write("Do you want to perform another operation? (Y/N): ");
                                if (Console.ReadLine().ToUpper() != "Y")
                                {
                                    Console.WriteLine("Goodbye!");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid pin.");
                        }
                    }
                    else
                    {
                        // Step 4: Option to register a new card
                        Console.WriteLine("Card not found. Would you like to register a new card? (Y/N): ");
                        if (Console.ReadLine().ToUpper() == "Y")
                        {
                            RegisterNewCustomer(cardNumber);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid card number format.");
                }
            }
        }

        // Method to find a customer by card number
        static Customer FindCustomerByCardNumber(long cardNumber)
        {
            foreach (Customer customer in customers)
            {
                if (customer.CardNumber == cardNumber)
                {
                    return customer;
                }
            }
            return null;
        }

        // Method to register a new customer
        static void RegisterNewCustomer(long cardNumber)
        {
            Console.Write("Enter your full name: ");
            string fullName = Console.ReadLine();

            Console.Write("Enter a 4-digit pin: ");
            if (int.TryParse(Console.ReadLine(), out int pin))
            {
                Console.Write("Enter your initial deposit: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal balance))
                {
                    customers.Add(new Customer(fullName, cardNumber, pin, balance));
                    Console.WriteLine("Registration successful! You can now log in.");
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount.");
                }
            }
            else
            {
                Console.WriteLine("Invalid pin format.");
            }
        }
    }
}
