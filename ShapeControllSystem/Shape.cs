namespace ShapeControllSystem
{


    abstract class Shape
    {

        protected string _name, _colour;

        public Shape(string name, string colour)
        {
            this._name = name;
            this._colour = colour;
        }

        public string _Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string _Colour
        {
            get { return _colour; }
            set { _colour = value; }
        }

        public abstract double calculateAerea();
    }
}
