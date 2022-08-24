using EjercicioPlagas.Specification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Trabajadores {
    [Serializable()]
    public class JefeEquipo : ITrabajador {
        private List<Peon> equipoList { get; set; }
        public double Ingreso { get; set; }

        public double gastoEquipo { get; set; }

        public JefeEquipo(double Ingresod) {
            equipoList = new List<Peon>();
            Ingreso = Ingresod;
            gastoEquipo = Ingreso;
        }
        public double IngresoServicio() {
            return Ingreso;
        }

        public void addPeon(Peon p) {
            TrabajadorSpecification spec = new TrabajadorSpecification();
            if (spec.IsSatisfiedBy(p)) {
                gastoEquipo += p.IngresoServicio();
                equipoList.Add(p);
            }
            
        }
    }
}
