using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dodaj(3, 6, d:2);

            Console.ReadKey();
        }

        static void Dodaj(int a, int b)
        {
            int wynik = a + b;
            Console.WriteLine("Wynik dodawania: " + wynik);
        }
        static void Dodaj(int a, int b, int c = 0) //podajac 3 argumenty c zostanie zamienione
        {
            int wynik = a + b + c;
            Console.WriteLine("Wynik dodawania: " + wynik);
        }
        static void Dodaj(int a, int b, int c = 2, int d = 0) //podajac 3 argumenty c zostanie zamienione
        {
            int wynik = a + b + c + d;
            Console.WriteLine("Wynik dodawania: " + wynik);
        }
    }
}

//void - nie zwraca wyniku, wynik jest tylko w srodku
