namespace cookbook;

public class Recipe : Ingredients
{
    private string _category, _description, _nameOfRecipe;

    public Recipe(string category, string description, string nameOfRecipe, string ingredient1, string ingredient2, string ingredient3,string ingredient4) : 
        base(ingredient1, ingredient2, ingredient3, ingredient4)
    {
        _category = category;
        _description = description;
        _nameOfRecipe = nameOfRecipe;
    }
    
    public string Category { get { return _category; } set { _category = value; } }
    public string Description { get { return _description; } set { _description = value; } }
    public string NameOfRecipe { get { return _nameOfRecipe; } set { _nameOfRecipe = value; } }
}