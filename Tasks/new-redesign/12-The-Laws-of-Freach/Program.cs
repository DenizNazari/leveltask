namespace LevelTask.Task12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //The Laws of Freach
            int[] strings = new int[5];
            int number;
            foreach (var i in strings)
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
