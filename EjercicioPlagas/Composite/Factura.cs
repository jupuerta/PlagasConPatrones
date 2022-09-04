using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPlagas.Composite
{
    [Serializable()]
    public class Factura : IServicio
    {
        public Cliente ClienteAsociado { get; set; }
        public List<Servicio> ServiciosCompletos { get; set; }
        public double Gastos { get; set; }
        public double Facturado { get; set; }

        public Factura(Cliente ClienteAsociadod)
        {
            this.ClienteAsociado = ClienteAsociadod;
            ServiciosCompletos = new List<Servicio>();
            Gastos = 0.0;
            Facturado = 0.0;
        }

        public void addServicio(Servicio s)
        {
            Gastos += s.Precio;
            Facturado += s.SaberFacturado();
            ServiciosCompletos.Add(s);
        }

        public double SaberFacturado()
        {
            return Facturado;
        }
    }
}
