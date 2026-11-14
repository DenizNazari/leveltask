namespace LevelTask.Task11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //The Replicator of D'To
            int[] strings = new int[5];
            int number;
            for (int i = 0; i < strings.Length; i++)
            {
                Console.WriteLine($"Enter number {i + 1}.value:");
                number = int.Parse(Console.ReadLine());
                strings[i] = number;
            }
            Console.WriteLine(
                $"The sum of the numbers is: {strings.Sum()}");
            Console.WriteLine(
                $"The average of the numbers is: {strings.Average()}");
            int[] strings2 = new int[5];
            strings.CopyTo(strings2, 0);
        }
    }
}
