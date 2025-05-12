using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //list.Add(1);
            //list.Add(2);

            List<Auto> list = new List<Auto>();
            list.Add(new Auto("BMW"));
            list.Add(new Auto("Mercedes"));

            foreach (Auto item in list)
            {
                Console.WriteLine(item.UruchomSilnik);
            }
        }
    }
    class Auto
    {
        public string Nazwa { get; set; }
        public Auto(string marka)
        {
            Nazwa = marka;
        }
        public void UruchomSilnik()
        {

        }
    }
}
