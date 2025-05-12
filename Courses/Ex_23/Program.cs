using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "Ania");
            dictionary.Add(2, "Bartek");


            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            Console.ReadKey();
        }
    }
}
