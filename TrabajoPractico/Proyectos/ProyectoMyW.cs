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

        }

        public override DateTime CalcularFechaEstimada()
        {
            return DateTime.Now; // ESto no va, solo esta puesto para que no de error el Retun
            // Recomiendo que hagamos un calculo tipo Constante de lo que suele tardar un proyecto
            // Menos cantidad de trabajadores * 1.25 o algo así
            // Y ese valor se lo sumamos al día de la fecha y obtenemos el estimado. Es solo una sugerencia
        }
    }

    public class ProyectoMovil : Proyecto
    {
        private Po _plataformasObjetiva;

        public Po PlataformasObjetiva { get { return _plataformasObjetiva; } set { _plataformasObjetiva = value; } }

        public ProyectoMovil(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, EstadoProyecto estado, Po plataformasObjetiva)
            : base(nombre, cantidadDesarrolladores, fechaInicio,  estado)
        {
            PlataformasObjetiva = plataformasObjetiva;
        }

        public override void VisualizarProyecto()
        {

        }

        public override DateTime CalcularFechaEstimada()
        {
            return DateTime.Now; // ESto no va, solo esta puesto para que no de error el Retun
            // Recomiendo que hagamos un calculo tipo Constante de lo que suele tardar un proyecto
            // Menos cantidad de trabajadores * 1.25 o algo así
            // Y ese valor se lo sumamos al día de la fecha y obtenemos el estimado. Es solo una sugerencia
        }
    }
}