using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Recursos {
    [Serializable()]
    public class Coche : IRecursos{
        public double Gasto() {
            return 40;
        }
    }
}
