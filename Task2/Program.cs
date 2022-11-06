using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Не понятно как сюда массив запихать!!!

            Console.WriteLine("Введите строку: ");

            string str = Console.ReadLine(); // Вводим строку
            string reverseStr = ""; // перевернутая строка
            
            // ИЛИ foreach (char i in str)
            // revereStr=i+reversStr

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverseStr += str[i]; // переворачиваем строку
            }
            if (str == reverseStr)
                Console.WriteLine("Введенная строка - палиндром.");
            else
                Console.WriteLine("Введенная строка - не палиндромом.");
            Console.ReadKey();
        }
    }
}