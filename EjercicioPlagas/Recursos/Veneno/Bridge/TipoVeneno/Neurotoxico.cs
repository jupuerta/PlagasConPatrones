using EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPlagas.Recursos.Veneno.Bridge.TipoVeneno
{
    public class Neurotoxico:ATipoVeneno
    {
        public Neurotoxico(IEstadoVeneno estadoVeneno)
        {
            this.EstadoVeneno = estadoVeneno;
            this.PotenciaBase = 90;
        }
    }
}
