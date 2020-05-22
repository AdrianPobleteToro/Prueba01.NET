

namespace VehiculoMotorizadoAControlRemoto
{
    abstract class Vehiculo
    {
        Motor _motor;
        Estanque _estanque;
        Mezclador _mezclador;
        Rueda _rueda;
        public Vehiculo(string idMotor, TipoMotor tipoMotor, int cilindrada, double capacidad,
            TipoMezclador mezclador, int numRuedas, Recubrimiento recubrimiento,
            int minDurometro, int maxDurometro)
        {
            _motor = new Motor(idMotor, tipoMotor, cilindrada);
            _estanque = new Estanque(capacidad);
            _mezclador = new Mezclador(mezclador);
            _rueda = new Rueda(recubrimiento, minDurometro, maxDurometro);
        }

        public Motor Motor { get => _motor; set => _motor = value; }
        public Estanque Estanque { get => _estanque; set => _estanque = value; }
        public Mezclador Mezclador { get => _mezclador; set => _mezclador = value; }
        public Rueda Rueda { get => _rueda; set => _rueda = value; }
    }
}
