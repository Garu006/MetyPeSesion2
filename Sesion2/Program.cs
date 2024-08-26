using Sesion2.clases;

namespace Sesion2
{
    //leer los datos de una persona y decir si es mayor o menor de edad.
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            DateTime fechaNac;
            Persona persona = new Persona();

            Console.Write("Dime tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("En que fecha naciste: ");
            fechaNac = DateTime.Parse(Console.ReadLine());

            persona.Nombre = nombre;
            persona.FechaNac = fechaNac;

            Console.WriteLine(persona.EvaluarEdad());
        }
    }
}
