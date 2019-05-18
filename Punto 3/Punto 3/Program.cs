using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char sig;
            double num, num2, resultado;
            do
            {
                Console.Write("Ingrese un Numero");
                num= double.Parse(Console.ReadLine());
                resultado = Math.Abs(num);
                Console.Write("\nValor Absoluto de el numeros: ");Console.Write(resultado);
                resultado = Math.Pow(num, 2);
                Console.Write("\nPotencia de 2: " + resultado);
                resultado = Math.Sqrt(num);
                Console.Write("\nLa raiz cuadrada del numero es: " + resultado);
                resultado = Math.Sin(num);
                Console.Write("\nEl seno del numeros es: " + resultado);
                resultado = Math.Cos(num);
                Console.Write("\nEl Coseno del numero es: " + resultado);
                resultado = Math.Truncate(num);
                Console.Write("\nLa parte entera del numero es: " + resultado);
                //-----------------------------------------//
                Console.Write("\n\n\nIngrese el primer numero  ");
                num = int.Parse(Console.ReadLine());
                Console.Write("\nIngrese el segundo numero  ");
                num2 = int.Parse(Console.ReadLine());

                Console.Write("\nEl numero Maximo es: " + Math.Max(num, num2));
                Console.Write("\nEl numero Minimo es: " + Math.Min(num, num2));

                Console.Write("\nDesea Ingresar Otro Numero? S/N");
                sig = char.Parse(Console.ReadLine());
            } while (sig == 'S');
        }
    }
}
