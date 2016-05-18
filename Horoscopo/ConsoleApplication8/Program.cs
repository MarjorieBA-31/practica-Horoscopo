using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
  


class Program
    {
        static string name = "";
        static int month = 0;
        static int Main() //void
        {
            Console.WriteLine("Hola Estudiante");
            Console.Write("Digite su nombre:");
            name = Console.ReadLine();
            Console.WriteLine("Buenas tardes, " + name);
            Console.Write("Digite su mes de nacimiento:");
            month = int.Parse(Console.ReadLine());
            month = Convert.ToInt16((Console.ReadLine()));
            if (month == 1)
            {
                Console.WriteLine("Eres Aries");
            }
            if (month == 2)
            {
                Console.WriteLine("Eres Tauro");
            }
            if (month == 3)
            {
                Console.WriteLine("Eres Gemines");
            }
            if (month == 4)
            {
                Console.WriteLine("Eres Cancer");
            }
            if (month == 5)
            {
                Console.WriteLine("Eres Leo");
            }
            if (month == 6)
            {
                Console.WriteLine("Eres Virgo");
            }
            if (month == 7)
            {
                Console.WriteLine("Eres Libra");
            }
            if (month == 8)
            {
                Console.WriteLine("Eres Leo");
            }
            else
            {
                Console.WriteLine("No tengo información");
            }

            if (month == 9)
            {
                Console.WriteLine("Eres Sagitario");
            }
            if (month == 10)
            {
                Console.WriteLine("Eres Capricornio");
            }
            if (month == 11)
            {
                Console.WriteLine("Eres Acuario");
            }
            if (month == 12)
            {
                Console.WriteLine("Eres Piscis");
            }


           if{ }

            Console.ReadKey();
            return 0;
                 }
    }
}
