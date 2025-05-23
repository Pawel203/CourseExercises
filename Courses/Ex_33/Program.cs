using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Dzielenie(5));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Dzielisz przez zero " + e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }

        public static float Dzielenie(int a)
        {
            if (a == 5)
            {
                throw new DivadeByFiveException("Nie dziel przez 5!");
            }
            else
            {
                return 10 / a;
            }
        }
    }

    class DivadeByFiveException : Exception
    {
        public DivadeByFiveException()
        {
            Console.WriteLine("Bład");
        }

        public DivadeByFiveException(string message) : base(message + "Dzielenie przez 5!")
        {
        }
    }
}
