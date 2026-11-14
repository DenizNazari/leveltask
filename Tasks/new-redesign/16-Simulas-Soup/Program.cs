namespace LevelTask.Task16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            (FoodTypeEnum FType, FoodManingredientEnum FMain, FoodSeasoningEnum FSeason) food()
            {
                while (true)
                {
                    Console.WriteLine("Enter the food type (soup, stew, gumbo):\n");
                    var inputFoodType = Console.ReadLine();
                    Console.WriteLine("Enter the food main ingredient (chicken,mushroom,carrot,patatoes):\n");
                    var inputFoodMain = Console.ReadLine();
                    Console.WriteLine("Enter the food seasoning(spicy,salty,sweet):\n");
                    var inputSeasoning = Console.ReadLine();

                    if (Enum.TryParse<FoodTypeEnum>(inputFoodType, true, out FoodTypeEnum foodType)
                        && Enum.TryParse<FoodManingredientEnum>(inputFoodMain, true, out FoodManingredientEnum foodMain)
                        && Enum.TryParse<FoodSeasoningEnum>(inputSeasoning, true, out FoodSeasoningEnum foodSeasoning))
                    {
                        return (foodType, foodMain, foodSeasoning);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid food type.");
                    }
                }
            }

            (FoodTypeEnum FType, FoodManingredientEnum FMain, FoodSeasoningEnum FSeason) Food = food();

            Console.WriteLine($"Food Type: {Food.FType}, Main Ingredient: {Food.FMain}, Seasoning: {Food.FSeason}");
            Console.WriteLine($"Food: {Food.FSeason}  {Food.FMain} {Food.FType}");
        }
    }

    enum FoodTypeEnum
    {
        soup,
        stew,
        gumbo
    }
    enum FoodManingredientEnum
    {
        chicken,
        mushroom,
        carrot,
        patatoes
    }
    enum FoodSeasoningEnum
    {
        spicy,
        salty,
        sweet
    }
}
