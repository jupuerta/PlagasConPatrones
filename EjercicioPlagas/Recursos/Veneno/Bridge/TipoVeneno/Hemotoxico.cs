using EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPlagas.Recursos.Veneno.Bridge.TipoVeneno
{
    [Serializable()]
    public class Hemotoxico:ATipoVeneno
    {
        public Hemotoxico(IEstadoVeneno estadoVeneno)
        {
            this.EstadoVeneno = estadoVeneno;
            this.PotenciaBase = 70;
        }
    }
}
