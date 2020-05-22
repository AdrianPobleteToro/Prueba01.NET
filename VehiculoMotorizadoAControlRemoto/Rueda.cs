

namespace VehiculoMotorizadoAControlRemoto
{
    enum Recubrimiento
    {
        FENOL,HULE,POLIURETANO
    }
    class Rueda : VehiculoComponentes
    {
        private Recubrimiento _recubrimiento;
        private int _numRuedas;
        private int _minDurometro;
        private int _maxDurometro;
        private int _durometro;

        public Rueda(Recubrimiento recubrimiento, int minDurometro, int maxDurometro) : base()
        { 
            _recubrimiento = recubrimiento;
            _minDurometro = minDurometro;
            _maxDurometro = maxDurometro;
            _durometro = MaxDurometro - MinDurometro;
        }

        public Recubrimiento Recubrimiento => _recubrimiento;
        public int NumRuedas { get => _numRuedas; set => _numRuedas = value; }
        public int MinDurometro { get => _minDurometro; set => _minDurometro = value; }
        public int MaxDurometro { get => _maxDurometro; set => _maxDurometro = value; }
        public int Durometro { get => _durometro; set => _durometro = value; }
    }
}
