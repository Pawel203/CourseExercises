using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            int ile = 100;
            stopwatch.Start();
            BudujString(ile);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);

            Console.WriteLine();

            stopwatch.Reset();
            stopwatch.Start();
            BudujStringBuilder(ile);
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);

        }
        /// <summary>
        /// Metoda buduje string
        /// </summary>
        /// <param name="ile">Podaj dlugosc petli</param>
        /// <returns>Zwracamy gotowy tekst</returns>

        public static string BudujString(int ile)
        {
            string tekst = "";
            for (int i = 0; i < ile; i++)
            {
                tekst += i;
            }
            return tekst;
        }

        public static string BudujStringBuilder(int ile) 
        {
            string tekst = "";
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ile; i++)
            { 
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
        }
    }
}
