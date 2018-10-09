using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int[] nums = new int[2];  //количество задач и минимального количества баллов
            int energy = 0; //энергия
            int j = 0;
            int i = 0;
            Console.WriteLine("Введите количество задач и минимального количества баллов, которое нужно набрать: ");
            str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                nums[i] = Convert.ToInt32(s);
                i++;
            }
            int[,] nums2 = new int[nums[0],3]; // энергии на прочтение задачи, энергии чтобы набрать по задаче один балл и кратность
            for (i=0; i < nums[0]; i++)
            {
                Console.WriteLine("Введите сколько требуется энергии на прочтение задачи "+ i +"-й , сколько потребуется энергии чтобы набрать по задаче один балл и кратность: ");
                str = Console.ReadLine();
                words = str.Split(new char[] { ' ' });
                foreach (string s in words)
                {
                    nums2[i,j] = Convert.ToInt32(s);
                    j++;
                }
                energy = energy + nums2[i, 0];
                j = 0;
            }
            Console.ReadLine();
        }
    }
}
