namespace LevelTask.Task01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Base:");
            double bases = double.Parse(Console.ReadLine());
            Console.WriteLine("Height:");
            double heights = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine((bases * heights) / 2);
        }
    }
}
