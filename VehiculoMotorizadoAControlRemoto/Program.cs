using System;
using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;

namespace VehiculoMotorizadoAControlRemoto
{
    class Program
    {

        public static Recubrimiento recubrimiento = new Recubrimiento();
        public static TipoMotor tipo = new TipoMotor();
        public static TipoMezclador mezclador = new TipoMezclador();
        public static double capacidad, litros;//estanque
        public static int opcion, cc = -1;
        public static int numRuedas = 0, minDurometro = 0, maxDurometro = 0;
        public static string idMotor;
        public static ArrayList autos = new ArrayList();
        static void Main(string[] args)
        {           
            LogeoUsuario();
        }

        public static void LogeoUsuario()
        {
            string usuario = string.Empty;
            string password = string.Empty;
            int intentosPermitidos = 3, intentosRealizados = 0;
            Console.WriteLine("Ingresar usuario y contraseña para acceder a la consola.");
            while (true)
            {
                Console.WriteLine("Usuario: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                password = Console.ReadLine();
                intentosRealizados++;
                if (usuario == "admin" && password == "abc123")
                {
                    Console.WriteLine("Logueo realizado.");
                    MenuAutomovil();
                    break;
                }
                else
                {
                    if(intentosPermitidos > intentosRealizados)
                        Console.WriteLine("**\n" +
                        "Una de las credenciales es incorrecta\n" +
                        "vuelve a intentarlo\n" +
                        "**");
                    else
                    {
                        Console.WriteLine("Limite de intentos alcanzado, la aplicación se cerrará");
                        Environment.Exit(0);
                        break;
                    }
                }
            }
        }

        public static void MenuAutomovil()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Construccion de un automovil.");
                Console.WriteLine("1.- Ingresar Nuevo Automovil");
                Console.WriteLine("2.- Listar Automovil");
                Console.WriteLine("3.- Salir de la aplicación");
                opcion = 0;
                string input = Console.ReadLine();
                if (int.TryParse(input, out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Indicar marca de automovil.");
                            string marca = Console.ReadLine();
                            Console.WriteLine("Indicar año de automovil");
                            int ano = int.Parse(Console.ReadLine());
                            Console.WriteLine("Indicar kilometraje de automovil");
                            int kilometraje = int.Parse(Console.ReadLine());
                            MenuMotor(); 
                            MenuMezclador();
                            MenuEstanque();
                            MenuRueda();
                            Automovil automovil = new Automovil(idMotor,tipo,cc,marca,ano,kilometraje,
                                capacidad,mezclador,numRuedas,recubrimiento,minDurometro,maxDurometro);
                            autos.Add(automovil);
                            Console.WriteLine("**\n" +
                                "Ingreso de nuevo automovil realizado con exito.\n" +
                                "**");
                            Console.ReadKey();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine("Lista de autos ingresados:\n" +
                                "    ");
                            foreach (Automovil autoNuevo in autos)
                            {
                                Console.WriteLine("idMotor: " + autoNuevo.Motor.IdMotor);
                                Console.WriteLine("Motor: " + autoNuevo.Motor.TipoMotor);
                                Console.WriteLine("Cilindrada: " + autoNuevo.Motor.Cilindrada);
                                Console.WriteLine("Marca: " + autoNuevo.Marca);
                                Console.WriteLine("Año: " + autoNuevo.Ano);
                                Console.WriteLine("Kilometraje: " + autoNuevo.Kilometraje);
                                Console.WriteLine("Capacidad Estanque: " + autoNuevo.Estanque.Capacidad);
                                Console.WriteLine("Mezclador: " + autoNuevo.Mezclador.Tipo);
                                Console.WriteLine("Recubrimiento de Rueda: " + autoNuevo.Rueda.Recubrimiento);
                                Console.WriteLine("Rango de durometro: {0} valor mínimo: {1} valor máximo: {2}",
                                    autoNuevo.Rueda.Durometro, autoNuevo.Rueda.MinDurometro, autoNuevo.Rueda.MaxDurometro);
                                Console.WriteLine("  \n" +
                                    ">\n" +
                                    "  ");
                            }
                            Console.ReadKey();

                            break;

                        case 3:
                            Console.WriteLine("Saliendo...");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Opcion ingresada no válida");
                            break;
                    }
                }
            }

        }

