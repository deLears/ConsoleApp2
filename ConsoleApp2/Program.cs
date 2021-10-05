using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное
             * количество квадратов со стороной C (без наложений).
             * Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.
             */

            
            Console.Write("Введите A: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите C: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int k = 0;
            int n = 0;
            while (a >= c)
            {
                a -= c;
                k++; //количество квадратов по стороне А
            }
            while (b >= c)
            {
                b -= c;
                n++; //количество квадратов по стороне В
            }
            int count = 0;
            for (int i = 0; i < k; i++)
            {
                count += n;
                Console.WriteLine("N= " + count);
            }
            Console.ReadKey();

        }
    }
}
