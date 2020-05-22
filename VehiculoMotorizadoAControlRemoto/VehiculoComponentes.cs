using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoMotorizadoAControlRemoto
{
    abstract class VehiculoComponentes
    {
        private double _estadoComponente { get; set; }
        protected VehiculoComponentes()
        {
            _estadoComponente = 100.0;
        }
        public double EstadoComponente { 
          get => _estadoComponente; 
          set => _estadoComponente = value; 
        }
    }
}
