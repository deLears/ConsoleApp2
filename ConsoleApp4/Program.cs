using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ввести целое число N > 0.Найти квадрат данного числа, используя для его вычисления следующую формулу:
             * N2 = 1 + 3 + 5 + ... +(2 * N – 1). После добавления к сумме каждого слагаемого выводить текущее значение суммы(в результате будут
             * выведены квадраты всех целых чисел от 1 до N).
             * */
            int N, R, i;
            Console.WriteLine("Введите число N");
            N=Convert.ToInt32(Console.ReadLine());
            R = 0;
            for (i=1; i<=N; i=i+2)
            {
                R = R + N;
                Console.WriteLine(R);
            }

            Console.ReadKey();

        }
    }
}
