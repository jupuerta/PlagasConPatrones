using EjercicioPlagas.Trabajadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Specification {
    public class TrabajadorSpecification : ISpecification {
        public bool IsSatisfiedBy(ITrabajador trabajador) {
            if (trabajador.IngresoServicio()<50 || trabajador.IngresoServicio() > 0) {
                return true;
            }
            return false;
        }
    }
}
