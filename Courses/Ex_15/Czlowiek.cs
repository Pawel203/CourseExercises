using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_15
{
    class Czlowiek
    {

        public Czlowiek()
        {
        }

        public Czlowiek(string imieKonstruktora)
        {
            imie = imieKonstruktora;
        }

        public Czlowiek(string imieKonstruktora, string nazwiskoKonstruktora)
        {
            imie = imieKonstruktora;
            nazwisko = nazwiskoKonstruktora;
        }
        public string nazwisko = "Owczarzak";
        public string imie = "Paweł";

        public void PrzedstawSie()
        {
            Console.WriteLine("Mam na imię " + imie + " " + nazwisko);
        }

        ~Czlowiek()
        {
            Console.WriteLine("Jestem destruktorem");
        }
    }
}
