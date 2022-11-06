using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод переменной
            string str = Console.ReadLine();
            //Массив строк 
            string[] strArray = str.Split();
            //Присваиваем первый элемент из массива
            string max = strArray[0];
            //Переборка массива
            foreach (string s in strArray)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            //Вывод
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
