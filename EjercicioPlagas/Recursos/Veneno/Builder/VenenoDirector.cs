using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Recursos.Veneno.Builder
{
    public class VenenoDirector
    {
        private VenenoBuilder _builder;

        public VenenoDirector(VenenoBuilder _builder)
        {
            this._builder = _builder;
        }

        public void HacerVeneno()
        {
            _builder.AddAnimal();
            _builder.AddTipoVeneno();
            _builder.AddCantidad();
            _builder.AddGasto();
        }

        public VenenoBuilder GetVeneno()
        {
            return _builder;
        }
    }
}
