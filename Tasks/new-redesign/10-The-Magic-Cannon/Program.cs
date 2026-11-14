namespace LevelTask.Task10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // 1. KULLANICI (Pilot): Sayı belirleme
            int blast;
            do
            {
                Console.WriteLine("User 1, enter a number between 0 and 100:");
                blast = int.Parse(Console.ReadLine());
            }
            while (blast < 0 || blast > 100);
            for (int i = 0; i < blast; i++)
            {
                Console.WriteLine($"{i}.{(i % 15 == 0 ? "combined blast" : i % 3 == 0 ? "Fire" : i % 5 == 0 ? "Electric" : "Normal")}");
            }
        }
    }
}
