using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Trabajadores.FactoyMethod
{
    internal class GerenteFactory : ITrabajadorFactory
    {
        public ITrabajador Create(int salario)
        {
            return new Gerente(salario);
        }
    }
}
