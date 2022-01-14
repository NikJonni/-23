using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Задание_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            SumAsync(n);

            Console.ReadKey();
        }

        static void Factorial(int n)
        {
            int s = 1;
            for (int i = 1; i < n + 1; i++)
            {
                s *= i;
                Thread.Sleep(10);
            }
            Console.WriteLine(s);
        }

        static async void SumAsync(int n)
        {
            await Task.Run(() => Factorial(n));
        }
    }
}
