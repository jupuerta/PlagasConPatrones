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
    public class RatonVeneno : IVenenoBuilder
    {
        public Veneno Veneno { get; set; }

        public void AddAnimal()
        {
            Veneno.Animal = "Ratón";
        }

        public void AddCantidad()
        {
            Veneno.Cantidad = 0.05;
        }

        public void AddGasto()
        {
            Veneno.Gasto = 1.5;
        }

        public void AddTipoVeneno()
        {
            Veneno.Tipoveneno = new Neurotoxico(new Liquido(60));
        }

        public double Gasto()
        {
            return Veneno.Gasto;
        }
    }
}
