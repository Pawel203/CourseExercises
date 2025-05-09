using System;

namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Podaj szerokosc prostokata:");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("Podaj wysokosc prostokata:");
            //int y = int.Parse(Console.ReadLine());

            //for (int i = 0; i < y; i++)
            //{
            //    for (int j = 0; j < x; j++)
            //    {
            //        Console.Write(" * ");
            //    }
            //    Console.WriteLine();
            //}

            Random rnd = new Random();
            int liczba_zgadywana = rnd.Next(1, 11);
            int liczba_wpisana; //zmienna musi zostac zdeklarowana wczesniej by moc jej uzyc do warunku petli

            int licznik = 0;

            Console.WriteLine("Zgadnij liczbe z zakrsu 1-10");

            do 
            {
                Console.WriteLine("Podaj swoja liczbe");
                liczba_wpisana = int.Parse(Console.ReadLine());

                if(liczba_wpisana > 10 || liczba_wpisana < 1)
                {
                    Console.WriteLine("Wpisales liczbe z poza zakresu");
                }
                else
                {
                    licznik++; //liczby z poza zakresu nie sa liczone jako proba wpisania
                    if (liczba_wpisana > liczba_zgadywana)
                    {
                        Console.WriteLine("twoja liczba jest za duza");
                    }
                    else if (liczba_wpisana < liczba_zgadywana)
                    {
                        Console.WriteLine("twoja liczba jest za mala");
                    }
                    else
                    {
                        Console.WriteLine("Brawo zgadles liczbe: " + liczba_zgadywana + " za {0} razem", licznik);

                    }
                }
            }
            while(liczba_zgadywana != liczba_wpisana);





            Console.ReadKey();
        }
    }
}
