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

            var nonVegMeal = mealBuild.PrepareNonVegMeal();

            Console.WriteLine("Veg Meal");
            nonVegMeal.Show();
            Console.WriteLine($"Total Cost: {nonVegMeal.Cost}");


        }
    }
}