using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno
{
    [Serializable()]
    public class Solido : IEstadoVeneno
    {
        public int Concentracion { get; set; }
        public Solido(int concentracion)
        {
            Concentracion = concentracion;
        }
    
        public int Densidad()
        {
            return 3;
        }
    }
}
