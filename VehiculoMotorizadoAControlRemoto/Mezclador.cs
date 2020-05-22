
namespace VehiculoMotorizadoAControlRemoto
{
    enum TipoMezclador
    {
        CARBURADOR,INYECTOR
    }
    class Mezclador : VehiculoComponentes
    {
        private TipoMezclador _tipo;


        public Mezclador(TipoMezclador tipo) : base()
        {
            _tipo = tipo;
        }

        public TipoMezclador Tipo => _tipo;
    }
}
