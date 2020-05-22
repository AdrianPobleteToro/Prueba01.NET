using System;

namespace VehiculoMotorizadoAControlRemoto
{
    enum TipoMotor
    {
        DOS_TIEMPOS,CUATRO_TIEMPOS
    }
    class Motor : VehiculoComponentes
    {

        private TipoMotor _tipoMotor;
        private string _idMotor;
        private int _cilindrada;
        public Motor(string idMotor, TipoMotor tipoMotor, int cilindrada) : base()
        {
            _idMotor = idMotor;
            _tipoMotor = tipoMotor;
            _cilindrada = cilindrada;
        }

        public string IdMotor { get => _idMotor; set => _idMotor = value; }
        public int Cilindrada { get => _cilindrada; set => _cilindrada = value; }
        public TipoMotor TipoMotor => _tipoMotor;
    }
}
