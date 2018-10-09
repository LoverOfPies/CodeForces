using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_A
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int[] nums = new int[3];
            int i = 0;
            Console.WriteLine("Введите количество участников, стоимость одного банана и стоимость одной бутылочки с минералкой: ");
            str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ' });
        
            foreach (string s in words)
            {
                nums[i] = Convert.ToInt32(s);
                i++;
            }
            if (nums[0] <= 0)
                Console.WriteLine("Должен быть хотя бы один участник");
            else if (nums[2] >= 1000)
                Console.WriteLine("Бутылка воды должна быть дешевле 1000");
            else
            {
                int sum = nums[0] * (nums[1] + nums[2]);
                Console.WriteLine("Общая сумма составляет: "+sum);
            }
            Console.ReadLine();
        }
    }
}
