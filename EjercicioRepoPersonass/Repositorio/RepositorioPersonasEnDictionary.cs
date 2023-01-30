using EjercicioPOOClase16.Interfaces;
using EjercicioPOOClase16.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPOOClase16.Repositorio
{
    //Usamos un diccionario para guardar las personas
    public class RepositorioPersonasEnDictionary : IRepositorioPersona
    {
        //public List<Persona> Personas { get; set; }
        public Dictionary<string,Persona> Personas { get; set; }

        public RepositorioPersonasEnDictionary()
        {
            Personas = new Dictionary<string, Persona>();
            //Personas = new List<Persona>();
        }
        public void Insertar(Persona persona)
        {
            var numeroDocumento = persona.NumeroDeDocumento;
            var personaExiste = Personas.ContainsKey(numeroDocumento);
            if (!personaExiste)
            {
            Personas[numeroDocumento] = persona;
            }
            //Personas.Add(persona); USANDO LIST
        }

        public void Eliminar(string NumeroDocumento)
        {
            //UTLIZANDO DICTIONARY
            Personas[NumeroDocumento] = null;

            //UTILIZANDO LISTAS
            //foreach (var persona in Personas)
            //{
            //    if(persona.NumeroDeDocumento == NumeroDocumento)
            //    {
            //        //personaAEliminar = persona;
            //        Personas.Remove(persona);
            //        break;
            //    }
            //}
            //if(personaAEliminar != null)
            //{
            //    Personas.Remove(personaAEliminar);
            //}
        }
        public void Actualizar(Persona persona)
        {
            //UTILIZANDO DICTIONARY
            var personaAActualizar = Personas[persona.NumeroDeDocumento];
            if(personaAActualizar != null)
            {
                personaAActualizar.Nombre = persona.Nombre;
                personaAActualizar.Apellido = persona.Apellido;
                personaAActualizar.FechaNacimiento = persona.FechaNacimiento;
            }
            //UTLIZANDO LIST
            //foreach (var personaActual in Personas)
            //{
            //    if(personaActual.NumeroDeDocumento == persona.NumeroDeDocumento)
            //    {
                    
            //        personaActual.Nombre = persona.Nombre;
            //        personaActual.Apellido = persona.Apellido;
            //        personaActual.FechaNacimiento = persona.FechaNacimiento;
            //    }
            //}
        }
        //public void Actualizar(int numeroDocumento, string nombre,string apellido)
        //{

        //    foreach (var personaActual in Personas)
        //    {
        //        if (personaActual.NumeroDeDocumento == persona.NumeroDeDocumento)
        //        {

        //            personaActual.Nombre = persona.Nombre;
        //            personaActual.Apellido = persona.Apellido;
        //            personaActual.FechaNacimiento = persona.FechaNacimiento;
        //        }
        //    }
        //}

        public bool Existe(Persona persona)
        {
            return Personas.ContainsKey(persona.NumeroDeDocumento);
        }
        public bool Existe(string NumeroDocumento)
        {
            return Personas.ContainsKey(NumeroDocumento);
        }

        public void Actualizar(string numeroDocumento, string nombre, string apellido)
        {
            throw new NotImplementedException();
        }
    }
}
