using System;

namespace _4.Cwiczenie5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //test co sie stanie gdy prrzypisze typowi byte wartosc spoza jego zakresu
            byte liczba = 255;
            sbyte liczba2 = 129;
            byte liczba3 = 256;
            Console.WriteLine(liczba);
            Console.WriteLine(liczba2);
            Console.WriteLine(liczba3);
        }
    }
}
