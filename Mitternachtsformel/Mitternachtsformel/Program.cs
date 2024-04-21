using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitternachtsformel
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Zahl 1: ");
           double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nZahl 2: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nZahl 3: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double d = (b * b) - 4 * (a * c);

            double e = Math.Sqrt(d);

            double ausgabe = (-b) / (2 * a);

            double x1 = (-b + e) / (2 * a);
            double x2 = (-b - e) / (2 * a);


            if (d < 0)
            {
                Console.WriteLine("\nEs gibt keine Lösung");
            }
            else if (e == 0)
            {
                Console.WriteLine($"\nNur eine Lösung: {ausgabe}");
            }
            else if (e != 0)
            {
                Console.WriteLine($"\nx1: {x1:0.000}");
                Console.WriteLine($"x2: {x2:0.000}");


            }

            Console.ReadKey();
        }
    }
}
