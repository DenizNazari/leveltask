namespace LevelTask.Task06
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Repairing the Clocktower
            Console.Write("Target Row?:\t");
            int clock = int.Parse(Console.ReadLine());
            if (clock % 2 == 0)
            {
                Console.WriteLine("tick");
            }
            else
            {
                Console.WriteLine("tock");
            }
        }
    }
}
