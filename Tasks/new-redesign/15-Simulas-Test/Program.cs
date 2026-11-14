namespace LevelTask.Task15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Simula's Test
            while (true)
            {
                Console.WriteLine("Enter the chest status (Locked, Unlocked, Opened):");
                string input = Console.ReadLine();
                if (Enum.TryParse<ChestStatusEnum>(input, true, out ChestStatusEnum chestStatus))
                {
                    switch (chestStatus)
                    {
                        case ChestStatusEnum.Locked:
                            Console.WriteLine("The chest is locked. You need a key to open it.");
                            break;
                        case ChestStatusEnum.Unlocked:
                            Console.WriteLine("The chest is unlocked. You can open it.");
                            break;
                        case ChestStatusEnum.Opened:
                            Console.WriteLine("The chest is already opened. You can take the contents.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid chest status.");
                }
            }
        }
    }

    enum ChestStatusEnum
    {
        Locked,
        Unlocked,
        Opened
    }
}
