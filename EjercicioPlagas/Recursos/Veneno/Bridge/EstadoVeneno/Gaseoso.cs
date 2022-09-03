using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno
{
    public class Gaseoso : IEstadoVeneno
    {
        public int Concentracion { get; set; }

        public Gaseoso(int concentracion)
        {
            Concentracion = concentracion;
        }
        public int Densidad()
        {
            return 1;
        }
    }
}
