namespace BuilderPattern
{
    public class BuilderPatternDemo
    {
        public static void Main(string[] args)
        {
            var mealBuild = new MealBuilder();
            var meal = mealBuild.prepareVegMeal();

            Console.WriteLine("Veg Meal");
            meal.Show();
            Console.WriteLine($"Total Cost: {meal.Cost}");
        }
    }
}