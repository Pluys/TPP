using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico.Proyectos
{
    public  class ProyectoWeb : Proyecto
    {
        private TPA _tecnologiaPrincipalAsociada;
        public const int DuracionPromedio = 120;

        public TPA TecnologiaPrincipalAsociada
        {
            get { return _tecnologiaPrincipalAsociada; }
            set { _tecnologiaPrincipalAsociada = value; }
        }

        public ProyectoWeb(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, EstadoProyecto estado, TPA tecnologiaPrincipalAsociada) :
            base(nombre, cantidadDesarrolladores, fechaInicio, estado)
        {
            TecnologiaPrincipalAsociada = tecnologiaPrincipalAsociada;
        }

        public override void VisualizarProyecto()
        {
            Console.WriteLine($"Nombre: {Nombre}\n" +
                $"Cantidad de Desarrolladores: {CantidadDesarroladores}\n" +
                $"Fecha inicio: {FechaInicio}\n" +
                $"Fecha Estimada de duracion: {DuracionEstimada}\n" +
                $"Estado del Proyecto {Estado}\n" +
                $"Teconologia Principal Asociada {TecnologiaPrincipalAsociada}\n");
        }

        public override DateTime CalcularFechaEstimada()
        {
            return DateTime.Now.AddDays(DuracionPromedio - CantidadDesarroladores * 1.25);
            // Recomiendo que hagamos un calculo tipo Constante de lo que suele tardar un proyecto
            // Menos cantidad de trabajadores * 1.25 o algo así
            // Y ese valor se lo sumamos al día de la fecha y obtenemos el estimado. Es solo una sugerencia
        }
    }

    public class ProyectoMovil : Proyecto
    {
        private Po _plataformasObjetiva;
        public const int DuracionPromedio = 90;

        public Po PlataformasObjetiva { get { return _plataformasObjetiva; } set { _plataformasObjetiva = value; } }

        public ProyectoMovil(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, EstadoProyecto estado, Po plataformasObjetiva)
            : base(nombre, cantidadDesarrolladores, fechaInicio,  estado)
        {
            PlataformasObjetiva = plataformasObjetiva;
        }

        public override void VisualizarProyecto()
        {
            Console.WriteLine($"Nombre: {Nombre}\n" +
                $"Cantidad de Desarrolladores: {CantidadDesarroladores}\n" +
                $"Fecha inicio: {FechaInicio}\n" +
                $"Fecha Estimada de duracion: {DuracionEstimada}\n" +
                $"Estado del Proyecto {Estado}\n" +
                $"Plataformas objetivas {PlataformasObjetiva}\n");
        }

        public override DateTime CalcularFechaEstimada()
        {
            return DateTime.Now.AddDays(DuracionPromedio - CantidadDesarroladores * 1.25);
            // Recomiendo que hagamos un calculo tipo Constante de lo que suele tardar un proyecto
            // Menos cantidad de trabajadores * 1.25 o algo así
            // Y ese valor se lo sumamos al día de la fecha y obtenemos el estimado. Es solo una sugerencia
        }
    }
}