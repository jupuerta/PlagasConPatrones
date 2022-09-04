using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno
{
    [Serializable()]
    public class Liquido : IEstadoVeneno
    {
        public int Concentracion { get; set; }
        public Liquido(int concentracion)
        {
            Concentracion = concentracion;
        }

        public int Densidad()
        {
            return 2;
        }

    }
}
