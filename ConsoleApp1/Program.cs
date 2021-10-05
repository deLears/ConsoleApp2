using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Осуществить ввод последовательности целых чисел и сравнить, что больше,
             * количество положительных или количество отрицательных. Последовательность потенциально не ограничена,
             * окончанием последовательности служит число 0.
             */
            int S, P, B;
            S=0;
            P = 1;
            
            do
            {
                Console.WriteLine("Введите целое число");
                B = Convert.ToInt32(Console.ReadLine());
                if (B > 0)
                    S = S+B;
                else
                    if (B != 0)
                    P =P* B;
            }
            while (B != 0);
            if (S > P)
                Console.WriteLine("Сумма ({0}) больше произведения ({1})", S, P);
            else
                if (S < P)
                Console.WriteLine("Произведение ({1}) больше суммы ({0})", S, P);
            else
                Console.WriteLine("Произведение ({1}) и сумма ({0}) равны", S, P);
            Console.ReadKey();
        }
    }
}