        public static void MenuEstanque()
        {
            Console.WriteLine("ESPECIFICACIONES DEL ESTANQUE");
            Console.WriteLine("Indicar capacidad de estanque");
            capacidad = double.Parse(Console.ReadLine());
            Console.WriteLine("Indicar cuanto combustible se le desea cargar");
            litros = double.Parse(Console.ReadLine());
        }

        public static void MenuMezclador()
        {
            opcion = 0;
            do
            {
                Console.WriteLine("Seleccionar tipo de mezclador: \n" +
                    "Carburador[1]\n" +
                    "Inyector[2]\n" +
                    "Solo una opción:");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
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
                            mezclador = TipoMezclador.CARBURADOR;
                            break;
                        case 2:
                            mezclador = TipoMezclador.INYECTOR;
                            break;
                        default:
                            Console.WriteLine("\n" +
                                "ENTRADA INCORRECTA, VOLVER A INTENTAR\n " +
                                "");
                            break;
                    }
                }
            }while (opcion != 1 && opcion != 2);
        }
        
        public static void MenuRueda()
        {
            opcion = 0;
            do
            {
                Console.WriteLine("ESPECIFICACIÓN DE RUEDA DE AUTOMOVIL");
                Console.WriteLine("Especificar número de ruedas");
                numRuedas = int.Parse(Console.ReadLine());
                Console.WriteLine("Seleccionar una opción para el tipo de Recubrimiento \n" +
                    "-Fenol       [1]\n" +
                    "-Hule        [2]\n" +
                    "-Poliuretano [3]");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
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
                            recubrimiento = Recubrimiento.FENOL;
                            break;
                        case 2:
                            recubrimiento = Recubrimiento.HULE;
                            break;
                        case 3:
                            recubrimiento = Recubrimiento.POLIURETANO;
                            break;
                        default:
                            Console.WriteLine("\n" +
                            "ENTRADA INCORRECTA, VOLVER A INTENTAR\n " +
                            "");
                            break;

                    }

                }

            } while (opcion != 1 && opcion != 2 && opcion != 3);

            Console.WriteLine("Rango del durometro se obtiene indicando el Valor Minimo y Valor máximo");
            while (true)
            {
                try
                {
                    Console.WriteLine("Valor mínimo:");
                    minDurometro = int.Parse(Console.ReadLine());
                    Console.WriteLine("Valor máximo:");
                    maxDurometro = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error al ingresar datos, deben ser números enteros");
                }
                if (minDurometro == maxDurometro)
                    Console.WriteLine("El número mínimo no debe ser igual al máximo, volver a ingresar.");
                else if (minDurometro < maxDurometro)
                    break;
                else
                    Console.WriteLine("El número mínimo no debe ser mayor al máximo, volver a ingresar.");
                Console.WriteLine("");
            }
        }

        public static void MenuMotor()
        {
            opcion = 0;
            Console.WriteLine("ESPECIFICACIÓN DEL MOTOR");
            Console.WriteLine("Indicar id del motor");
            idMotor = Console.ReadLine();
            do
            {
                Console.WriteLine("Seleccionar opción del tipo de motor: \n" +
                    "Motor de 2 tiempos [1]\n" +
                    "Motor de 4 tiempos [2]");
                try
                {
                    opcion = int.Parse(Console.ReadLine());
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
                            tipo = TipoMotor.DOS_TIEMPOS;
                            break;
                        case 2:
                            tipo = TipoMotor.CUATRO_TIEMPOS;
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
            string input = Console.ReadLine();
            if (!int.TryParse(input, out cc))
                Console.WriteLine("No se ingresó correctamente el valor indicado, por defecto se le asignó -1");

        }
    }
}
