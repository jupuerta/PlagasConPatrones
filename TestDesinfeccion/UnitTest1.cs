using EjercicioPlagas.Trabajadores;
using EjercicioPlagas.Recursos.Veneno;
using EjercicioPlagas.Recursos;
using EjercicioPlagas;
using EjercicioPlagas.Composite;
using EjercicioPlagas.Recursos.Veneno.Builder;
using EjercicioPlagas.Recursos.Veneno.Bridge.TipoVeneno;
using EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno;

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
        /// Compruebo que el Bridge del Tipo de veneno y el estado del veneno funciona correctamente
        /// </summary>
        [TestMethod]
        public void TestBridge()
        {
            ATipoVeneno tipo = new Neurotoxico(new Liquido(50));
            Assert.IsNotNull(tipo);
            Assert.AreEqual(50, tipo.PotenciaVeneno());
        }

        /// <summary>
        /// Compruebo que el builder funciona correctamente
        /// </summary>
        [TestMethod]
        public void TestBuilder()
        {
            VenenoDirector venenoCucaracha = new VenenoDirector(new CucarachaVeneno());
            venenoCucaracha.HacerVeneno();
            CucarachaVeneno CucarachaVeneno= (CucarachaVeneno)venenoCucaracha.GetVeneno();
            Assert.IsNotNull(CucarachaVeneno);

            Veneno Veneno = CucarachaVeneno.GetVeneno();
            Assert.AreEqual("Cucaracha", Veneno.Animal);
            Assert.AreEqual(0.1, Veneno.Cantidad);
            Assert.AreEqual(2, Veneno.Gasto);

            ATipoVeneno tipo = Veneno.Tipoveneno;
            Assert.IsNotNull(tipo);
            Assert.AreEqual(60, tipo.PotenciaVeneno());
        }

        /// <summary>
        /// Compruebo que el gasto de la empresa es correcto añadiendo recursos CON venenos
        /// </summary>
        [TestMethod]
        public void TestServicio() {
            JefeEquipo jefe = new JefeEquipo(45);
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

            Assert.AreEqual(171.5, Math.Round(servicio.Precio,2));
            Assert.AreEqual(25.72, Math.Round(servicio.SaberFacturado(),2));
        }

        /// <summary>
        /// Compruebo que la creación de una factura es correcta
        /// </summary>
        [TestMethod]
        public void TestFactura()
        {
            JefeEquipo jefe = new JefeEquipo(45);
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

            Cliente cliente =new Cliente("Juan", "123456789A", "aa@gmail.com", 24000);

            Factura factura = new Factura(cliente);
            factura.addServicio(servicio);

            Assert.AreEqual(171.5, Math.Round(factura.Gastos, 2));
            Assert.AreEqual(25.72, Math.Round(factura.Facturado, 2));
        }
    }
}