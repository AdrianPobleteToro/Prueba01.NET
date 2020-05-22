

namespace VehiculoMotorizadoAControlRemoto
{
    public abstract class Vehiculo
    {
        protected bool _sunroof;
        protected int _asientos;
        protected int _ruedas;
        protected int _puertas;

        protected Vehiculo(bool sunroof, int asientos, int ruedas, int puertas)
        {
            _sunroof = sunroof;
            _asientos = asientos;
            _ruedas = ruedas;
            _puertas = puertas;
        }

        public bool Sunroof { get => _sunroof; set => _sunroof = value; }
        public int Asientos { get => _asientos; set => _asientos = value; }
        public int Ruedas { get => _ruedas; set => _ruedas = value; }
        public int Puertas { get => _puertas; set => _puertas = value; }
    }
}
