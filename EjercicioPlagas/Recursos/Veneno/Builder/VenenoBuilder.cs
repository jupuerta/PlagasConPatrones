using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Recursos.Veneno.Builder
{
    public abstract class VenenoBuilder:IRecursos
    {
        protected Veneno Veneno;
        public abstract void AddAnimal();
        public abstract void AddTipoVeneno();
        public abstract void AddCantidad();
        public abstract void AddGasto();
        public abstract double Gasto();
        public virtual Veneno GetVeneno() { return Veneno; }

        
    }
}
