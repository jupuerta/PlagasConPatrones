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
    public class CucarachaVeneno : VenenoBuilder
    {
        public override void AddAnimal()
        {
            Veneno = new Veneno();
            Veneno.Animal = "Cucaracha"; 
        }

        public override void AddCantidad()
        {
            Veneno.Cantidad = 0.1;
        }

        public override void AddGasto()
        {
            Veneno.Gasto = 2;
        }

        public override void AddTipoVeneno()
        {
            Veneno.Tipoveneno = new Radioactivo(new Gaseoso(30));
        }

        public override double Gasto()
        {
            return Veneno.Gasto;
        }
    }
}
