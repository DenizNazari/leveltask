namespace LevelTask.Task09
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("User 1, enter a number between 0 and 100:\n");
            int NumberlOfLocation = int.Parse(Console.ReadLine());

            while (true)
            {
                if (NumberlOfLocation < 0 || NumberlOfLocation > 100)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 0 and 100:");
                    NumberlOfLocation = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }
            Console.Clear();

            Console.WriteLine("What is your  guess?");
            int GUessOfLocation = int.Parse(Console.ReadLine());

            while (true)
            {
                if (GUessOfLocation == NumberlOfLocation)
                {
                    Console.WriteLine($"You guessed it!");
                    break;
                }
                else if (GUessOfLocation < NumberlOfLocation)
                {
                    Console.WriteLine($"Your guess {GUessOfLocation} is too low.");
                }
                else
                {
                    Console.WriteLine($"Your guess {GUessOfLocation} is too high.");
                }

                Console.WriteLine("What is your next guess?");
                GUessOfLocation = int.Parse(Console.ReadLine());
            }
        }
    }
}
