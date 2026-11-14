using System.Windows.Forms;

namespace LevelTask.Task24
{
    internal class Program
    {
        private static bool _winFormsInitialized;

        public static void Main(string[] args)
        {
            Console.WriteLine("15-Puzzle (Boss Battle) Windows Forms uygulaması başlatılıyor...");

            Thread uiThread = new Thread(() =>
            {
                if (!_winFormsInitialized)
                {
                    Application.SetHighDpiMode(HighDpiMode.SystemAware);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    _winFormsInitialized = true;
                }

                Application.Run(new BossBattlePuzzle15.Form1());
            });

            uiThread.SetApartmentState(ApartmentState.STA);
            uiThread.Start();
            uiThread.Join();
        }
    }
}
