using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codeforces_Round_514__Div._2_
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            int[] nums = new int[3];  //количество постоянных клиентов, длина рабочего дня и длительность одного перекура
            int j = 0;
            int i = 0;
            int a, L, n;
            int k = 0; //количество перекуров
            int time = 0;
            Console.WriteLine("Введите количество постоянных клиентов, длину рабочего дня и длительность одного перекура: ");
            str = Console.ReadLine();
            string[] words = str.Split(new char[] { ' ' });
            foreach (string s in words)
            {
                nums[i] = Convert.ToInt32(s);
                i++;
            }
            n = nums[0]; L = nums[1]; a = nums[2];
            int[,] nums2 = new int[n, 2]; // время прихода клиента после начала рабочего дня и время его обслуживания
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Введите время прихода " + i + "-го клиента после начала рабочего дня, сколько времени на его обслуживания: ");
                str = Console.ReadLine();
                words = str.Split(new char[] { ' ' });
                foreach (string s in words)
                {
                    nums2[i, j] = Convert.ToInt32(s);
                    j++;
                }
                j = 0;
            }
                for (i = 0; i < n; i++) //клиенты
                {
                    if (nums2[i,0] >= time + a) //успеваешь до клиента?
                    {
                        k = k + Math.Abs((time- nums2[i, 0])) / a;
                        time = time + a * (Math.Abs((time - nums2[i, 0]))/a);
                        time = time + (Math.Abs((time - nums2[i, 0])) % a);
                    }
                    if (time < nums2[i, 0]) //клиент пришел?
                    {
                        time = nums2[i, 0];
                    }
                    time += nums2[i, 1]; //обслуживание
                }
                k = k + (L - time)/a;
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
