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
            int decision = 0;      //Navegador del menú
            string userInput = ""; //Variable para verificar el parseo y evitar crasheos

            Console.Clear();

            while(decision < 1 && decision > 3)
            {
                Console.WriteLine("Cuales proyectos desea ver?\n" +
                    "1. Moviles\n" +
                    "2. Webs\n" +
                    "3. Todos\n");

                userInput = Console.ReadLine();
                if (!string.IsNullOrEmpty(userInput))
                {
                    int.TryParse(userInput, out decision);
                }

                switch(decision)
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

                    default:
                        Console.WriteLine("Opcion invalida");

                        break;
                } //switch
                Console.WriteLine("\nPresione cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            } // while
        

               
        }

        internal static void QuitarProyecto(List<ProyectoMovil> proyectoM, List<ProyectoWeb> proyectoW)
        {
            int opcion;
            do
            {
                Console.WriteLine($"¿Desea eliminar un elemento de la lista Movil (1) o de la lista Web (2)?");
                opcion = int.Parse( Console.ReadLine() );
            } while (opcion < 1 || opcion > 2);
            if (opcion == 1)
            {
                string nombreProyecto;
                foreach (var proyecto in proyectoM)
                {
                    proyecto.VisualizarProyecto();
                }
                Console.WriteLine("Ingrese el nombre del proyecto que desea eliminar");
                nombreProyecto = Console.ReadLine();
                int indice = 0, indiceSeleccionado = 0;
                foreach (var proyecto in proyectoM)
                {
                    indice = indice + 1;
                    if(nombreProyecto == proyecto.Nombre)
                    {
                        indiceSeleccionado = indice;
                    }
                }

                for (int i = 1; i <= proyectoM.Count; i++)
                {
                    if(i == indiceSeleccionado)
                    {
                        proyectoM.RemoveAt(i - 1);
                    }
                    
                }

            }
            else if (opcion == 2) 
            {
                string nombreProyecto;
                foreach (var proyecto in proyectoW)
                {
                    proyecto.VisualizarProyecto();
                }
                Console.WriteLine("Ingrese el nombre del proyecto que desea eliminar");
                nombreProyecto = Console.ReadLine();
                int indice = 0, indiceSeleccionado = 0;
                foreach (var proyecto in proyectoW)
                {
                    indice = indice + 1;
                    if (nombreProyecto == proyecto.Nombre)
                    {
                        indiceSeleccionado = indice;
                    }
                }

                for (int i = 1; i <= proyectoW.Count; i++)
                {
                    if (i == indiceSeleccionado)
                    {
                        proyectoW.RemoveAt(i - 1);
                    }

                }
            }
        }

        internal static void ModificarProyecto(List<ProyectoMovil> proyectoM, List<ProyectoWeb> proyectoW)
        {
            int desicion = 0;      //Navegador del menu
            string userInput = ""; //Variable para verificar el parseo y evitar crasheos
            Console.Clear();
            Console.WriteLine("Porfavor, escriba el nombre de el proyecto al cual desea modificar.");

            int enumIndice = 0;

            while (string.IsNullOrEmpty(userInput))
            {
                Console.WriteLine("(Debe ser un nombre válido)");
                userInput = Console.ReadLine();
            }

            foreach(ProyectoMovil proyectoMovil in proyectoM)
            {
                if(proyectoMovil.Nombre == userInput)
                {
                    Console.WriteLine("Cual dato desea modificar?\n" +
                        "1. Nombre\n" +
                        "2. Cantidad de desarrolladores\n" +
                        "3. Estado\n" +
                        "4. Plataforma objetivo\n" +
                        "5. Salir");

                    while(desicion < 1 && desicion > 5)
                    {
                        userInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(userInput))
                        {
                            int.TryParse(userInput, out desicion);
                        }

                        switch (desicion)
                        {
                            case 1:
                                Console.WriteLine($"Porfavor, elija el nuevo nombre del proyecto.\n" +
                                    $"(Actual: {proyectoMovil.Nombre})");
                                userInput = Console.ReadLine();

                                if (!string.IsNullOrEmpty(userInput))
                                {
                                    proyectoMovil.Nombre = userInput;
                                    Console.WriteLine("Nombre actualizado correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("Nombre no detectado, porfavor," +
                                        " intente nuevamente.");
                                    desicion = 0;
                                }

                                Console.ReadKey();
                                break;

                            case 2:
                                Console.WriteLine($"Porfavor, especifique la cantidad de desarrolladores" +
                                    $"a actualizar.\n" +
                                    $"(Valor actual: {proyectoMovil.CantidadDesarroladores})");
                                userInput = Console.ReadLine();
                                int cantidadDesarrolladores = 0;

                                if (string.IsNullOrEmpty(userInput))
                                {
                                    if (int.TryParse(userInput, out cantidadDesarrolladores))
                                    {
                                        proyectoMovil.CantidadDesarroladores = cantidadDesarrolladores;
                                        Console.WriteLine("Valor actualizado correctamente.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Valor invalido detectado, intente nuevamente.");
                                        desicion = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Valor no detectado. Porfavor, intente nuevamente.");
                                    desicion = 0;
                                }

                                Console.ReadKey();
                                break;

                            case 3:
                                Console.WriteLine($"Porfavor, elija un estado dentro de los existentes.\n" +
                                    $"0. {EstadoProyecto.Planificacion}\n" +
                                    $"1. En desarrollo\n" +
                                    $"2. En pruebas" +
                                    $"3. {EstadoProyecto.Completado}\n" +
                                    $"4. {EstadoProyecto.Cancelado}\n" +
                                    $"(Actual: {proyectoMovil.Estado})");

                                userInput = Console.ReadLine();
                                enumIndice = 0; ;

                                if (!string.IsNullOrEmpty(userInput) && int.TryParse(userInput, out enumIndice) && enumIndice < 5 && enumIndice > -1)
                                {
                                    proyectoMovil.Estado = (EstadoProyecto)enumIndice;
                                    Console.WriteLine("Estado actualizado correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("El valor ingresado no es valido, por favor," +
                                        " intente nuevamente.");
                                    desicion = 0;
                                }

                                break;

                            case 4:
                                Console.WriteLine($"Porfavor, elija la plataforma objetivo dentro de las" +
                                    $" existentes.\n" +
                                    $"0. {Po.Ios}\n" +
                                    $"1. {Po.Android}\n" +
                                    $"2. {Po.WindowsPhone}\n" +
                                    $"(Actual:{proyectoMovil.PlataformasObjetiva})");

                                userInput = Console.ReadLine();
                                enumIndice = 0; ;

                                if (!string.IsNullOrEmpty(userInput) && int.TryParse(userInput, out enumIndice) && enumIndice < 3 && enumIndice > -1)
                                {
                                    proyectoMovil.PlataformasObjetiva = (Po)enumIndice;
                                    Console.WriteLine("Plataforma objetivo cambiada correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("El valor ingresado no es valido, por favor," +
                                        " intente nuevamente.");
                                    desicion = 0;
                                }

                                break;

                            case 5:
                                
                                break;

                            default:
                                Console.WriteLine("Opcion invalida.");

                                break;
                        } //switch
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    } //while
                } //if
            } //foreach

            foreach(ProyectoWeb proyectoWeb in proyectoW)
            {
                if (proyectoWeb.Nombre == userInput)
                {
                    Console.WriteLine("Cual dato desea modificar?\n" +
                        "1. Nombre\n" +
                        "2. Cantidad de desarrolladores\n" +
                        "3. Estado\n" +
                        "4. Tecnologia principal asociada\n" +
                        "5. Salir");

                    while (desicion < 1 && desicion > 5)
                    {
                        userInput = Console.ReadLine();
                        if (!string.IsNullOrEmpty(userInput))
                        {
                            int.TryParse(userInput, out desicion);
                        }

                        switch (desicion)
                        {
                            case 1:
                                Console.WriteLine($"Porfavor, elija el nuevo nombre del proyecto.\n" +
                                    $"(Actual: {proyectoWeb.Nombre})");
                                userInput = Console.ReadLine();

                                if (!string.IsNullOrEmpty(userInput))
                                {
                                    proyectoWeb.Nombre = userInput;
                                    Console.WriteLine("Nombre actualizado correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("Nombre no detectado, porfavor," +
                                        " intente nuevamente.");
                                    desicion = 0;
                                }

                                Console.ReadKey();
                                break;

                            case 2:
                                Console.WriteLine($"Porfavor, especifique la cantidad de desarrolladores" +
                                    $"a actualizar.\n" +
                                    $"(Valor actual: {proyectoWeb.CantidadDesarroladores})");
                                userInput = Console.ReadLine();
                                int cantidadDesarrolladores = 0;

                                if (string.IsNullOrEmpty(userInput))
                                {
                                    if (int.TryParse(userInput, out cantidadDesarrolladores))
                                    {
                                        proyectoWeb.CantidadDesarroladores = cantidadDesarrolladores;
                                        Console.WriteLine("Valor actualizado correctamente.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Valor invalido detectado, intente nuevamente.");
                                        desicion = 0;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Valor no detectado. Porfavor, intente nuevamente.");
                                    desicion = 0;
                                }

                                Console.ReadKey();
                                break;

                            case 3:
                                Console.WriteLine($"Porfavor, elija un estado dentro de los existentes.\n" +
                                    $"0. {EstadoProyecto.Planificacion}\n" +
                                    $"1. En desarrollo\n" +
                                    $"2. En pruebas" +
                                    $"3. {EstadoProyecto.Completado}\n" +
                                    $"4. {EstadoProyecto.Cancelado}\n" +
                                    $"(Actual: {proyectoWeb.Estado})");

                                userInput = Console.ReadLine();
                                enumIndice = 0;

                                if (!string.IsNullOrEmpty(userInput) && int.TryParse(userInput, out enumIndice) && enumIndice < 5 && enumIndice > -1)
                                {
                                    proyectoWeb.Estado = (EstadoProyecto)enumIndice;
                                    Console.WriteLine("Estado cambiado correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("El valor ingresado no es valido, por favor," +
                                        " intente nuevamente.");
                                    desicion = 0;
                                }

                                break;

                            case 4:
                                Console.WriteLine($"Porfavor, ingrese la tecnologia principal asociada" +
                                    $" dentro de las existentes.\n" +
                                    $"0. {TPA.React}\n" +
                                    $"1. {TPA.Angular}\n" +
                                    $"2. {TPA.Vue}\n" +
                                    $"(Actual: {proyectoWeb.TecnologiaPrincipalAsociada})");

                                userInput = Console.ReadLine();
                                enumIndice = 0;

                                if (!string.IsNullOrEmpty(userInput) && int.TryParse(userInput, out enumIndice) && enumIndice < 5 && enumIndice > -1)
                                {
                                    proyectoWeb.TecnologiaPrincipalAsociada = (TPA)enumIndice;
                                    Console.WriteLine("Tecnologia principal cambiada correctamente.");
                                }
                                else
                                {
                                    Console.WriteLine("El valor ingresado no es valido, por favor," +
                                        " intente nuevamente.");
                                    desicion = 0;
                                }

                                break;

                            case 5:

                                break;

                            default:
                                Console.WriteLine("Opcion invalida.");

                                break;
                        } //switch
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        Console.Clear();
                    } //while
                }

            }
        }
    }
}