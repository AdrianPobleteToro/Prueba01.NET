using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoMotorizadoAControlRemoto
{
    class Estanque : VehiculoComponentes
    {
        private readonly double _capacidad;
        private double _litros;

        
        public Estanque(double capacidad)
        {
            _capacidad = capacidad;
        }

        public double Litros { get => _litros; set => _litros = value; }

        public double Capacidad => _capacidad;


        /* Método “MitadCombustible” que retorne un 
         * booleano en el caso de que los litros sean 
         * mayores a 10.5 % de la capacidad y menor o 
         * igual al 50.0 % de la capacidad.*/
        public bool MitadCombustible()
        {
            if(Capacidad*0.105 < Litros && Capacidad*0.5 > Litros)
                return true;

            return false;
        }

        /* Método “BajoCombustible” que retorne un
         * booleano en el caso de que los litros sean 
         * igual o menor a 10.5 % de la capacidad del 
         * estanque.*/
        public bool BajoCombustible()
        {
            if (Capacidad*0.105 > Litros)
                return true;

            return false;
        }
    }
}
