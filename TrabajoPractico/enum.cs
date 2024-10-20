using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    // Cuando declaramos los enums no le pusimos que tipo de acceso tenian por lo que generaba un bug. Solucionado
    public enum EstadoProyecto
    {
        Planificacion,
        endesarrollo,
        Enpruebas,
        Completado,
        Cancelado
    }

    public enum TPA
    {
        React,
        Angular,
        Vue // vue.js pero al poner .js sale un error
    }

    public enum Po
    {
        Ios,
        Android,
        WindowsPhone
    }
}
