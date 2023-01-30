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
    public class MenuAplicacionDesempleado
    {
        private IRepositorio<Desempleado> _repositorio;
        public MenuAplicacionDesempleado(IRepositorio<Desempleado> repositorio)
        {
            _repositorio = repositorio;
        }

        public void Iniciar()
        {

        }
    }
}
