using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int max, a;
            Console.WriteLine("Введите числа: ");
            str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ' });
            max = Convert.ToInt32(words[0]); 
            foreach (string s in words)
            {
                a = Convert.ToInt32(s);
                if (max < a) max = a;
            }
            Console.WriteLine("Максимальное число a=" + max);
            Console.ReadLine();
        }
    }
}
