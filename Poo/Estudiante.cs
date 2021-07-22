using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Estudiante
    {
        private string dni;
        private string nombre;
        private int edad;
        private string materia;
        private bool regular;


        public void saludar() {
            Console.WriteLine("Hola yo soy estudiante de Programación");    
        }

        public void setDni(string dni_param)
        {
            dni = dni_param;
        }

        public string getDni()
        {
            return dni;
        }
    }
}
