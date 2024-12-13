namespace ShapeControllSystem
{


    class Circle : Shape
    {

        private double _radius;

        public Circle(string name, string colour, double radius) : base(name, colour)
        {
            this._radius = radius;
        }

        public double _Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        public override double calculateAerea()
        {
            return 3.14 * _radius * _radius;
        }
    }
}
