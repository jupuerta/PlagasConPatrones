using EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno;
using EjercicioPlagas.Recursos.Veneno.Bridge.TipoVeneno;
using EjercicioPlagas.Recursos.Veneno.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Recursos.Veneno {
    [Serializable()]
    public class RatonVeneno : VenenoBuilder
    {
        public override void AddAnimal()
        {
            Veneno = new Veneno();
            Veneno.Animal = "Ratón";
        }

        public override void AddCantidad()
        {
            Veneno.Cantidad = 0.05;
        }

        public override void AddGasto()
        {
            Veneno.Gasto = 1.5;
        }

        public override void AddTipoVeneno()
        {
            Veneno.Tipoveneno = new Neurotoxico(new Liquido(60));
        }
        public override double Gasto()
        {
            return Veneno.Gasto;
        }
    }
}
