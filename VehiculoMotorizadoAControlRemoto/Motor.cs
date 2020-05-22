

using System;

namespace VehiculoMotorizadoAControlRemoto
{
    enum TipoDeMotor
    {
        DOS_TIEMPOS,CUATRO_TIEMPOS
    }
    class Motor : VehiculoComponentes
    {
        private readonly int _id;
        private TipoDeMotor _tipo;
        private double _cilindrada;

        
        public Motor(int id,TipoDeMotor tipo,double cilindrada)
        {
            _id = id;
            _tipo = tipo;
            _cilindrada = cilindrada;
        }

        public int Id => _id;

        public TipoDeMotor Tipo => _tipo; 
        public double Cilindrada { get => _cilindrada; set => _cilindrada = value; }
    }
}
