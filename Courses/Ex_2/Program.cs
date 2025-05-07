using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string zmienna; //deklaracja zmiennej
            zmienna = "Hello"; //przypisanie do wczesniej zdeklarowanej zmiennej

            int a = 2;
            int b = 3;
            int c = 4;

            int dodawanie = a + b;
            int odejmowanie = a - b;
            int mnozenie = a * b;
            float dzielenie = a / b;
            int modulo = a % b;

            Math.Pow(2, 3);
            Math.Abs(-7);

            c++;
            c--;

            bool d = !(2 == 2); //negacja

            //&& - AND (sprawdza sie przed OR-em)
            //|| - OR

            Console.WriteLine(c);
            Console.ReadKey();

        }
    }
}
