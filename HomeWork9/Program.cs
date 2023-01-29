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
            Console.WriteLine("Введите диапазон: ");
            Console.Write("От: ");
            int inp1 = int.Parse(Console.ReadLine());
            Console.Write("До: ");
            int inp2 = int.Parse(Console.ReadLine());
            int cntr = 0;       // Инициализация счетчика
            Console.Clear();

            Console.WriteLine($"Сумма диапазона: {SumOfRange(inp1, inp2, ref cntr)}");
            Console.ReadKey();
        }

        public static int SumOfRange(int inp1, int inp2, ref int cntr)
        {
            // Исключение ошибки с первым числом больше второго
            int temp = 0;
            if (inp1 > inp2)
            {
                temp = inp1;
                inp1 = inp2;
                inp2 = temp;
            }
            cntr += inp1; // Счетчик

            if (inp1 == inp2) return cntr;
            else SumOfRange(inp1 + 1, inp2, ref cntr); // Точка входа в рекурсию
            return cntr;
        }
    }
}
