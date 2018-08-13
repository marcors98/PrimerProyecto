using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProyecto
{
    class Persona
    {
        public int g_Edad { get; set; }
        public string g_Nombre { get; set; }

        public Persona(int m_edad, string m_nombre)
        {
            g_Edad = m_edad;                // Con get y set, ahora la variable g_Edad (En mayúscula por que se
            g_Nombre = m_nombre;            // considera como un método) se acepta en los constructores sin "this".
        }

        public Persona()
        {
            g_Edad = 0;                     // "this" hace referencia a la edad de la clase; 
            g_Nombre = "";                  //  la edad sin "this" es la edad del constructor
        }

        public void cumplirAño()
        {
            g_Edad++;
        }
    }
}