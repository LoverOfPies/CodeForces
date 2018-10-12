using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Educational_Codeforces_Round_52
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int t;
            int i = 0;
            int j = 0;
            Console.WriteLine("Введите количество тестов: ");
            str = Console.ReadLine();
            t = Convert.ToInt32(str); //количество тестов
            int[,] nums2 = new int[t, 4];
            for (i = 0; i < t; i++)
            {
                Console.WriteLine("Введите количество денег у Васи, количество шоколадок, которые необходимо купить, чтобы получить подарок, " +
                    "количество шоколадок, которое покупатель получает в подарок и цену одной шоколадки^ ");
                str = Console.ReadLine();
                string[] words = str.Split(new char[] { ' ' });
                foreach (string s in words)
                {
                    nums2[i, j] = Convert.ToInt32(s); 
                    j++;
                }
                j = 0;
            }
            int[] answer = new int[t];
            for (i = 0; i < t; i++)
            {
                answer[i] = nums2[i, 0] / nums2[i, 3];
                answer[i] = answer[i] + (answer[i] / nums2[i, 1])* nums2[i, 2];
                Console.WriteLine("Количество шоколадок для " + i +"-го теста: "+ answer[i]);
            }
            Console.ReadLine();
        }
    }
}
