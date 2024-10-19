using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    internal abstract class Proyecto
    {
        private string _nombre;
        private int _cantidadDesarrolladores;
        private EstadoProyecto _estado;
          
        private DateTime _fechaInicio;
        private DateTime _duracionEstimada;



        public Proyecto(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, DateTime duracionEstimada, EstadoProyecto estado )
        {
            this._nombre = nombre;
            this._cantidadDesarrolladores = cantidadDesarrolladores;
            this._fechaInicio = fechaInicio;
            this._duracionEstimada = duracionEstimada;
            this._estado = estado;
        }



        public abstract void VisualizarProyecto();
        public abstract DateTime CalcularFechaEstimada();


       

 

    }



}
