using System;


    class Program
    {
        static void Main(string[] args)
        {
        int xP=5, yP=5, szerokosc=5, wysokosc=5;
        

        Kwadrat k1 = new Kwadrat(xP,yP,szerokosc,wysokosc);

        k1.wyswietlenie();
        Kwadrat k2 = new Kwadrat(xP, yP, szerokosc);
        k2.wyswietlenie();
        }
    }

