using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Введите первое положительное число: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Введите второе положительное число: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Результат: {AkkFun(m, n)}");
            Console.ReadKey();
        }

        public static int AkkFun(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (m > 0 && n == 0)
            {
                return AkkFun(m - 1, 1);
            }
            return AkkFun(m - 1, AkkFun(m, n - 1));
        }
    }
}
