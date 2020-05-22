

namespace VehiculoMotorizadoAControlRemoto
{
    class Automovil : Vehiculo
    {
        private static int sunroof;
        private string _marca;
        private int _anio;
        private double _kilometraje;

        public Automovil(string marca, int anio, double kilometraje,bool sunroof,int asientos,int ruedas,
                            int puertas) : base(sunroof, asientos,ruedas,puertas)
        {
            _marca = marca;
            _anio = anio;
            _kilometraje = kilometraje;
            _sunroof = sunroof;
            _asientos = asientos;
            _ruedas = ruedas;
            _puertas = puertas;
        }

        public string Marca { get => _marca; set => _marca = value; }
        public int Anio { get => _anio; set => _anio = value; }
        public double Kilometraje { get => _kilometraje; set => _kilometraje = value; }

    }
}
