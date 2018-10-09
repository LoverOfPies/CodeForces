using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int x, y, result;
            Console.WriteLine("Введите x: ");
            str = Console.ReadLine();
            x = Convert.ToInt32(str);
            Console.WriteLine("Введите y: ");
            str = Console.ReadLine();
            y = Convert.ToInt32(str);
            if (x < 0) result = max(x, y);
            else result = min(x, y);
            Console.WriteLine("Результат: "+ result);
            Console.ReadLine();
        }

        static int max(int a, int b)
        {
            int res = a > b ? a : b;
            return res;
        }

        static int min(int a, int b)
        {
            int res = a < b ? a : b;
            return res;
        }
    }
}
