using EjercicioPlagas.Trabajadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Specification {
    public interface ISpecification {
        bool IsSatisfiedBy(ITrabajador trabajador);
    }
}
