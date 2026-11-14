namespace LevelTask.Task08
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Buying Inventory
            Console.WriteLine("""

                    The following items are available:
                1 - Rope
                2 - Torches
                3- Climbing Equipment
                4 - Clean Water
                5 - Machete
                6 - Canoe
                7- Food Supplies

                """);
            Console.WriteLine("What number do you want to see the price of? ");
            int itemNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your name?");
            string playerName = Console.ReadLine();
            switch (itemNumber)
            {
                case 1:
                    Console.WriteLine($"Rope: {(playerName == "Deniz" ? 5 : 10)} gold");
                    break;
                case 2:
                    Console.WriteLine($"Torches: {(15 / (playerName == "Deniz" ? 2 : 1))} gold");
                    break;
                case 3:
                    Console.WriteLine($"Climbing Equipment: {(25 / (playerName == "Deniz" ? 2 : 1))} gold");
                    break;
                case 4:
                    Console.WriteLine($"Clean Water: {(1 / (playerName == "Deniz" ? 2 : 1))} gold");
                    break;
                case 5:
                    Console.WriteLine($"Machete: {(20 / (playerName == "Deniz" ? 2 : 1))} gold");
                    break;
                case 6:
                    Console.WriteLine($"Canoe: {(200 / (playerName == "Deniz" ? 2 : 1))} gold");
                    break;
                case 7:
                    Console.WriteLine($"Food Supplies: {(1 / (playerName == "Deniz" ? 2 : 1))} gold");
                    break;
                default:
                    Console.WriteLine($"Invalid item number.");
                    break;
            }
        }
    }
}
