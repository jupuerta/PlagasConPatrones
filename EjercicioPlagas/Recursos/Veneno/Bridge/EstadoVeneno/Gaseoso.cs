using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno
{
    [Serializable()]
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
