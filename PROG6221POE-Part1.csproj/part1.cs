using System;

// Define a record for an ingredient with properties for name, quantity, and unit.
public record Ingredient(string Name, double Quantity, string Unit);

// Define a class for a recipe step with a description property.
public class Step
{
    public string Description { get; set; }
}

// Define a class for a recipe with arrays for ingredients and steps.
public class Recipe
{
    public Ingredient[] Ingredients { get; set; }
    public Step[] Steps { get; set; }
}

class Program
{
    // Declare a static field to store the current recipe.
    static Recipe currentRecipe;

    static void Main(string[] args)
    {
        // Initialize a new recipe object.
        currentRecipe = new Recipe();

        // Prompt the user to enter the number of ingredients.
        Console.WriteLine("Enter the number of ingredients:");
        int ingredientCount = int.Parse(Console.ReadLine());
        // Create an array to store the ingredients based on the user input.
        currentRecipe.Ingredients = new Ingredient[ingredientCount];

        // Iterate through each ingredient to collect its details.
        for (int i = 0; i < ingredientCount; i++)
        {
            Console.WriteLine($"Enter name of ingredient {i + 1}:");
            string name = Console.ReadLine();

            Console.WriteLine($"Enter quantity of {name}:");
            double quantity = double.Parse(Console.ReadLine());

            Console.WriteLine($"Enter unit of measurement for {name}:");
            string unit = Console.ReadLine();

            // Create a new Ingredient object and add it to the array.
            currentRecipe.Ingredients[i] = new Ingredient { Name = name, Quantity = quantity, Unit = unit };
        }

        // Display the recipe.
        DisplayRecipe();

        // Additional functionality such as scaling, resetting, and clearing methods can be implemented here.
    }

    // Method to display the recipe's ingredients.
    static void DisplayRecipe()
    {
        Console.WriteLine("Recipe:");
        // Iterate through each ingredient and display its details.
        foreach (var ingredient in currentRecipe.Ingredients)
        {
            Console.WriteLine($"{ingredient.Quantity} {ingredient.Unit} {ingredient.Name}");
        }

        // Similar logic for displaying recipe steps can be added here.
    }
}