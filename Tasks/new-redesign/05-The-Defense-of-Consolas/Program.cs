namespace LevelTask.Task05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //The Defense of Consolas 
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "The Defense of Consolas";
            Console.Write("Target Row?:\t");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Target Column?:\t");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.Beep(440, 1000);
            Console.Write($"Deploy to:\r\n({row + 1}, {column})\n({row - 1}, {column})\n({row}, {column + 1})\n({row}, {column - 1})\n");
        }
    }
}
