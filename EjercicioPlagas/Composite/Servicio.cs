using EjercicioPlagas.Recursos;
using EjercicioPlagas.Specification;
using EjercicioPlagas.Trabajadores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Composite
{
    public class Servicio : IServicio
    {
        public string Nombre { get; set; }
        public JefeEquipo JefeServicio;
        public Gerente GerenteServicio;
        public List<IRecursos> RecursosCompletos { get; set; }
        public double Precio { get; set; }

        public Servicio(string Nombref, JefeEquipo JefeServiciof, Gerente GerenteServiciof)
        {
            Nombre = Nombref;
            RecursosCompletos = new List<IRecursos>();
            Precio = 0;
            TrabajadorSpecification spec = new TrabajadorSpecification();
            if (spec.IsSatisfiedBy(JefeServiciof) || spec.IsSatisfiedBy(GerenteServiciof))
            {
                JefeServicio = JefeServiciof;
                GerenteServicio = GerenteServiciof;
                Precio += JefeServiciof.gastoEquipo;
                Precio += GerenteServiciof.IngresoServicio();
            }
            else
            {
                JefeServicio = null;
                GerenteServicio = null;
            }

        }

        public void AddRecurso(IRecursos recurso)
        {
            RecursosCompletos.Add(recurso);
            Precio += recurso.Gasto();
        }

        public double SaberFacturado()
        {
            return Precio * 0.15;
        }
    }
}
