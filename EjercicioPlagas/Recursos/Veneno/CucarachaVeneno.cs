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
    public class CucarachaVeneno : IVenenoBuilder
    {
        public Veneno Veneno { get; set; }

        public void AddAnimal()
        {
            Veneno.Animal = "Cucaracha"; 
        }

        public void AddCantidad()
        {
            Veneno.Cantidad = 0.1;
        }

        public void AddGasto()
        {
            Veneno.Gasto = 2;
        }

        public void AddTipoVeneno()
        {
            Veneno.Tipoveneno = new Radioactivo(new Gaseoso(30));
        }

        public double Gasto()
        {
            return Veneno.Gasto;
        }
    }
}
