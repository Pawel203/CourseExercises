using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_2 //przestrzennazw
{
    internal class Program //klasa
    {
        static void Main(string[] args) //metoda
        {
            var zmienna = "Hello";

            //całkowite
            sbyte zmienna1 = sbyte.MaxValue;
            byte zmienna2 = byte.MaxValue;
            ushort zmienna3 = ushort.MaxValue;
            short zmienna4 = short.MaxValue;
            int zmienna5 = int.MaxValue;
            uint zmienna6 = uint.MaxValue;
            long zmienna7 = long.MaxValue;
            ulong zmienna8 = ulong.MaxValue;

            //przecinkowe
            float zmienna9 = 1.431F;
            double zmienna10 = 1.823;
            decimal zmienna11 = 2.738M;

            //text
            string zmienna12 = "Hello";
            char zmienna13 = '$';

            //logiczny
            bool zmienna14 = false;
            bool zmienna15 = true;

            //stala
            const float PI = 3.14F;

            Console.ReadKey();
        }
    }
}
