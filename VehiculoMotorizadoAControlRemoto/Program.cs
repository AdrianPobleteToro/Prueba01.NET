using System;
using System.Diagnostics;

namespace VehiculoMotorizadoAControlRemoto
{
    class Program
    {
        const double estComp = 0.25;
        static void Main(string[] args)
        {
            MenuMotor();
        }

        public static void LogeoUsuario()
        {
            string usuario = string.Empty;
            string password = string.Empty;
            bool valido = false;
            Console.WriteLine("Ingresar usuario y contraseña para acceder a la consola.");
            do
            {
                Console.WriteLine("Usuario: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                password = Console.ReadLine();

                if (usuario == "admin" && password == "abc123")
                {
                    valido = true;
                }
                else
                {
                    Console.WriteLine("**\n" +
                        "Una de las credenciales es incorrecta\n" +
                        "vuelve a intentarlo\n" +
                        "**");
                }

            } while (valido == false);

            Console.WriteLine("Logueo realizado.");
        }

        public static void MenuAutomovil()
        {
            Console.WriteLine("CONSTRUCCIÓN DE VEHICULO MOTORIZADO A CONTROL REMOTO");
            Console.WriteLine("Vehículo: ");
            /*string marca, int anio, double kilometraje,bool sunroof,int asientos,int ruedas,
                            int puertas)*/
            Console.WriteLine("Ingresar marca del vehículo");
            string marca = Console.ReadLine();
            Console.WriteLine("Especificar año de vehículo");
            int anio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Indicar kilometraje del vehículo");
            double km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Posee sunroof? (SI/NO)");
            string sunroof = Console.ReadLine();
            bool sunR = false;
            if (sunroof == "SI")
                sunR = true;
            Console.WriteLine("Número de asientos");
            int nAsientos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cuantas ruedas posee el vehículo");
            int nRuedas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Número de puertas:");
            int nPuertas = Convert.ToInt32(Console.ReadLine());

            Automovil auto1 = new Automovil(marca, anio, km, sunR, nAsientos, nRuedas, nPuertas);

            Console.WriteLine("- Marca: {0} \n" +
                "- Año: {1} \n" +
                "- Kilometraje {2} \n" +
                "- Sunroof {3} \n" +
                "- Num. Asientos {4} \n" +
                "- Num. Ruedas {5} \n" +
                "- Num. Puertas {6}", auto1.Marca, auto1.Anio, auto1.Kilometraje,
                auto1.Sunroof, auto1.Asientos, auto1.Ruedas, auto1.Puertas);

            Console.Read();
        }

        public static void MenuEstanque()
        {
            Console.WriteLine("ESPECIFICACIONES DEL ESTANQUE");
            Console.WriteLine("Indicar capacidad de estanque");
            double capacidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indicar cuanto combustible se le desea cargar");
            double litros = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Estado de carga combustible");
            Console.WriteLine("");

            Estanque estanqueAuto1 = new Estanque(capacidad, litros);

            Console.WriteLine("- Capacidad estanque: {0} \n" +
                "- Litros de combustible cargados: {1}lts.", estanqueAuto1.Capacidad, estanqueAuto1.Litros);
            Console.WriteLine("Estado carga estanque Mitad {0} / Bajo la mitad {1}",
                estanqueAuto1.MitadCombustible(), estanqueAuto1.BajoCombustible());
            Console.Read();
        }

        public static void MenuMezclador()
        {
            int opcion = 0;
            string tipo = string.Empty;
            do
            {
                Console.WriteLine("Seleccionar tipo de mezclador: \n" +
                    "Carburador[1]\n" +
                    "Inyector[2]\n" +
                    "Solo una opción:");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se admite 1 o 2");
                }
                finally
                {
                    switch(opcion)
                    {
                        case 1:
                            tipo = "Carburador";
                            break;
                        case 2:
                            tipo = "Inyector";
                            break;
                        default:
                            Console.WriteLine("\n" +
                                "ENTRADA INCORRECTA, VOLVER A INTENTAR\n " +
                                "");
                            break;
                    }
                }
            } while (opcion != 1 && opcion != 2);


            Mezclador mezcladorAuto1 = new Mezclador(tipo);
            Console.WriteLine("-Tipo: {0} \n" +
                "-Estado Componentes : {1}%", mezcladorAuto1.Tipo, mezcladorAuto1.EstadoComponente * 100);
        }

