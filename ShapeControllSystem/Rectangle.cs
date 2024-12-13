namespace ShapeControllSystem {


    class Rectangle : Shape
    {
        private double _length, _width;

        public Rectangle(string name, string colour, double lenght, double width) : base(name, colour)
        {
            this._length = lenght;
            this._width = width;
        }

        public double _Length {
            get { return _length; }
            set { _length = value; }
        }

        public double _Width {
            get { return _width; }
            set { _width = value; }
        }

        public override double calculateAerea()
        {
            return _length * _width;
        }
    }
}
