namespace LevelTask.Task23
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock-Paper-Scissors!");
            Console.WriteLine("Player 1, enter your name:");
            string player1Name = Console.ReadLine();
            Console.WriteLine("Player 2, enter your name:");
            string player2Name = Console.ReadLine();

            RockPaperScissors game = new RockPaperScissors(player1Name, player2Name);
            string player1 = null, player2 = null;
            while (true)
            {
                if (player1 == null)
                {
                    Console.WriteLine("Player 1, enter your choice (Rock r, Paper p, Scissors s):");
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                    player1 = consoleKeyInfo.Key switch
                    {
                        ConsoleKey.R => "Rock",
                        ConsoleKey.P => "Paper",
                        ConsoleKey.S => "Scissors",
                        _ => null
                    };
                }
                else if (player2 == null)
                {
                    Console.WriteLine("Player 2, enter your choice (Rock r, Paper p, Scissors s):");
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                    player2 = consoleKeyInfo.Key switch
                    {
                        ConsoleKey.R => "Rock",
                        ConsoleKey.P => "Paper",
                        ConsoleKey.S => "Scissors",
                        _ => null
                    };
                }

                if (player1 != null && player2 != null)
                {
                    game.PlayRound(
                        player1 == "Rock" ? rockpercentageEnum.Rock :
                        player1 == "Paper" ? rockpercentageEnum.Paper :
                        rockpercentageEnum.Scissors,
                        player2 == "Rock" ? rockpercentageEnum.Rock :
                        player2 == "Paper" ? rockpercentageEnum.Paper :
                        rockpercentageEnum.Scissors
                    );
                    Console.WriteLine($" {game.Player1.Name} chose: {player1}");
                    Console.WriteLine($" {game.Player2.Name} chose: {player2}");
                    Console.WriteLine($"Scores: {game.Player1.Name}: {game.Player1.Score}, {game.Player2.Name}: {game.Player2.Score}");

                    player1 = null;
                    player2 = null;
                    Console.WriteLine("do you want finish press f . Press any key to continue to the next round...");
                    ConsoleKeyInfo consoleKeyInfo = Console.ReadKey(true);
                    if (consoleKeyInfo.Key == ConsoleKey.F)
                    {
                        game.SaveScoresToFile();
                        break;
                    }
                }
            }
        }
    }

    class RockPaperScissors
    {
        public Player Player1 { get; private set; } = new Player("Player 1");
        public Player Player2 { get; private set; } = new Player("Player 2");
        public int draw { get; private set; } = 0;

        public string Winner => Player1.Score > Player2.Score ? Player1.Name : Player1.Score < Player2.Score ? Player2.Name : "Tie";
        public string Loser => Player1.Score < Player2.Score ? Player1.Name : Player1.Score > Player2.Score ? Player2.Name : "Tie";
        public static string SaveFile { get; private set; } = "RockPaperScissorsScores.txt";

        public int raund { get; private set; } = 0;
        public RockPaperScissors(string Player1Name, string Player2Name)
        {
            Player1 = new Player(Player1Name);
            Player2 = new Player(Player2Name);
        }
        public void PlayRound(rockpercentageEnum player1, rockpercentageEnum player2)
        {
            raund++;
            Player1.SetChoice(player1);
            Player2.SetChoice(player2);
            if (player1 == player2)
            {
                draw++;
                Console.WriteLine($"Round {raund}: It's a tie!");
            }
            else if ((player1 == rockpercentageEnum.Rock && player2 == rockpercentageEnum.Scissors) ||
                     (player1 == rockpercentageEnum.Paper && player2 == rockpercentageEnum.Rock) ||
                     (player1 == rockpercentageEnum.Scissors && player2 == rockpercentageEnum.Paper))
            {
                Player1.IncrementScore();
                Console.WriteLine($"Round {raund}: Player 1 wins!");
            }
            else
            {
                Player2.IncrementScore();
                Console.WriteLine($"Round {raund}: Player 2 wins!");
            }
        }

        public void SaveScoresToFile()
        {
            using (StreamWriter writer = new StreamWriter(SaveFile))
            {
                writer.WriteLine($"Final Scores: {Player1.Name}: {Player1.Score}, {Player2.Name}: {Player2.Score}   \n  raund {raund}");
                writer.WriteLine($"Winner: {Winner}");
                writer.WriteLine($"Loser: {Loser}");
            }
        }

        public static void ChangeSaveFile(string newSaveFile)
        {
            if (string.IsNullOrWhiteSpace(newSaveFile))
            {
                throw new ArgumentException("Save file name cannot be empty.");
            }
            RockPaperScissors.SaveFile = newSaveFile;
        }
    }

    class Player
    {
        public string Name { get; private set; }
        public int Score { get; private set; }
        public rockpercentageEnum playerChoise { get; private set; }
        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
        public void IncrementScore()
        {
            Score++;
        }
        public void SetChoice(rockpercentageEnum choice)
        {
            playerChoise = choice;
        }
    }

    enum rockpercentageEnum
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    }
}
