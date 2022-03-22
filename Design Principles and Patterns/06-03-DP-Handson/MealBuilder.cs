namespace BuilderPattern
{
    public class MealBuilder
    {
        public Meal prepareVegMeal()
        {
            var meal = new Meal();
            meal.AddItem(new VegBurger());
            meal.AddItem(new Coke());
            return meal;
        }
    }
}