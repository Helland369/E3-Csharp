namespace cookbook;

public class Ingredients
{
    protected string _ingredient1, _ingredient2, _ingredient3, _ingredient4;

    public Ingredients (string ingredient1, string ingredient2, string ingredient3, string ingredient4)
    {
        _ingredient1 = ingredient1;
        _ingredient2 = ingredient2;
        _ingredient3 = ingredient3;
        _ingredient4 = ingredient4;
    }
    
    public string Ingredient1 { get { return _ingredient1; } set { _ingredient1 = value; } }
    public string Ingredient2 { get { return _ingredient2; } set { _ingredient2 = value; } }
    public string Ingredient3 { get { return _ingredient3; } set { _ingredient3 = value; } }
    public string Ingredient4 { get { return _ingredient4; } set { _ingredient4 = value; } }
}