using EjercicioPOOClase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOClase16.Interfaces
{
    public interface IRepositorioPersona
    {
        void Insertar(Persona persona);
        void Eliminar(string numeroDocumento);
        void Actualizar(Persona persona);
        void Actualizar(string numeroDocumento, string nombre,string apellido);
        bool Existe(Persona persona);
        bool Existe(string numeroDocumento);
    }
}
