namespace ShapeControllSystem
{


    class Triangle : Shape
    {
        private double _height, _triangleBase;

        public Triangle(string name, string colour, double height, double triangleBase) : base(name, colour)
        {
            this._height = height;
            this._triangleBase = triangleBase;
        }

        public double _Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double _TriangleBase
        {
            get { return _triangleBase; }
            set { _triangleBase = value; }
        }

        public override double calculateAerea()
        {
            return 0.5 * _triangleBase * _height;
        }
    }
}
