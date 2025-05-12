using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(2);
            list.Add("Bartek");
            list.Add(new Auto("BMW"));
            Console.WriteLine(list[2]);
            list.RemoveAt(1); //index 1 zostanie usuniety
            list.Insert(0, "Ala"); //wstawi sie na index 0
            list.Clear(); //czysci liste

            foreach (var i in list) 
            {
                Console.WriteLine(i);
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
        public override string ToString()
        {
            return Nazwa;
        }

    }
}
