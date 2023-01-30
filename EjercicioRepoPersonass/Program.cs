using EjercicioPOOClase16.Frontend;
using EjercicioPOOClase16.Modelo;
using EjercicioPOOClase16.Repositorio;
namespace EjercicioPOOClase16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var menuAplicacion = new MenuAplicacion( new RepositorioPersonaEnArchivos());
            menuAplicacion.Iniciar();
           
        }
    }
}