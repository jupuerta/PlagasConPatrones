using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Recursos {
    [Serializable()]
    public class Furgo : IRecursos {
        public double Gasto() {
            return 50;
        }
    }
}
