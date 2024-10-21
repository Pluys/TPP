using System.Security.Cryptography.X509Certificates;
using TrabajoPractico.Proyectos;
using TrabajoPractico.Servicios;

namespace TrabajoPractico
{
    class Program
    {
        static void Main()
        {
            int desicion = 10;     //Navegador del menú
            string userInput = ""; //Variable para verificar el parseo y evitar crasheos

            List<Proyecto> proyectos = new List<Proyecto>();
            List<ProyectoMovil> proyectoM = new List<ProyectoMovil>();
            List<ProyectoWeb> proyectoW = new List<ProyectoWeb>();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenido.");
            Console.ForegroundColor = ConsoleColor.White;

            while (desicion != 0 && desicion != 5) //Menu
            {
                desicion = 10;
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
                    int.TryParse(userInput, out desicion);
                }

                switch (desicion) //Opciones
                {
                    case 0:
                        Console.WriteLine("Guardar y salir");

                        break;

                    case 1:
                        Console.WriteLine("Opcion 1 - Agregar Proyecto");
                        Agregar.CrearProyecto(proyectoM, proyectoW);

                        // Estos dos foreach los agregue solo para visualizar lo cargado. No van acá

                        foreach(var  proyecto in proyectoM)
                        {
                            Console.WriteLine($"Nombre: {proyecto.Nombre}\n" +
                                $"cantidad de Desarrolladores: {proyecto.CantidadDesarroladores}\n" +
                                $"Fecha inicio: {proyecto.FechaInicio}\n" +
                                $"Duracíon Estimada: {proyecto.DuracionEstimada} \n" +
                                $"Estado del proyecto: {proyecto.Estado} \n" +
                                $"Plataforma objetiva: {proyecto.PlataformasObjetiva}");
                        }

                        foreach(var proyecto in proyectoW)
                        {
                            Console.WriteLine($"Nombre: {proyecto.Nombre}\n" +
                                $"cantidad de Desarrolladores: {proyecto.CantidadDesarroladores}\n" +
                                $"Fecha inicio: {proyecto.FechaInicio}\n" +
                                $"Duracíon Estimada: {proyecto.DuracionEstimada} \n" +
                                $"Estado del proyecto: {proyecto.Estado} \n" +
                                $"Tecnologia Principal: {proyecto.TecnologiaPrincipalAsociada}");
                        }
                        break;
                        

                    case 2:
                        Console.WriteLine("Opcion 2 - Quitar Proyecto");

                        break;

                    case 3:
                        Console.WriteLine("Opcion 3 - Modificar Proyecto");

                        break;

                    case 4:
                        Console.WriteLine("Opcion 4 - Ver Proyecto");

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