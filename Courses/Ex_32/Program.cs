using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Dzielenie(0));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Dzielisz przez zero " + e);
            }
            catch (Exception e)
            {
                Console.WriteLine("O nie cos poszlo nie tak! " + e.Message);
            }
            finally
            {
                Console.WriteLine("Ja i tak posprzataem");
            }


            Console.ReadKey();
        }

        public static float Dzielenie(int a)
        {
            if (a == 5)
            {
                throw new Exception("Nigdy nie dziel przez 5");
            }
            else
            {
                return 10 / a;
            }
        }
    }
}
