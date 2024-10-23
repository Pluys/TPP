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
        static string guardadoDatosWeb = "guardadoDatosWeb.txt";
        static string guardadoDatosMovil = "guardadoDatosMovil.txt";


        public static void GuardarProyecto(List<ProyectoWeb> proyectosW, List<ProyectoMovil> proyectosM)
        {

            using (StreamWriter writer = new StreamWriter(guardadoDatosWeb))
            {
                foreach (var proyecto in proyectosW)
                {
                    writer.WriteLine($"{proyecto.Nombre},{proyecto.CantidadDesarroladores},{proyecto.FechaInicio},{proyecto.DuracionEstimada},{proyecto.Estado},{proyecto.TecnologiaPrincipalAsociada}");
                }
            }
            Console.WriteLine("Proyecto guardado exitosamente");

            using (StreamWriter writer = new StreamWriter(guardadoDatosMovil))
            {
                foreach (var proyecto in proyectosM)
                {
                    writer.WriteLine($"{proyecto.Nombre},{proyecto.CantidadDesarroladores},{proyecto.FechaInicio},{proyecto.DuracionEstimada},{proyecto.Estado},{proyecto.PlataformasObjetiva}");
                }
            }
            Console.WriteLine("Proyecto guardado exitosamente");

        }


        public static void CargarProyecto(List<ProyectoWeb> proyectosW, List<ProyectoMovil> proyectosM)
        {
            if (File.Exists(guardadoDatosWeb))
            {
                using (StreamReader reader = new StreamReader(guardadoDatosWeb))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        string nombre = datos[0];
                        int cantidadDesarrolladores = int.Parse(datos[1]);
                        DateTime fechaInicio = DateTime.Parse(datos[2]);
                        DateTime duracionEstimada = DateTime.Parse(datos[3]);
                        EstadoProyecto estado = (EstadoProyecto)Enum.Parse(typeof(EstadoProyecto), datos[4]);
                        TPA tecnologiaPrincipalAsociada = (TPA) Enum.Parse(typeof(TPA), datos[5]);

                        proyectosW.Add(new ProyectoWeb(nombre, cantidadDesarrolladores, fechaInicio, duracionEstimada, estado, tecnologiaPrincipalAsociada));
                        
                    
                    }
                }
                Console.WriteLine("Proyecto cargado correctamente");
            } if (File.Exists(guardadoDatosMovil))
            {
                using (StreamReader reader = new StreamReader(guardadoDatosMovil))
                {
                    string linea;
                    while ((linea = reader.ReadLine()) != null)
                    {
                        string[] datos = linea.Split(',');
                        string nombre = datos[0];
                        int cantidadDesarrolladores = int.Parse(datos[1]);
                        DateTime fechaInicio = DateTime.Parse(datos[2]);
                        DateTime fechaEstimada = DateTime.Parse(datos[3]);
                        EstadoProyecto estado = (EstadoProyecto)Enum.Parse(typeof(EstadoProyecto), datos[4]);
                        Po plataformasObjetivas = (Po)Enum.Parse(typeof(Po), datos[5]);

                        proyectosM.Add(new ProyectoMovil(nombre, cantidadDesarrolladores, fechaInicio, fechaEstimada, estado,plataformasObjetivas));

                        
                    }
                }
                Console.WriteLine("Proyecto cargado correctamente");
            }
        }

    }
}//cuando funcione pasar la funciones al menú 
    

