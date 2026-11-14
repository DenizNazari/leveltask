namespace LevelTask.Task07
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Watchtower
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            //version 1
            string direction1 = "";
            if (y > 0)
            {
                direction1 += "N";
            }
            else if (y < 0)
            {
                direction1 += "S";
            }
            if (x > 0)
            {
                direction1 += "E";
            }
            else if (x < 0)
            {
                direction1 += "W";
            }

            Console.WriteLine(direction1);

            string direction2 = "";
            if (y > 0 && x > 0)
            {
                direction2 = "NE";
            }
            else if (y > 0 && x < 0)
            {
                direction2 = "NW";
            }
            else if (y < 0 && x > 0)
            {
                direction2 = "SE";
            }
            else if (y < 0 && x < 0)
            {
                direction2 = "SW";
            }
            else if (y == 0 && x > 0)
            {
                direction2 = "E";
            }
            else if (y == 0 && x < 0)
            {
                direction2 = "W";
            }
            else if (x == 0 && y > 0)
            {
                direction2 = "N";
            }
            else if (x == 0 && y < 0)
            {
                direction2 = "S";
            }
            else
            {
                direction2 = "Origin";
            }
            Console.WriteLine(direction2);
        }
    }
}
