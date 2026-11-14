namespace LevelTask.Task04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //The Dominion of Kings
            int score = 0;
            Console.WriteLine($"provinces:");
            int provinces = int.Parse(Console.ReadLine());
            Console.WriteLine($"duchies:");
            int duchies = int.Parse(Console.ReadLine());
            Console.WriteLine($"estates:");
            int estates = int.Parse(Console.ReadLine());
            score = score + provinces * 6;
            score = score + duchies * 3;
            score = score + estates * 1;

            Console.WriteLine($"score:{score}");
        }
    }
}
