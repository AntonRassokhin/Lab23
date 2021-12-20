using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("Какого целого числа не более 20 факториал изволите: ");
            int N = Convert.ToInt32(Console.ReadLine());
            if (N > 20)
            {
                Console.WriteLine("Любезнейше прошу более 20 не вводить!");                
            }
            else
            {
                FactorialAsync(N);

                for (int i = N; i >= 1; i--) //это просто чтобы посмотреть как они вместе выводят
                {
                    long fcuk = Factorial1(i);
                    Console.WriteLine($"Факториалъ от {i} равен: {fcuk}");
                    Thread.Sleep(50);
                }



            }
            Console.WriteLine("Метод Main завершенъ");
            Console.ReadKey();
        }

        static long Factorial1 (int n)
        {
            if (n == 1)
                return 1;
            else
                return n * Factorial1(n - 1);
        }

        static void Factorial2(int m)
        {

            long factorial = 1;
            for (int i = 1; i <= m; i++)
            {
                factorial *= i;
                Console.WriteLine(factorial); //просто так
                Thread.Sleep(100);
            }
            Console.WriteLine($"Глубочайше напоминаю, что факториалъ {m} равен: {factorial}");

        }

        static async void FactorialAsync(int N)
        {
            Console.WriteLine("Асинхронъ факториала начат.");
            await Task.Run(() => Factorial2(N));
            Console.WriteLine("Асинхронъ факториала закончен.");
        }
    }
}
