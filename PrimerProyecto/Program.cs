using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona(22, "José");

            Console.WriteLine(persona1.g_Nombre + " tiene " + persona1.g_Edad + " años");
            
            persona1.cumplirAño();

            Console.WriteLine("Ahora " + persona1.g_Nombre + " tiene " + persona1.g_Edad + " años");

            Console.ReadLine();
        }
    }
}
