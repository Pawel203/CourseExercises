using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_17
{
    internal class Czlowiek
    {
        public string imie;

        private int wiek;

        //public int getWiek()
        //{
        //    return wiek;
        //}

        //public void setWiek(int w)
        //{
        //    if (w >= 0 && w <= 150)
        //        wiek = w;
        //}

        //public int wiek { get; set; }

        public int Wiek
        {
            get { return wiek; }
            set
            {
                if (value >= 0 && value <= 200)
                {
                    wiek = value;
                }
                else 
                {
                    wiek = 0;
                }
            }
        }

    }
}
