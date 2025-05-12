using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Ex_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (var item in c)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.NumberFormat.NumberDecimalSeparator);
            }

            int a = -5;
            float b = 3.14f;

            Console.WriteLine($"{a}\n{b}");

            Console.ReadKey();
        }
    }
}
