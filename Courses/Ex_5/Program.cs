using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ctrl + k + d - ukladanie kodu
            //ctrl + k + c - komentowanie
            //ctrl + k + u - odkomentowanie

            //if (Console.ReadKey().Key == ConsoleKey.D1)
            //{
            //    Console.WriteLine("prawda");
            //}
            //Console.ReadLine();

            //string s = Console.ReadLine();

            //int i = int.Parse(s) + 2;
            //Console.WriteLine(i);
            //s = i.ToString();
            //Console.WriteLine(s+"lala");

            string s1 = "Witaj";
            string s2 = "Świecie";

            Console.WriteLine(s1 + " " + s2 + " {0} {1}", s1,s1);

            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ResetColor();
            //Console.Clear();

            Console.ReadKey();
        }
    }
}
