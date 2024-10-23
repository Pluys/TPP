using System.Security.Cryptography.X509Certificates;
using TrabajoPractico.Proyectos;
using TrabajoPractico.Servicios;

namespace TrabajoPractico
{
    class Program
    {
        static void Main()
        {
            int decision = 10;     //Navegador del menú
            string userInput = ""; //Variable para verificar el parseo y evitar crasheos

            List<Proyecto> proyectos = new List<Proyecto>();
            List<ProyectoMovil> proyectoM = new List<ProyectoMovil>();
            List<ProyectoWeb> proyectoW = new List<ProyectoWeb>();
            GuardadoDeProyecto.CargarProyecto(proyectoW, proyectoM);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenido.");
            Console.ForegroundColor = ConsoleColor.White;

            while (decision != 0 && decision != 5) //Menu
            {
                decision = 10;
                Console.WriteLine("---Menu---\n" +
                    "0. Guardar y salir\n" +
                    "1. Agregar proyecto\n" +
                    "2. Quitar proyecto\n" +
                    "3. Modificar proyecto\n" +
                    "4. Ver proyectos\n" +
                    "5. Salir");

                userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput))
                {
                    int.TryParse(userInput, out decision);
                }

                switch (decision) //Opciones
                {
                    case 0:
                        Console.WriteLine("Guardar y salir");
                        GuardadoDeProyecto.GuardarProyecto(proyectoW,proyectoM);
                        break;

                    case 1:
                        Console.WriteLine("Opcion 1 - Agregar Proyecto");
                        SysProyectos.CrearProyecto(proyectoM, proyectoW);
                        break;
                        

                    case 2:
                        Console.WriteLine("Opcion 2 - Quitar Proyecto");
                        SysProyectos.QuitarProyecto(proyectoM, proyectoW);
                        break;

                    case 3:
                        Console.WriteLine("Opcion 3 - Modificar Proyecto");

                        break;

                    case 4:
                        SysProyectos.VerProyectos(proyectoM, proyectoW);

                        break;

                    case 5:
                        Console.WriteLine("Salir sin guardar");

                        break;

                    default:
                        Console.WriteLine("Opcion invalida");

                        break;
                } //switch
                EndMenu();
            } //while

            static void EndMenu()
            {
                Console.WriteLine("\nPresione cualquier tecla para continar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}