using EjercicioPOOClase16.Frontend;
using EjercicioPOOClase16.Modelo;
using EjercicioPOOClase16.Repositorio;
namespace EjercicioPOOClase16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingrese 1 para trabajar sobre Personas
            //Ingrese 2 para trabajar sobre desempleados
            var menuAplicacion = new MenuAplicacionPersona( new RepositorioEnArchivos<Persona>());
            menuAplicacion.Iniciar();


            new MenuAplicacionDesempleado(new RepositorioEnArchivos<Desempleado>()).Iniciar();
        }
    }
}