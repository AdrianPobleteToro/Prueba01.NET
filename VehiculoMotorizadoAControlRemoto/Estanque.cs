using System;
using System.Collections.Generic;
using System.Text;

namespace VehiculoMotorizadoAControlRemoto
{
    class Estanque : VehiculoComponentes
    {
        private double _capacidad;
        private double _litros;

        
        public Estanque(double capacidad, double litros)
        {
            _capacidad = capacidad;
            _litros = litros;
        }

        public double Capacidad { get => _capacidad; set => _capacidad = value; }
        public double Litros { get => _litros; set => _litros = value; }


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
