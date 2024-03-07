using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Datos_Personales
{
    class Persona
    {
        private string Apellido;
        private string Nombre;
        private int Edad;
        private string Direccion;

        public void setApellido(string apellido)
        {
            Apellido = apellido;
        }
        public string getApellido()
        {
            return Apellido;
        }
        public void setNombre(string nombre)
        {
            Apellido = nombre;
        }

        public string getNombre()
        {
            return Nombre;
        }
        public void setEdad(string edad)
        {
            Apellido = edad;
        }

        public int getEdad()
        {
            return Edad;
        }
        public void setDireccion(string direccion)
        {
            Apellido = direccion;
        }

        public string getDireccion()
        {
            return Direccion;
        }
    }
}
