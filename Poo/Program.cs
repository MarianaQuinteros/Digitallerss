using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulamiento establece que los atributos de una clase deben ser privados, y los metodos de acceso públicos
            //Estudiante e1 = new Estudiante();
            /*e1.dni = "11456789";
            e1.nombre = "Maria Perez";
            e1.edad = 74;
            e1.materia = "PHP";
            e1.regular = true;*/

            //Console.WriteLine("El nombre de la estudiante es {0}", e1.nombre);

            Estudiante e2 = new Estudiante();
            e2.setDni("11456789");
            e2.saludar();
            Console.WriteLine("El DNI del estudiante es {0}", e2.getDni());
            Console.ReadLine();
        }
    }
}
