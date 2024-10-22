using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico.Proyectos
{
    internal abstract class GuardadoDeProyecto
    {
        static List<Proyecto> proyectos = new List<Proyecto>();
        static string guardadoDatos = "guardadoDatos.txt";

        // internal void AgregarProyecto()
        /* {

           Console.WriteLine("Ingrese nombre del proyecto:");
           string nombre = Console.ReadLine();
           Console.WriteLine("Ingrese el estado del proyecto:");
           EstadoProyecto estado = (EstadoProyecto)Enum.Parse(typeof(EstadoProyecto), Console.ReadLine());
           Console.WriteLine("Ingrese la cantidad de desarroladores:");
           int cantidadDesarrolladores = int.Parse(Console.ReadLine());
           Console.WriteLine("ingrese la fecha del inicio:");
           DateTime fechaInicio = DateTime.Parse(Console.ReadLine());


           proyectos.Add(new Proyecto(nombre, estado, cantidadDesarrolladores, fechaInicio ));

           Console.WriteLine("proyecto añadido correctamente:");




       }
      */
        //lo voy a corregir mas tarde xd


        public static void MostrarContacto()
        {
            Console.WriteLine("Lista de contactos:");
            foreach (var proyecto in proyectos)
            {
                Console.WriteLine(proyecto);
            }
        }

        public static void GuardarProyecto()
        {

            using (StreamWriter writer = new StreamWriter(guardadoDatos))
            {
                foreach (var proyecto in proyectos)
                {
                    writer.WriteLine($"{proyecto.Nombre}, {proyecto.Estado}, {proyecto.CantidadDesarroladores}, {proyecto.FechaInicio}");
                }
            }
            Console.WriteLine("Contacto Guardado exitosamente");

        }


        public static void CargarProyecto()
        {
            if (File.Exists(guardadoDatos))
            {
                using (StreamReader reader = new StreamReader(guardadoDatos))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] datos = linea.Split('|');
                        string nombre = datos[0];
                        int cantidadDesarrolladores = int.Parse(datos[1]);

                        //  EstadoProyecto estado = Enum.


                        //     proyectos.Add(new Proyecto(nombre, cantidadDesarrolladores, fechaInicio, estado));

                        //puede ser que se corrija creando una clase la cual herede los parametros de proyecto y usar esa clase heredada en vez de proyecto
                        //
                    }
                }
                Console.WriteLine("Proyecto cargado correctamente");
            }
        }

    }
}//cuando funcione pasar la funciones al menú 
    

