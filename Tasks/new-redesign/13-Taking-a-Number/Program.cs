namespace LevelTask.Task13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Taking a Number
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
            askforNumber("Please enter a number", 1, 10);
        }
    }
}
