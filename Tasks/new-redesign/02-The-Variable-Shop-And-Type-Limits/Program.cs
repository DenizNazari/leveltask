namespace LevelTask.Task02
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int aBigNumber = int.MaxValue;
            short aBigNegativeNumber = short.MinValue;
            short aBigPositiveNumber = short.MaxValue;
            Console.WriteLine(aBigNegativeNumber);
            Console.WriteLine(aBigPositiveNumber);
            Console.WriteLine(aBigNegativeNumber);
            double infinity = double.PositiveInfinity;
            Console.WriteLine(infinity);
            double notAnyRealNumber = double.NaN;
            Console.WriteLine(notAnyRealNumber);

            short a = 30000;
            short b = 30000;
            short sum = (short)(a + b);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine(short.MinValue);

            float aFloat = 10000;
            float bFloat = 0.00001f;
            float sumFloat = aFloat + bFloat;
            Console.WriteLine($"Sum: {sumFloat}");
        }
    }
}
