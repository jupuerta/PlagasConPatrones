using EjercicioPlagas.Recursos.Veneno.Bridge.TipoVeneno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Recursos.Veneno
{
    public class Veneno
    {
        public String Animal { get; set; }
        public ATipoVeneno Tipoveneno { get; set; }
        public double Cantidad { get; set; }
        public double Gasto { get; set; }
    }
}
