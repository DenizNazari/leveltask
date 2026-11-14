namespace LevelTask.Task19
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            color newCOLOR = new color(67, 12, 24);
            newCOLOR.testYourColor();
            color newCOLOR2 = new color(23, 233, 100);
            newCOLOR2.testYourColor();
        }
    }

    class color
    {
        private int _r;
        private int _g;
        private int _b;
        public int R
        {
            get => _r;
            private set
            {
                if (value <= 0 && value >= 255)
                {
                    throw new ArgumentOutOfRangeException("R value must be between 0 and 255.");
                }
                _r = value;
            }
        }
        public int G
        {
            get => _g;
            private set
            {
                if (value <= 0 && value >= 255)
                {
                    throw new ArgumentOutOfRangeException("G value must be between 0 and 255.");
                }
                _g = value;
            }
        }
        public int B
        {
            get => _b;
            private set
            {
                if (value <= 0 && value >= 255)
                {
                    throw new ArgumentOutOfRangeException("B value must be between 0 and 255.");
                }
                _b = value;
            }
        }

        public color() : this(0, 0, 0)
        {
        }
        public color(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public void testYourColor()
        {
            string YourColor = $"\x1b[38;2;{R};{G};{B}m";
            string reset = "\x1b[0m";

            Console.WriteLine($"{YourColor}Your color is: R:{R}, G:{G}, B:{B}{reset}");
        }

        public void setConsoleColor()
        {
            string YourColor = $"\x1b[38;2;{R};{G};{B}m";
            Console.WriteLine(YourColor);
        }
        public void resetConsoleColor()
        {
            string reset = "\x1b[0m";
            Console.WriteLine(reset);
        }

        public static (int r, int g, int b) CreateColor()
        {
            Console.WriteLine("Enter R value (0-255):");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter G value (0-255):");
            int g = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B value (0-255):");
            int b = int.Parse(Console.ReadLine());
            return (r, g, b);
        }
        public static color White => new color(255, 255, 255);
        public static color Black => new color(0, 0, 0);
        public static color Red => new color(255, 0, 0);
        public static color Orange => new color(255, 165, 0);
        public static color Yellow => new color(255, 255, 0);
        public static color Green => new color(0, 255, 0);
        public static color Blue => new color(0, 0, 255);
        public static color Gold => new color(255, 215, 0);

        public static string setColorText(color color, string text)
        {
            string colorText = $"\x1b[38;2;{color.R};{color.G};{color.B}m{text}\x1b[0m";
            return colorText;
        }
    }
}
