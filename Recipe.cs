class Recipe
{
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public List<Step> Steps { get; set; }

    public Recipe(string name)
    {
        Name = name;
        Ingredients = new List<Ingredient>();
        Steps = new List<Step>();
    }

    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public void AddStep(Step step)
    {
        Steps.Add(step);
    }

    public void DisplayRecipe()
    {
        Console.WriteLine($"Recipe: {Name}");
        Console.WriteLine("Ingredients:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine("- " + ingredient);
        }
        Console.WriteLine("Steps:");
        foreach (var step in Steps)
        {
            Console.WriteLine("- " + step);
        }
    }
}