using EjercicioPlagas.Composite;
using EjercicioPlagas.Recursos;
using EjercicioPlagas.Recursos.Veneno;
using EjercicioPlagas.Recursos.Veneno.Bridge.EstadoVeneno;
using EjercicioPlagas.Recursos.Veneno.Bridge.TipoVeneno;
using EjercicioPlagas.Recursos.Veneno.Builder;
using EjercicioPlagas.Trabajadores;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using EjercicioPlagas;
using EjercicioPlagas.Trabajadores.FactoyMethod;

Console.WriteLine("Hello, World!");

ITrabajadorFactory jefeEquipoFactory = new JefeEquipoFactory();
JefeEquipo jefe = (JefeEquipo)jefeEquipoFactory.Create(45);

ITrabajadorFactory peonFactory = new PeonFactory();
jefe.addTrabajador(peonFactory.Create(20));
jefe.addTrabajador(peonFactory.Create(15));
jefe.addTrabajador(peonFactory.Create(20));

ITrabajadorFactory GerenteFactory = new GerenteFactory();
Gerente gerente = (Gerente)GerenteFactory.Create(15);

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

Cliente cliente = new Cliente("Juan", "123456789A", "aa@gmail.com", 24000);

Factura factura = new Factura(cliente);
factura.addServicio(servicio);

Console.WriteLine("---------------------");
Console.WriteLine("Serialización");

IFormatter formatter = new BinaryFormatter();
Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
//formatter.Serialize(stream, factura);
stream.Close();

Console.WriteLine("Hello, World!");
