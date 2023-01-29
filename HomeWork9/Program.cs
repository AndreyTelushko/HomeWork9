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
                int inp = int.Parse(Console.ReadLine());
                Console.Clear();
                NumRowButReversed(inp);
                Console.ReadKey();
            }

            public static int NumRowButReversed(int inp)
            {
                if (inp == 0) return 1;
                else Console.Write(inp-- + " ");
                NumRowButReversed(inp);
                return -1;
            }
        
    }
}
