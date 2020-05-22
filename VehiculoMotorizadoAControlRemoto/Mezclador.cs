

namespace VehiculoMotorizadoAControlRemoto
{
    class Mezclador : VehiculoComponentes
    {
        private string _tipo;

        public Mezclador(string tipo)
        {
            _tipo = tipo;
        }

        public string Tipo { get => _tipo; set => _tipo = value; }
    }
}
