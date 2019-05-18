using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            char sig= 'S';
            int num1, num2, ope, resul;
            
            while (sig == 'S')
            {
                Console.Write("Eliga la Operacion \n 1-> Suma \n 2-> Resta \n 3-> Producto \n 4-> Cociente \n");
                ope = int.Parse(Console.ReadLine());
                Console.Write("\nIngrese el Primer Numero\n");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("\nIngrese el Segundo Numero\n");
                num2 = int.Parse(Console.ReadLine());
                switch (ope)
                {
                    case 1:
                        resul = num1 + num2;
                        break;
                    case 2:
                        resul = num1 - num2;
                        break;
                    case 3:
                        resul = num1 * num2;
                        break;
                    case 4:
                        resul = num1 / num2;
                        break;
                    default:
                        resul = -9999999;
                        break;
                }
                Console.Write("\nResultado= "); Console.Write(resul);
                Console.Write("\nDesea realizar otra operacion S/N");
                sig = char.Parse(Console.ReadLine());
            }
        }
    }
}

