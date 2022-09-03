using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno
{
    public interface IEstadoVeneno
    {
        public int Concentracion { get; set; }
        public int Densidad();
    }
}
