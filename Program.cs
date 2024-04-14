class Program
{
    static void Main()
    {
        Recipe recipe = new Recipe("Chocolate Cake");

        Console.WriteLine("Enter ingredients for the recipe (name, quantity, unit):");
        string ingredientInput = Console.ReadLine();
        string[] ingredientData = ingredientInput.Split(',');
        Ingredient ingredient = new Ingredient(ingredientData[0], double.Parse(ingredientData[1]), ingredientData[2]);
        recipe.AddIngredient(ingredient);

        Console.WriteLine("Enter steps for the recipe:");
        string stepDescription = Console.ReadLine();
        Step step = new Step(stepDescription);
        recipe.AddStep(step);

        recipe.DisplayRecipe();
    }
}
