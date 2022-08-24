using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas {
    public interface IPersona {
        public String Name { get; set; }
        public String DNI { get; set; }
        public String CorreoElectronico { get; set; }
        public int CP { get; set; }
    }
}
