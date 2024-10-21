using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabajoPractico.Proyectos;
using TrabajoPractico;

namespace TrabajoPractico.Servicios
{
    public class SysProyectos
    {

        /* Queridos Compañeros, profesor. Les doy la bienvenida al maravilloso desastre que es mi codigo
         * Desarrollado por Lautaro Deatriz. Estoy completamente seguro que había formas más faciles
         de hacer lo que hice, pero que no le encontre la vuelta
        
         Me disculpo con ustedes y acepto cualquier castigo que me fuere impuesto por esta falta de 
        respeto a la profesión de Programador*/

        internal static void CrearProyecto(List<ProyectoMovil> proyectoM, List<ProyectoWeb> proyectoW)
        {
            int opcionProyecto, opcionEstado;
            Console.WriteLine("Vamos a crear un proyecto");
            do
            {
                Console.WriteLine("Es un proyecto: \n" +
                "1. Movile\n" +
                "2. Web ");
                opcionProyecto = int.Parse(Console.ReadLine());
            } while (opcionProyecto < 1 || opcionProyecto > 2);
            
            string nombre;
            int cantidadDeDesarrolladores;
            DateTime fechainicio, fechaEstimada; //Esto hay que borrarlo, tal vez

            Console.Clear();
            Console.WriteLine("Ingrese el nombre del proyecto");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de desarrolladores que trabajan en el proyecto");
            cantidadDeDesarrolladores = int.Parse(Console.ReadLine());

            do 
            {
                Console.WriteLine("Ingrese en que estado se encuentra su proyecto\n" +
                    "1. Planificacion\n" +
                    "2. En Desarrollo\n" +
                    "3. En Pruebas\n" +
                    "4. Completado\n" +
                    "5. Cancelado\n");
                opcionEstado = int.Parse(Console.ReadLine());
            }
            while (opcionEstado < 1 || opcionEstado > 5);


            // nombre, cantidadDeDesarrolladores, estado, fechaInicio, duracionEstimada (Datos del constructor base)
            if (opcionProyecto == 1) 
            {
                int plataforma;
                Console.WriteLine("En que plataforma desarrolla su proyecto\n" +
                    "1.Ios\n" +
                    "2.Android\n" +
                    "3.Windows phone\n");
                plataforma = int.Parse(Console.ReadLine());
                switch (opcionEstado)
                {
                    case 1:
                        switch (plataforma)
                        {
                            case 1:
                                ProyectoMovil Proyecto1 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Planificacion, Po.Ios);
                                Proyecto1.DuracionEstimada = Proyecto1.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto1);
                                break;
                            case 2:
                                ProyectoMovil Proyecto2 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Planificacion, Po.Android);
                                Proyecto2.DuracionEstimada = Proyecto2.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto2);
                                break;
                            case 3:
                                ProyectoMovil Proyecto3 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Planificacion, Po.WindowsPhone);
                                Proyecto3.DuracionEstimada = Proyecto3.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto3);
                                break;
                        }
                        break;
                    case 2:
                        switch (plataforma)
                        {
                            case 1:
                                ProyectoMovil Proyecto1 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.endesarrollo, Po.Ios);
                                Proyecto1.DuracionEstimada = Proyecto1.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto1);
                                break;
                            case 2:
                                ProyectoMovil Proyecto2 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.endesarrollo, Po.Android);
                                Proyecto2.DuracionEstimada = Proyecto2.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto2);
                                break;
                            case 3:
                                ProyectoMovil Proyecto3 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.endesarrollo, Po.WindowsPhone);
                                Proyecto3.DuracionEstimada = Proyecto3.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto3);
                                break;
                        }
                        break;
                    case 3:
                        switch (plataforma)
                        {
                            case 1:
                                ProyectoMovil Proyecto1 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Enpruebas, Po.Ios);
                                Proyecto1.DuracionEstimada = Proyecto1.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto1);
                                break;
                            case 2:
                                ProyectoMovil Proyecto2 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Enpruebas, Po.Android);
                                Proyecto2.DuracionEstimada = Proyecto2.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto2);
                                break;
                            case 3:
                                ProyectoMovil Proyecto3 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Enpruebas, Po.WindowsPhone);
                                Proyecto3.DuracionEstimada = Proyecto3.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto3);
                                break;
                        }
                        break;
                    case 4:
                        switch (plataforma)
                        {
                            case 1:
                                ProyectoMovil Proyecto1 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Completado, Po.Ios);
                                Proyecto1.DuracionEstimada = Proyecto1.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto1);
                                break;
                            case 2:
                                ProyectoMovil Proyecto2 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Completado, Po.Android);
                                Proyecto2.DuracionEstimada = Proyecto2.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto2);
                                break;
                            case 3:
                                ProyectoMovil Proyecto3 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Completado, Po.WindowsPhone);
                                Proyecto3.DuracionEstimada = Proyecto3.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto3);
                                break;
                        }
                        break;
                    case 5:
                        switch (plataforma)
                        {
                            case 1:
                                ProyectoMovil Proyecto1 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Cancelado, Po.Ios);
                                Proyecto1.DuracionEstimada = Proyecto1.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto1);
                                break;
                            case 2:
                                ProyectoMovil Proyecto2 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Cancelado, Po.Android);
                                Proyecto2.DuracionEstimada = Proyecto2.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto2);
                                break;
                            case 3:
                                ProyectoMovil Proyecto3 = new ProyectoMovil(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Cancelado, Po.WindowsPhone);
                                Proyecto3.DuracionEstimada = Proyecto3.CalcularFechaEstimada();
                                proyectoM.Add(Proyecto3);
                                break;
                        }
                        break;
                }
            }
            else if(opcionProyecto == 2)
            {
                int tecnologia;
                do
                {
                    Console.WriteLine("Ingrese la tecnologia con la que va a trabajar\n" +
                        "1. React\n" +
                        "2. Angular\n" +
                        "3. Vue.js\n");
                    tecnologia = int.Parse(Console.ReadLine());
                }
                while (tecnologia < 1 || tecnologia > 3);
                switch (opcionEstado) 
                {
                    case 1:
                        switch (tecnologia)
                        {
                            case 1:
                                ProyectoWeb Proyecto1 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Planificacion, TPA.React);
                                Proyecto1.DuracionEstimada = Proyecto1.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto1);
                                break;
                            case 2:
                                ProyectoWeb Proyecto2 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Planificacion, TPA.Angular);
                                Proyecto2.DuracionEstimada = Proyecto2.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto2);
                                break;
                            case 3:
                                ProyectoWeb Proyecto3 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Planificacion, TPA.Vue);
                                Proyecto3.DuracionEstimada = Proyecto3.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto3);
                                break;
                        }
                        break;
                    case 2:
                        switch (tecnologia)
                        {
                            case 1:
                                ProyectoWeb Proyecto1 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.endesarrollo, TPA.React);
                                Proyecto1.DuracionEstimada = Proyecto1.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto1);
                                break;
                            case 2:
                                ProyectoWeb Proyecto2 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.endesarrollo, TPA.Angular);
                                Proyecto2.DuracionEstimada = Proyecto2.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto2);
                                break;
                            case 3:
                                ProyectoWeb Proyecto3 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.endesarrollo, TPA.Vue);
                                Proyecto3.DuracionEstimada = Proyecto3.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto3);
                                break;
                        }
                        break;
                    case 3:
                        switch (tecnologia)
                        {
                            case 1:
                                ProyectoWeb Proyecto1 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Enpruebas, TPA.React);
                                Proyecto1.DuracionEstimada = Proyecto1.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto1);
                                break;
                            case 2:
                                ProyectoWeb Proyecto2 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Enpruebas, TPA.Angular);
                                Proyecto2.DuracionEstimada = Proyecto2.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto2);
                                break;
                            case 3:
                                ProyectoWeb Proyecto3 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Enpruebas, TPA.Vue);
                                Proyecto3.DuracionEstimada = Proyecto3.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto3);
                                break;
                        }
                        break;
                    case 4:
                        switch (tecnologia)
                        {
                            case 1:
                                ProyectoWeb Proyecto1 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Completado, TPA.React);
                                Proyecto1.DuracionEstimada = Proyecto1.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto1);
                                break;
                            case 2:
                                ProyectoWeb Proyecto2 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Completado, TPA.Angular);
                                Proyecto2.DuracionEstimada = Proyecto2.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto2);
                                break;
                            case 3:
                                ProyectoWeb Proyecto3 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Completado, TPA.Vue);
                                Proyecto3.DuracionEstimada = Proyecto3.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto3);
                                break;
                        }
                        break;
                    case 5:
                        switch (tecnologia)
                        {
                            case 1:
                                ProyectoWeb Proyecto1 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Cancelado, TPA.React);
                                Proyecto1.DuracionEstimada = Proyecto1.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto1);
                                break;
                            case 2:
                                ProyectoWeb Proyecto2 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Cancelado, TPA.Angular);
                                Proyecto2.DuracionEstimada = Proyecto2.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto2);
                                break;
                            case 3:
                                ProyectoWeb Proyecto3 = new ProyectoWeb(nombre, cantidadDeDesarrolladores, DateTime.Now, EstadoProyecto.Cancelado, TPA.Vue);
                                Proyecto3.DuracionEstimada = Proyecto3.CalcularFechaEstimada();
                                proyectoW.Add(Proyecto3);
                                break;
                        }
                        break;
                }
            }
        }

        internal static void VerProyectos(List<ProyectoMovil> proyectoM, List<ProyectoWeb> proyectoW)
        {
            int desicion = 0;      //Navegador del menú
            string userInput = ""; //Variable para verificar el parseo y evitar crasheos

            while (desicion != 1 && desicion != 2 && desicion != 3)
            {
                Console.WriteLine("Cuales proyectos desea ver?\n" +
                    "1. Moviles\n" +
                    "2. Webs\n" +
                    "3. Todos\n");

                userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput))
                {
                    int.TryParse(userInput, out desicion);
                }

                switch (desicion)
                {
                    case 1:
                        foreach(ProyectoMovil proyectoMovil in proyectoM)
                        {
                            proyectoMovil.VisualizarProyecto();
                        }

                        break;

                    case 2:
                        foreach (ProyectoWeb proyectoWeb in proyectoW)
                        {
                            proyectoWeb.VisualizarProyecto();
                        }

                        break;

                    case 3:
                        foreach (ProyectoMovil proyectoMovil in proyectoM)
                        {
                            proyectoMovil.VisualizarProyecto();
                        }

                        foreach (ProyectoWeb proyectoWeb in proyectoW)
                        {
                            proyectoWeb.VisualizarProyecto();
                        }

                        break;

                }
            }
        }
    }
}