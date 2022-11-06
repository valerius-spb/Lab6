using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку :");
            string text = Console.ReadLine();
            int len = text.Length;
            bool flag = true;

            //проверка палиндрома
            for (int i = 0; i < len / 2; i++)
            {
                if (text[i] != text[len - (i + 1)])
                {
                    flag = false;
                    break;
                }
            }

            //если true
            if (flag)
            {
                Console.WriteLine("{0} палиндром", text);
            }
            else
            {
                Console.WriteLine("{0} не палиндром", text);
            }
            Console.ReadLine();
        }
    }
}
