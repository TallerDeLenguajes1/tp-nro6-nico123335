using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero\n");
            int num = int.Parse(Console.ReadLine());
            
            if (num <= 0)
            {
                Console.Write(num);
            }
            else 
            {
                while (num > 10) 
                {
                    Console.Write(num % 10);
                    num = num / 10;
                }
            }
            Console.Write(num);
            Console.ReadKey();
        }
    }
}
