using System;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear objeto Persona, a partir de la clase Persona
            // Un objeto es una instancia de su clase
            //tipo  //nombre var / new tipo
            Persona persona = new Persona("Alberto", "Dombledore");

            persona.Presentarse();
            Console.WriteLine(persona.nombre);
            Console.WriteLine(persona.apellido);

            // null --> sin valor
            Persona persona2 = new Persona("Mario", null);
            persona2.Presentarse();
            Console.WriteLine(persona2.nombre);
            Console.WriteLine(persona2.apellido);

        }
    }
}
