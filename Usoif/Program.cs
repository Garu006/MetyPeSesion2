using Usoif.models;

namespace Usoif
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Decir si es niño, joven o adulto
            /*
             *Niño: 0-12
             *Joven: 13-25
             *Adulto: 26 a mas
            */
            int edad = 0;
            Evaluation evaluation = new Evaluation();
            Console.WriteLine("Evaluar edad");
            Console.WriteLine("Ingrerse tu edad: ");
            try
            {
                edad = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(evaluation.EvalAge(edad));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString);
                
            }
        }
    }
}
