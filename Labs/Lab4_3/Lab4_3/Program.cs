using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            double x, y;
            Console.WriteLine("Введите x: ");
            str = Console.ReadLine();
            x = Convert.ToDouble(str);
            Console.WriteLine("Выберите график а или b: ");
            str = Console.ReadLine();
            if (str == "a")
                if (x <= 0)
                    y = -x;
                else
                    y = x * x;
            else
                if (x <= 0)
                    y = 1;
                else
                    y = Math.Cos(x);
            Console.ReadLine();
        }
    }
}
