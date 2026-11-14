namespace LevelTask.Task17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Vin Fletcher's Arrows
            Arrow arrow1 = new Arrow(ArrowHeadTypeEnum.Steel, FletchingTypeEnum.Plastic, 80);
            Console.WriteLine($"Arrow 1 cost: {arrow1.GetCost()} gold");
        }
    }

    class Arrow
    {
        private float _shaftLength;
        private static int MinShaftLength = (int)ShaftLengthEnum.Min;
        private static int MaxShaftLength = (int)ShaftLengthEnum.Max;
        public ArrowHeadTypeEnum ArrowHeadType { get; private set; }
        public FletchingTypeEnum FletchingType { get; private set; }
        public float ShaftLength
        {
            get => _shaftLength;
            set
            {
                if (value >= MinShaftLength && value <= MaxShaftLength)
                {
                    _shaftLength = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Shaft length must be between 60 and 100 centimeters.");
                }
            }
        }
        public Arrow(ArrowHeadTypeEnum arrowHeadType, FletchingTypeEnum fletchingType, int shaftLength)
        {
            this.ArrowHeadType = arrowHeadType;
            this.FletchingType = fletchingType;
            this.ShaftLength = shaftLength;
        }
        public float GetCost()
        {
            int arrowHeadCost = (int)ArrowHeadType;
            int fletchingCost = (int)FletchingType;
            float shaftCost = ShaftLength * 0.05f;
            return arrowHeadCost + fletchingCost + shaftCost;
        }
        public static void ChangeMinShaftLenght(int newMinShaftLength)
        {
            if (newMinShaftLength < 0 || newMinShaftLength > MaxShaftLength)
            {
                throw new ArgumentOutOfRangeException("New minimum shaft length must be between 0 and the maximum shaft length.");
            }
            MinShaftLength = newMinShaftLength;
        }
    }

    enum ArrowHeadTypeEnum : int
    {
        Steel = 10,
        WOOD = 3,
        Obsidian = 5
    }
    enum FletchingTypeEnum : int
    {
        Plastic = 10,
        TurkeyFeathers = 5,
        GooseFeathers = 3
    }

    enum ShaftLengthEnum : int
    {
        Min = 60,
        Max = 100
    }
}
