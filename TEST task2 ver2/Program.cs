using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_task2_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку :");
            string text = Console.ReadLine();
            char[] obrtext = text.ToCharArray();
            Array.Reverse(obrtext);
            string finaltext = new string(obrtext);
            if (text == finaltext)
            {
                Console.Write("палиндром.");
            }
            if (text != finaltext)
            {
                Console.Write("не палиндром.");
            }
            Console.ReadKey();
        }
    }
}