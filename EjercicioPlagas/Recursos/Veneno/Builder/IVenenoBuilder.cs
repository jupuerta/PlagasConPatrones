using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Recursos.Veneno.Builder
{
    public interface IVenenoBuilder:IRecursos
    {
        public void AddAnimal();
        public void AddTipoVeneno();
        public void AddCantidad();
        public void AddGasto();

    }
}
