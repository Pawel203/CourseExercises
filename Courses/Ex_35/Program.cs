using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Paweł\Desktop";
            StreamWriter sw;
            if(!File.Exists(path))
            {
                sw = File.CreateText(path);
                Console.WriteLine("Plik zostal utworzony");
            }
            else
            {
                sw = new StreamWriter(path, true);
                Console.WriteLine("Plik zostal otwarty");
            }
            Console.WriteLine("Podaj teskt: ");
            string tekst = Console.ReadLine();

            sw.WriteLine(tekst);
            sw.Close();

            StreamReader sr = File.OpenText(path);
            string s = "";
            int i = 1;
            Console.WriteLine("\nZAWARTOSC PLIKU:");
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(i++ + ". " + s);
            }
            sr.Close();
        }
    }
}
