

namespace VehiculoMotorizadoAControlRemoto
{
    class Rueda : VehiculoComponentes
    {
        private string _recubrimiento;
        private int _durometro;

        public Rueda(string recubrimiento, int durometro)
        { 
            _recubrimiento = recubrimiento;
            _durometro = durometro;
        }

        public string Recubrimiento { get => _recubrimiento; set => _recubrimiento = value; }
        public int Durometro { get => _durometro; set => _durometro = value; }
    }
}
