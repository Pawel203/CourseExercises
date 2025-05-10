using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //tablice wieolowymiarowe
            //int[,] tab = new int[2, 3];

            //tab[0, 0] = 1;
            //tab[0, 1] = 2;
            //tab[0, 2] = 3;
            //tab[1, 0] = 11;
            //tab[1, 1] = 12;
            //tab[1, 2] = 13;

            ////Console.WriteLine(tab.GetLength(0));  dlugosc wymiarow tablicy

            //for (int i = 0; i < tab.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tab.GetLength(1); j++)
            //    {
            //        Console.WriteLine(tab[i, j]);
            //    }
            //}


            //tablice tablic
            int[][] tab = new int[2][];
            tab[0] = new int[3];
            tab[1] = new int[2];

            tab[0][0] = 1;
            tab[0][1] = 2;
            tab[0][2] = 3;
            tab[1][0] = 11;
            tab[1][1] = 12;

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab[i].Length; j++)
                {
                    Console.WriteLine(tab[i][j]);
                }
            }

            //Array.Sort(tab);
            //Array.Reverse(tab)


            //Console.WriteLine(tab.Max());
            //Console.WriteLine(tab.Min());

            Console.ReadKey();
        }
    }
}
