using EjercicioPOOClase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjercicioPOOClase16.Repositorio;
using EjercicioPOOClase16.Interfaces;

namespace EjercicioPOOClase16.Frontend
{
    public class MenuAplicacion
    {
        private IRepositorioPersona _repositorioPersona;
        public MenuAplicacion(IRepositorioPersona repositorioPersona)
        {
            _repositorioPersona= repositorioPersona;
        }
        public void Iniciar()
        {
            int opcionElegida;
            do
            {
                Console.WriteLine("Bienvenido al gestor de personas");
                Console.WriteLine("Seleccione una opcion");
                Console.WriteLine("1- Agregar una persona");
                Console.WriteLine("2- Listar personas");
                Console.WriteLine("3- Eliminar una persona");
                Console.WriteLine("4- Salir");
                opcionElegida = int.Parse(Console.ReadLine());
                switch (opcionElegida)
                {
                    case 1:
                        MostrarAgregarPersona();
                            break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }
            } while (opcionElegida != 4);

        }
        private void MostrarAgregarPersona()
        {
            Console.WriteLine("Ingrese el tipo de persona a agregar");
            Console.WriteLine("1- Empleado");
            Console.WriteLine("2- Desempleado");
            Console.WriteLine("3- Jubilado");

            var opcionPersona = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese nombre");
            var nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido");
            var apellido = Console.ReadLine();
            Console.WriteLine("Ingrese fecha nacimiento (formato DD//MM/AAAA)");
            var fechaNacimiento  = Console.ReadLine();




            switch (opcionPersona)
            {
                case 1:
                    // Empleado
                    var empleado = new Empleado()
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaNacimiento
                    };
                    Console.WriteLine("Ingrese ocupacion");
                     empleado.Ocupacion = Console.ReadLine();
                    Console.WriteLine("Ingrese empresa en la que trabaja");
                    empleado.Empresa = Console.ReadLine();
                    Console.WriteLine("Ingrese Obra Social");
                    empleado.ObraSocial = Console.ReadLine();

                    _repositorioPersona.Insertar(empleado);
                    break;

                    case 2:
                    //Desempleado
                    var desempleado = new Desempleado()
                    {
                        Nombre = nombre,
                        Apellido = apellido,
                        FechaNacimiento = fechaNacimiento
                    };
                    Console.WriteLine("Ingrese ultima ocupacion");
                    desempleado.UltimaOcupacion = Console.ReadLine();
                    Console.WriteLine("Ingrese la ultima empresa en la que trabajo");
                    desempleado.UltimaEmpresa = Console.ReadLine();
                    Console.WriteLine("Es discapacitado? S/N");
                    var esDiscapacitado = Console.ReadLine();
                    if(esDiscapacitado.ToLower() == "s")
                    {
                        desempleado.EsDiscapacitado = true;
                    }
                    _repositorioPersona.Insertar(desempleado);
                    break;
                default:
                    break;
            }
            Console.WriteLine("Persona agregada correctamente");
        }
    }
}
