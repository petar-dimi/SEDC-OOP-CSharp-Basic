namespace Hero_s_Journey
{
    internal class Program
    {
        const int MAX_ATTEMPTS = 5;

        static void Main(string[] args)
        {
            
            string[] emails = { "Petar.dimi@yahoo.com", "Risto.pan@google.com" };
            string[] passwords = { "dimi123.", "riki123" };

            if (!Login(emails, passwords))
            {
                Console.WriteLine("Too many failed attempts. Exiting application.");
                return;
            }

            
            Character character = CreateCharacter();

            
            StartGame(character);
        }

        static bool Login(string[] emails, string[] passwords)
        {
            int attempts = 0;

            while (attempts < MAX_ATTEMPTS)
            {
                Console.Write("Enter your email: ");
                string email = Console.ReadLine();
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

               
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Fields must not be empty. Try again.");
                    attempts++;
                    continue;
                }

               
                if (!IsValidEmail(email))
                {
                    Console.WriteLine("Invalid email format. Try again.");
                    attempts++;
                    continue;
                }

               
                for (int i = 0; i < emails.Length; i++)
                {
                    if (emails[i] == email && passwords[i] == password)
                    {
                        Console.WriteLine("Welcome to the game!");
                        return true;
                    }
                }

                Console.WriteLine("Invalid credentials. Try again.");
                attempts++;
            }
            return false;
        }

        static bool IsValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        static Character CreateCharacter()
        {
            Console.Write("Enter your character's name (2-20 characters): ");
            string name = Console.ReadLine();

           
            while (string.IsNullOrWhiteSpace(name) || name.Length < 2 || name.Length > 20)
            {
                Console.WriteLine("Name must be between 2 and 20 characters. Try again.");
                name = Console.ReadLine();
            }

            
            string race = ChooseRace();

           
            string characterClass = ChooseClass();

            
            Character character = new Character
            {
                Name = name,
                Race = race,
                Class = characterClass,
                Health = CalculateHealth(race, characterClass),
                Strength = CalculateStrength(race, characterClass),
                Agility = CalculateAgility(race, characterClass)
            };

            Console.WriteLine($"Character created: {character.Name} ({character.Race}) the {character.Class}");
            Console.WriteLine($"Stats: {character.Health} HP, {character.Strength} STR, {character.Agility} AGI");
            return character;
        }

        static string ChooseRace()
        {
            Console.WriteLine("Choose your race:");
            Console.WriteLine("1) Dwarf (100 Health, 6 Strength, 2 Agility)");
            Console.WriteLine("2) Elf (60 Health, 4 Strength, 6 Agility)");
            Console.WriteLine("3) Human (80 Health, 5 Strength, 4 Agility)");

            while (true)
            {
                Console.Write("Enter race number: ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
                {
                    return choice switch
                    {
                        1 => "Dwarf",
                        2 => "Elf",
                        3 => "Human",
                        _ => "Unknown"
                    };
                }
                Console.WriteLine("Invalid choice. Try again.");
            }
        }

        static string ChooseClass()
        {
            Console.WriteLine("Choose your class:");
            Console.WriteLine("1) Warrior (+20 Health, -1 Agility)");
            Console.WriteLine("2) Rogue (-20 Health, +1 Agility)");
            Console.WriteLine("3) Mage (+20 Health, -1 Strength)");

            while (true)
            {
                Console.Write("Enter class number: ");
                if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 3)
                {
                    return choice switch
                    {
                        1 => "Warrior",
                        2 => "Rogue",
                        3 => "Mage",
                        _ => "Unknown"
                    };
                }
                Console.WriteLine("Invalid choice. Try again.");
            }
        }

        static int CalculateHealth(string race, string characterClass)
        {
            int health = race switch
            {
                "Dwarf" => 100,
                "Elf" => 60,
                "Human" => 80,
                _ => 0
            };

            if (characterClass == "Warrior") health += 20;
            if (characterClass == "Rogue") health -= 20;
            if (characterClass == "Mage") health += 20;

            return health;
        }

        static int CalculateStrength(string race, string characterClass)
        {
            int strength = race switch
            {
                "Dwarf" => 6,
                "Elf" => 4,
                "Human" => 5,
                _ => 0
            };

            if (characterClass == "Mage") strength -= 1;

            return strength;
        }

        static int CalculateAgility(string race, string characterClass)
        {
            int agility = race switch
            {
                "Dwarf" => 2,
                "Elf" => 6,
                "Human" => 4,
                _ => 0
            };

            if (characterClass == "Warrior") agility -= 1;
            if (characterClass == "Rogue") agility += 1;

            return agility;
        }

        static void StartGame(Character character)
        {
            int eventsCompleted = 0;
            Random random = new Random();

            while (eventsCompleted < 5)
            {
                Console.WriteLine($"Event {eventsCompleted + 1}: " + GetEventDescription(eventsCompleted));
                Console.WriteLine("Choose your action: 1) Fight 2) Run Away");

                while (true)
                {
                    string choice = Console.ReadLine();
                    if (choice == "1")
                    {
                        int randomValue = random.Next(1, 11);
                        if (randomValue < character.Strength)
                        {
                            Console.WriteLine("You won the fight!");
                        }
                        else
                        {
                            character.Health -= GetHealthLoss(eventsCompleted);
                            Console.WriteLine($"You lost the fight! Health reduced to {character.Health}.");
                        }
                        break;
                    }
                    else if (choice == "2")
                    {
                        int randomValue = random.Next(1, 11);
                        if (randomValue < character.Agility)
                        {
                            Console.WriteLine("You successfully ran away!");
                        }
                        else
                        {
                            character.Health -= GetHealthLoss(eventsCompleted);
                            Console.WriteLine($"You couldn't escape! Health reduced to {character.Health}.");
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please enter 1 or 2.");
                    }
                }

                if (character.Health <= 0)
                {
                    Console.WriteLine("YOU LOST! Would you like to start a new game? 1) Yes 2) No");
                    if (Console.ReadLine() == "1")
                    {
                        Main(null); 
                    }
                    else
                    {
                        Environment.Exit(0); 
                    }
                }

                Console.WriteLine($"Health remaining: {character.Health}");
                eventsCompleted++;
            }

            Console.WriteLine("YOU WON! Would you like to start a new game? 1) Yes 2) No");
            if (Console.ReadLine() == "1")
            {
                Main(null); 
            }
        }

        static string GetEventDescription(int eventNumber)
        {
            return eventNumber switch
            {
                0 => "Bandits attack you out of nowhere. They seem very dangerous...",
                1 => "You bump into one of the guards of the nearby village. They attack you without warning...",
                2 => "A Land Shark appears. It starts chasing you down to eat you...",
                3 => "You accidentally step on a rat. His friends are not happy. They attack... ",
                4 => "You find a huge rock. It comes alive somehow and tries to smash you...",
                _ => "An unknown event occurs."
            };
        }

        static int GetHealthLoss(int eventNumber)
        {
            return eventNumber switch
            {
                0 => 20,
                1 => 30,
                2 => 50,
                3 => 10,
                4 => 30,
                _ => 0
            };
            }
        }
    }
