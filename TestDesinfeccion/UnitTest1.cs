using EjercicioPlagas.Trabajadores;
using EjercicioPlagas.Recursos.Veneno;
using EjercicioPlagas.Recursos;
using EjercicioPlagas;
using EjercicioPlagas.Composite;
using EjercicioPlagas.Recursos.Veneno.Builder;

namespace TestDesinfeccion
{
    [TestClass]
    public class UnitTest1 {

        /// <summary>
        /// Compruebo que el gasto del equipo es correcto
        /// </summary>
        [TestMethod]
        public void TestGastoEquipo() {
            JefeEquipo jefe = new JefeEquipo(45);
            jefe.addPeon(new Peon(20));
            jefe.addPeon(new Peon(15));
            jefe.addPeon(new Peon(20));

            Assert.AreEqual(100, jefe.gastoEquipo);
        }

        /// <summary>
        /// Compruebo que el gasto de la empresa es correcto añadiendo el servicio del gerente
        /// </summary>
        [TestMethod]
        public void TestServicioSinRecursos() {
            JefeEquipo jefe = new JefeEquipo(45);
            jefe.addPeon(new Peon(20));
            jefe.addPeon(new Peon(15));
            jefe.addPeon(new Peon(20));

            Gerente gerente = new Gerente(15);

            Servicio servicio = new Servicio("PruebaServicio", jefe, gerente);

            Assert.AreEqual(115, servicio.Precio);
        }

        /// <summary>
        /// Compruebo que el gasto de la empresa es correcto añadiendo recursos SIN venenos
        /// </summary>
        [TestMethod]
        public void TestServicioConRecursos() {
            JefeEquipo jefe = new JefeEquipo(45);
            jefe.addPeon(new Peon(20));
            jefe.addPeon(new Peon(15));
            jefe.addPeon(new Peon(20));


            Gerente gerente = new Gerente(15);

            Servicio servicio = new Servicio("PruebaServicio", jefe, gerente);
            servicio.AddRecurso(new Mascarilla());
            servicio.AddRecurso(new Furgo());

            Assert.AreEqual(166, servicio.Precio);
        }

        /// <summary>
        /// Compruebo que el gasto de la empresa es correcto añadiendo recursos CON venenos
        /// </summary>
        [TestMethod]
        public void TestFactura() {
            JefeEquipo jefe = new JefeEquipo(45);
            jefe.addPeon(new Peon(20));
            jefe.addPeon(new Peon(15));
            jefe.addPeon(new Peon(20));
            jefe.addPeon(new Peon(15));
            jefe.addPeon(new Peon(20));

            Gerente gerente = new Gerente(15);

            Servicio servicio = new Servicio("PruebaServicio", jefe, gerente);
            servicio.AddRecurso(new Mascarilla());
            servicio.AddRecurso(new Furgo());

            VenenoDirector venenoCucaracha = new VenenoDirector(new CucarachaVeneno());
            venenoCucaracha.HacerVeneno();
            servicio.AddRecurso(venenoCucaracha.GetVeneno());
            servicio.AddRecurso(venenoCucaracha.GetVeneno());

            VenenoDirector venenoRaton = new VenenoDirector(new RatonVeneno());
            venenoRaton.HacerVeneno();
            servicio.AddRecurso(venenoRaton.GetVeneno());

            Assert.AreEqual(171.5, servicio.Precio);
            Assert.AreEqual(25.72, servicio.SaberFacturado());
        }
    }
}