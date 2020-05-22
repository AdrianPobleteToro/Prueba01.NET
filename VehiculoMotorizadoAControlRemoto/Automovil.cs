
namespace VehiculoMotorizadoAControlRemoto
{
    class Automovil : Vehiculo
    {
        private string _marca;
        private int _ano;
        private int _kilometraje;

        public Automovil(string idMotor, TipoMotor tipoMotor, int cilindrada,
                         string marca, int ano, int kilometraje,double capacidad,
                         TipoMezclador mezclador, int numRuedas, 
                         Recubrimiento recubrimiento,int minDurometro,
                         int maxDurometro) : base(idMotor, tipoMotor,
                         cilindrada,capacidad,mezclador,numRuedas,recubrimiento,minDurometro,
                         maxDurometro)
        {
            _marca = marca;
            _ano = ano;
            _kilometraje = kilometraje;
        }

        public string Marca { get => _marca; set => _marca = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public int Kilometraje { get => _kilometraje; set => _kilometraje = value; }
    }
}
