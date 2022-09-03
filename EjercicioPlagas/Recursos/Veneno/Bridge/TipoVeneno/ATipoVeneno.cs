using EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno;
using System;
using System.Collections.Generic;
using System.Text;

namespace EjercicioPlagas.Recursos.Veneno.Bridge.TipoVeneno
{
    public class ATipoVeneno
    {
        protected IEstadoVeneno EstadoVeneno { set; get; }
        protected int PotenciaBase { get; set; }
        public virtual int PotenciaVeneno()
        {
            return (PotenciaBase + EstadoVeneno.ConcentracionActivo()) / 2;
        }
    }
}
