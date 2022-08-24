using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas
{
    [Serializable()]
    public class Cliente : IPersona
    {
        public string Name { get; set; }
        public string DNI { get; set; }
        public string CorreoElectronico { get; set; }
        public int CP { get; set; }

        public Cliente(string Named, string DNId, string CorreoElectronicod, int CPd)
        {
            Name = Named;
            DNI = DNId;
            CorreoElectronico = CorreoElectronicod;
            CP = CPd;
        }
    }
}
