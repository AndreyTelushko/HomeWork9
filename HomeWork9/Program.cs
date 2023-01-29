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
            Console.WriteLine("Введите число до которого вывести натуральные числа: ");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            NumRowButReversed(n);
            Console.ReadKey();
        }

        public static int NumRowButReversed(int n)
        {
            if (n == 0) return 1;
            else Console.Write(n-- + " ");
            NumRowButReversed(n);
            return -1;
        }

    }
}
