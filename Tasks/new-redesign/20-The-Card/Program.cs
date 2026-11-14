namespace LevelTask.Task20
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {
                CartColors color = (CartColors)i;
                for (int j = 0; j < 14; j++)
                {
                    CartTypes type = (CartTypes)j;
                    Cart cart = new Cart(color, type);
                    cart.DisplayCartInfo();
                }
            }
        }
    }

    class Cart
    {
        public CartColors Color { get; private set; }
        public CartTypes Type { get; private set; }

        public string GetStringRepresentation()
        {
            string colorString = Color switch
            {
                CartColors.Red => "Red",
                CartColors.Green => "Green",
                CartColors.Blue => "Blue",
                CartColors.Yellow => "Yellow",
                _ => throw new ArgumentOutOfRangeException()
            };
            string typeString = Type switch
            {
                CartTypes.ONE => "1",
                CartTypes.TWO => "2",
                CartTypes.THREE => "3",
                CartTypes.FOUR => "4",
                CartTypes.FIVE => "5",
                CartTypes.SIX => "6",
                CartTypes.SEVEN => "7",
                CartTypes.EIGHT => "8",
                CartTypes.NINE => "9",
                CartTypes.TEN => "10",
                CartTypes.DollarSign => "DollarSign",
                CartTypes.PercentSign => "PercentSign",
                CartTypes.Caret => "Caret",
                CartTypes.Ampersand => "Ampersand",
                _ => throw new ArgumentOutOfRangeException()
            };
            return $"{colorString} {typeString}";
        }
        public string GetCartInfo()
        {
            return $"{Color} {Type}";
        }
        public string cartcarakter => (int)Type > 10 ? "Special Character" : "Regular Character";
        public Cart(CartColors color, CartTypes type)
        {
            Color = color;
            Type = type;
        }
        public void DisplayCartInfo()
        {
            color cartColor = Color switch
            {
                CartColors.Red => color.Red,
                CartColors.Green => color.Green,
                CartColors.Blue => color.Blue,
                CartColors.Yellow => color.Yellow,
            };
            cartColor.setConsoleColor();
            string text = $"Cart Color: {Color}, Cart Type: {Type}, Cart Character: {cartcarakter}";
            string cartText = GetStringRepresentation();
            string paddedText = ("    The " + cartText).PadRight(25);
            Console.WriteLine($"""
  XXXXXXXXXXXXXXXXXXXXXXXXXXXXX
 XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
XXXX                         XXXX
XXXX                         XXXX
XXXX                         XXXX
XXXX{paddedText}XXXX
XXXX                         XXXX
XXXX                         XXXX
XXXX                         XXXX
XXXX                         XXXX
 XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
  XXXXXXXXXXXXXXXXXXXXXXXXXXXX
""");

            cartColor.resetConsoleColor();
        }
    }

    enum CartColors
    {
        Red,
        Green,
        Blue,
        Yellow,
    }
    enum CartTypes : int
    {
        ONE,
        TWO,
        THREE,
        FOUR,
        FIVE,
        SIX,
        SEVEN,
        EIGHT,
        NINE,
        TEN,
        DollarSign,
        PercentSign,
        Caret,
        Ampersand
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

        public static color Red => new color(255, 0, 0);
        public static color Yellow => new color(255, 255, 0);
        public static color Green => new color(0, 255, 0);
        public static color Blue => new color(0, 0, 255);
    }
}
