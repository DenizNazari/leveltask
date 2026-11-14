namespace LevelTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.ResetColor();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("============================================================");
                Console.WriteLine("       THE C# PLAYER'S GUIDE - GÖREV SEÇİM EKRANI           ");
                Console.WriteLine("============================================================");
                Console.ResetColor();

                Console.WriteLine("  [01] The Triangle Farmer               [13] Taking a Number");
                Console.WriteLine("  [02] The Variable Shop & Type Limits   [14] Hunting the Manticore (Boss)");
                Console.WriteLine("  [03] The Four Sisters & the Duckbear   [15] Simula's Test");
                Console.WriteLine("  [04] The Dominion of Kings             [16] Simula's Soup");
                Console.WriteLine("  [05] The Defense of Consolas           [17] Vin Fletcher's Arrows");
                Console.WriteLine("  [06] Repairing the Clocktower          [18] The Point");
                Console.WriteLine("  [07] Watchtower                        [19] The Color (ANSI RGB)");
                Console.WriteLine("  [08] Buying & Discounted Inventory     [20] The Card (ASCII Cards)");
                Console.WriteLine("  [09] The Prototype                     [21] The Locked Door");
                Console.WriteLine("  [10] The Magic Cannon                  [22] The Password Validator");
                Console.WriteLine("  [11] The Replicator of D'To            [23] Rock-Paper-Scissors");
                Console.WriteLine("  [12] The Laws of Freach                [24] 15-Puzzle (Boss Battle)");
                Console.WriteLine("  [00] Çıkış (Exit)");
                Console.WriteLine("------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Çalıştırmak istediğiniz görevin numarasını girin (1-24, Çıkış: 0): ");
                Console.ResetColor();

                string? input = Console.ReadLine();
                if (!int.TryParse(input, out int choice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nGeçersiz giriş! Lütfen 0 ile 24 arasında bir sayı girin.");
                    Console.ResetColor();
                    Console.WriteLine("Devam etmek için bir tuşa basın...");
                    Console.ReadKey(true);
                    continue;
                }

                if (choice == 0)
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($">>> Görev {choice:D2} Çalıştırılıyor...\n");
                Console.ResetColor();

                switch (choice)
                {
                    case 1: LevelTask.Task01.Program.Main(args); break;
                    case 2: LevelTask.Task02.Program.Main(args); break;
                    case 3: LevelTask.Task03.Program.Main(args); break;
                    case 4: LevelTask.Task04.Program.Main(args); break;
                    case 5: LevelTask.Task05.Program.Main(args); break;
                    case 6: LevelTask.Task06.Program.Main(args); break;
                    case 7: LevelTask.Task07.Program.Main(args); break;
                    case 8: LevelTask.Task08.Program.Main(args); break;
                    case 9: LevelTask.Task09.Program.Main(args); break;
                    case 10: LevelTask.Task10.Program.Main(args); break;
                    case 11: LevelTask.Task11.Program.Main(args); break;
                    case 12: LevelTask.Task12.Program.Main(args); break;
                    case 13: LevelTask.Task13.Program.Main(args); break;
                    case 14: LevelTask.Task14.Program.Main(args); break;
                    case 15: LevelTask.Task15.Program.Main(args); break;
                    case 16: LevelTask.Task16.Program.Main(args); break;
                    case 17: LevelTask.Task17.Program.Main(args); break;
                    case 18: LevelTask.Task18.Program.Main(args); break;
                    case 19: LevelTask.Task19.Program.Main(args); break;
                    case 20: LevelTask.Task20.Program.Main(args); break;
                    case 21: LevelTask.Task21.Program.Main(args); break;
                    case 22: LevelTask.Task22.Program.Main(args); break;
                    case 23: LevelTask.Task23.Program.Main(args); break;
                    case 24: LevelTask.Task24.Program.Main(args); break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lütfen 1 ile 24 arasında bir görev seçin.");
                        Console.ResetColor();
                        break;
                }

                Console.ResetColor();
                Console.WriteLine("\n------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("Ana menüye dönmek için herhangi bir tuşa basın (Çıkmak için ESC)...");
                Console.ResetColor();
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Escape)
                {
                    break;
                }
            }
        }
    }
}
