namespace LevelTask.Task03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //	The Four Sisters and the Duckbear
            double eggs = int.Parse(Console.ReadLine());
            int eggremainder = (int)eggs % 4;
            Console.WriteLine($"duckbear get:{eggremainder}");
            int eggsneeded = (int)eggs / 4;
            Console.WriteLine($"sisters get:{eggsneeded}");
            int sayac = 0;
            for (int i = 1; i < 20; i++)
            {
                if (i / 4 < i % 4)
                {
                    sayac = sayac + i;
                    Console.WriteLine($" {i / 4} {i % 4} get:{i}");
                }
            }
            Console.WriteLine($"count get:{sayac}");
        }
    }
}
