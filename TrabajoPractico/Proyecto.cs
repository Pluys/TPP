﻿using System;
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

        public string Nombre { get { return _nombre; } set { _nombre = value; } }
        public int CantidadDesarroladores { get { return _cantidadDesarrolladores; } set { _cantidadDesarrolladores = value; } }

        public DateTime FechaInicio { get { return _fechaInicio; } set { _fechaInicio = value; } }
        public DateTime DuracionEstimada { get { return _duracionEstimada; } set { _duracionEstimada = value; } }
        public EstadoProyecto Estado {get { return _estado; } set { _estado = value; } }

        public Proyecto(string nombre, int cantidadDesarrolladores, DateTime fechaInicio, DateTime duracionEstimada, EstadoProyecto estado)
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
