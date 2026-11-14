namespace LevelTask.Task18
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point x = new Point(5, 10);
            Point y = new Point(15, 20);
            Console.WriteLine($"Point x: ({x.X}, {x.Y})");
            Console.WriteLine($"Point y: ({y.X}, {y.Y})");
        }
    }

    class Point
    {
        public float X { get; private set; } = 0;
        public float Y { get; private set; } = 0;
        public Point() : this(0, 0)
        {
        }

        public Point(float x, float y)
        {
            X = x;
            Y = y;
        }
        public void setPoint(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