        public static void MenuRueda()
        {
            int opcion = 0;
            string tipo = string.Empty;
            do
            {
                Console.WriteLine("ESPECIFICACIÓN DE RUEDA DE AUTOMOVIL");
                Console.WriteLine("Seleccionar una opción para el tipo de Recubrimiento \n" +
                    "-Fenol       [1]\n" +
                    "-Hule        [2]\n" +
                    "-Poliuretano [3]");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("La opción ingresada debe ser 1, 2 o 3");
                }
                finally
                {
                    switch (opcion)
                    {
                        case 1:
                            tipo = "Fenol";
                            break;
                        case 2:
                            tipo = "Hule";
                            break;
                        case 3:
                            tipo = "Poliuretano";
                            break;
                        default:
                            Console.WriteLine("\n" +
                            "ENTRADA INCORRECTA, VOLVER A INTENTAR\n " +
                            "");
                            break;

                    }

                }

            } while (opcion != 1 && opcion != 2 && opcion != 3);

            int min = 0, max = 0, durometro = 0;
            Console.WriteLine("Rango del durometro se obtiene indicando el Valor Minimo y Valor máximo");
            while (durometro == 0)
            {
                try
                {
                    Console.WriteLine("Valor mínimo:");
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Valor máximo:");
                    max = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al ingresar datos, deben ser números enteros");
                }
                finally
                {
                    if (min == max)
                    {
                        Console.WriteLine("El número mínimo no debe ser igual al máximo, volver a ingresar.");
                    }
                    else if (min < max)
                    {
                        durometro = max - min;
                    }
                    else
                    {
                        Console.WriteLine("El número mínimo no debe ser mayor al máximo, volver a ingresar.");
                    }
                }
                Console.WriteLine("");
            }
            Rueda ruedaAuto1 = new Rueda(tipo, durometro);
            Console.WriteLine("- Tipo{0}\n" +
                "- Durómetro {1}\n" +
                "- Estado Componentes: {2}%", ruedaAuto1.Recubrimiento, ruedaAuto1.Durometro, ruedaAuto1.EstadoComponente * 100);
        }

        public static void MenuMotor()
        {
            int opcion = 0, id = 0;
            double cc = 0.0;
            TipoDeMotor tipo = new TipoDeMotor();
            Console.WriteLine("ESPECIFICACIÓN DEL MOTOR");
            do
            {
                Console.WriteLine("Seleccionar opción del tipo de motor: \n" +
                    "Motor de 2 tiempos [1]\n" +
                    "Motor de 4 tiempos [2]");
                try
                {
                    opcion = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se admite 1 o 2");
                }
                finally
                {
                    switch (opcion)
                    {
                        case 1:
                            tipo = TipoDeMotor.DOS_TIEMPOS;
                            break;
                        case 2:
                            tipo = TipoDeMotor.CUATRO_TIEMPOS;
                            break;
                        default:
                            Console.WriteLine("\n" +
                                "ENTRADA INCORRECTA, VOLVER A INTENTAR\n " +
                                "");
                            break;
                    }
                }
            } while (opcion != 1 && opcion != 2);
            Console.WriteLine("Indicar el tamaño de la cilindrada");
            while (cc == 0)
            {
                try
                {
                    cc = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Solo se admiten caracteres numéricos, ingresa nuevamente.");
                }
            }
            Motor motorAuto1 = new Motor(++id, tipo, cc);

            Console.WriteLine("- id: {0}\n" +
                "- Tipo Motor: {1}\n" +
                "- Cilindrada: {2}cc\n" +
                "- Estado Componentes: {3}%", motorAuto1.Id, motorAuto1.Tipo,
                motorAuto1.Cilindrada, motorAuto1.EstadoComponente * 100);
        }
    }
}
