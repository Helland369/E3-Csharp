namespace cookbook;

public class InOutPut
{
    private int input;
    
    private List<Recipe> _recipes = new List<Recipe>
    {
        new Recipe("Vegen", "A classic salad", "Cæcar salad", "Lettuce", "Onion", "Tomato", "Cucumber"),
        new Recipe("Vegen", "A salad with beetroot", "Beetroot salad", "Ginger", "Celery", "Leek", "Beetroot"),
        new Recipe("Snack", "A great salad", "A good salad", "Hot dog", "Hot dog bread", "Ketchup", "Mustard"),
        new Recipe("Snack", "A delicious sandwitc","Sandwich", "Bread", "Ham", "Bacon", "Lettuce"),
        new Recipe("Dinner", "Moms Meet balls", "Meet balls", "Ground beef", "Potato flour", "Milk", "Eggs"),
        new Recipe("Dinner", "A lovely Pizza Dough","Pizza Dough", "Flour", "Yeast", "Water", "Salt"),
    };

    public InOutPut()
    {
        MainMenu();
    }
    
    private void PrintRecipeList()
    {
        foreach (Recipe recipie in _recipes)
        {
            Console.WriteLine($"Category: {recipie.Category}\n" +
                              $"Description: {recipie.Description}\n" +
                              $"Ingredient 1: {recipie.Ingredient1}\n" +
                              $"Ingredient 2: {recipie.Ingredient2}\n" +
                              $"Ingredient 3: {recipie.Ingredient3}\n" +
                              $"Ingredient 4: {recipie.Ingredient4}\n");
        }
    }

    private void SearchForIngredients()
    {
        Console.WriteLine("Search for an ingredients");
        
        string input = Console.ReadLine().Trim().ToUpper();
        
        var result = _recipes.FindAll(x => x.Ingredient1.ToUpper() == input ||
                                         x.Ingredient2.ToUpper() == input ||
                                         x.Ingredient3.ToUpper() == input ||
                                         x.Ingredient4.ToUpper() == input);

        if (result.Count > 0)
        {
            foreach (Recipe recipe in result)
            {
                Console.WriteLine(recipe.NameOfRecipe);   
            }
        }
    }

    private void FilterByCategory()
    {
        _recipes.Sort((Recipe x, Recipe y) => x.Category.CompareTo(y.Category));

        foreach (Recipe recipe in _recipes)
        {
            Console.WriteLine(recipe.Category + " " + recipe.NameOfRecipe);   
        }
    }

    private void PrintRecipeWithIndex()
    {
        for (int i = 0; i < _recipes.Count; i++)
        {
            Console.WriteLine($"Index: [{i + 1}]\n{_recipes[i].Category}\n{_recipes[i].NameOfRecipe}");
        }
    }
    
    private int SelectRecipe()
    {
        PrintRecipeWithIndex();
        
        Console.WriteLine("Select a index to get the full information about the recipe");
        
        int input = Convert.ToInt32(Console.ReadLine());
        
        return input;
    }

    private void ReadSelectedRecipe(int input)
    {
        if (input > 0 && input <= _recipes.Count)
        {
            Recipe selectedRecipe = _recipes[input - 1];
            Console.WriteLine($"Name: {selectedRecipe.NameOfRecipe}\n" +
                              $"Category: {selectedRecipe.Category}\n" +
                              $"Description: {selectedRecipe.Description}\n" +
                              $"Ingredient1: {selectedRecipe.Ingredient1}\n" +
                              $"Ingredient2: {selectedRecipe.Ingredient2}\n" +
                              $"Ingredient3: {selectedRecipe.Ingredient3}\n" +
                              $"Ingredient4: {selectedRecipe.Ingredient4}\n");
        }
    }
    
    private void EditTextInRecipe()
    {
        string editedText;
        
        PrintRecipeWithIndex();
        
        int input = Convert.ToInt32(Console.ReadLine());

        ReadSelectedRecipe(input);
        
        Console.WriteLine("Select the text you want to edit" +
                          "Example: name or ingredient1");
        
        string inputRecipieItem = Console.ReadLine();
        
        Recipe selectedRecipe = _recipes[input - 1];
        if (String.Equals(inputRecipieItem, "name", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Write what the text you want to replace the current text of Recipe name with");
            editedText = Console.ReadLine();
            selectedRecipe.NameOfRecipe = editedText;
            editedText = "";
        } 
        else if (String.Equals(inputRecipieItem, "Category", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Write what the text you want to replace the current text of Category with");
            editedText = Console.ReadLine();
            selectedRecipe.Category = editedText;
            editedText = "";
        }
        else if (String.Equals(inputRecipieItem, "Description", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Write what the text you want to replace the current text of Description with");
            editedText = Console.ReadLine();
            selectedRecipe.Description = editedText;
            editedText = "";
        }
        else if (String.Equals(inputRecipieItem, "Ingredient1", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Write what the text you want to replace the current text of Ingredient 1 with");
            editedText = Console.ReadLine();
            selectedRecipe.Ingredient1 = editedText;
            editedText = "";
        }
        else if (String.Equals(inputRecipieItem, "Ingredient2", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Write what the text you want to replace the current text of Ingredient 2 with");
            editedText = Console.ReadLine();
            selectedRecipe.Ingredient2 = editedText;
            editedText = "";
        }
        else if (String.Equals(inputRecipieItem, "Ingredient3", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Write what the text you want to replace the current text of Ingredient 3 with");
            editedText = Console.ReadLine();
            selectedRecipe.Ingredient3 = editedText;
            editedText = "";
        }
        else if (String.Equals(inputRecipieItem, "Ingredient4", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Write what the text you want to replace the current text of Ingredient 4 with");
            editedText = Console.ReadLine();
            selectedRecipe.Ingredient4 = editedText;
            editedText = "";
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
    
    public void MainMenu()
    {
        while (true)
        {
                Console.WriteLine("[1] Print Recipe List\n" +
                                  "[2] Search for ingredient\n" +
                                  "[3] Filter by Category\n" +
                                  "[4] Get More info about the recipe\n" +
                                  "[5] Edit text\n" +
                                  "[0] EXIT");
                
                input = Convert.ToInt32(Console.ReadLine());
                
            switch (input)
            {
                case 0:
                    return;
                case 1:
                    PrintRecipeList();
                    break;
                case 2:
                    SearchForIngredients();
                    break;
                case 3:
                    FilterByCategory();
                    break;
                case 4:
                    ReadSelectedRecipe(SelectRecipe());
                    break;
                case 5:
                    EditTextInRecipe();
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    break;
            }
        }
    }
}
