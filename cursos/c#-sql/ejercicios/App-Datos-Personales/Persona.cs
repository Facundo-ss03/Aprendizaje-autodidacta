using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Datos_Personales
{
    class Persona
    {
        public Persona(string apellido, string nombre, string edad, string direccion)
        {
            Apellido = apellido;
            Nombre = nombre;
            Edad = edad;
            Direccion = direccion;
        }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Direccion { get; set; }


    }
}
