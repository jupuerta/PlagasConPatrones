using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Trabajadores.FactoyMethod
{
    public class JefeEquipoFactory:ITrabajadorFactory
    {
        public ITrabajador Create(int salario)
        {
            return new JefeEquipo(salario);
        }
    }
}
