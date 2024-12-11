namespace Abaxrekruttering {


    internal abstract class Vehicles {
        protected int _kiloWatt; //_maxSpeed;
        protected string _hallmark, _type; // _colour, type;

        public Vehicles(int kiloWatt, string hallmark, string type) {
            this._kiloWatt = kiloWatt;
            this._hallmark = hallmark;
            this._type = type;
        }
       
        public abstract void printInfo();
    }
}
