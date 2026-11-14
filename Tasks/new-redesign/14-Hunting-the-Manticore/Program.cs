namespace LevelTask.Task14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //BOSS FİGHT  Hunting the Manticore
            int askForNumber(string text)
            {
                Console.WriteLine(text);
                return int.Parse(Console.ReadLine());
            }
            int askforNumber(string text, int min, int max)
            {
                Console.WriteLine(text + " (between" + min + " and " + max + "): ");
                while (true)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number >= min && number <= max)
                    {
                        return number;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number between " + min + " and " + max + ": ");
                    }
                }
            }

            int manticoreDistance = askforNumber("Enter the Manticore's distance from the city", 1, 100);
            Console.Clear();
            int manticoreHealth = 10;
            for (int round = 15; round >= 0; round--)
            {
                Console.WriteLine($"STATUS: Round: {15 - round} City: {round}/15 Manticore: {manticoreHealth}/10\r\n:");
                int damage = (15 - round) % 15 == 0 ? 10 : ((15 - round) % 3 == 0 ? 3 : ((15 - round) % 5 == 0 ? 3 : 1));
                Console.WriteLine($"The cannon is expected to deal {damage} damage this round.\r\n");
                Console.WriteLine($"Enter desired cannon range:");
                int cannonRange = int.Parse(Console.ReadLine());
                int statusRange = cannonRange == manticoreDistance ? 0 : (cannonRange >= manticoreDistance ? 1 : -1);
                Console.WriteLine(statusRange == 0 ? "That round was a direct hit!" : (statusRange == 1 ? "That round was an overshot." : "That round was an undershot."));
                if (statusRange == 0) manticoreHealth -= damage;

                if (manticoreHealth <= 0)
                {
                    Console.WriteLine("You have defeated the Manticore!");
                    break;
                }
                if (round == 0)
                {
                    Console.WriteLine("The Manticore has reached the city. Game over.");
                    break;
                }
            }
        }
    }
}
