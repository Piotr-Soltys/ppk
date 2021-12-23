using System;
namespace PPK___Zadanie_2_pkt_2
{
    internal class Pkt2
    {
        static void Main()
        {
            ulong liczba;

            ulong ObliczSilnie(ulong liczba)
            {
                ulong silnia = 1;

                for (ulong i = 1; i <= liczba; i++)
                {
                    silnia *= i;
                }
                return silnia;
            }
            liczba = 9;
            Console.WriteLine($"Silnia liczby {liczba} wynosi {ObliczSilnie(liczba)}\n");
            liczba = 20;
            Console.WriteLine($"Silnia liczby {liczba} wynosi {ObliczSilnie(liczba)}\n");
            liczba = 243; //wartość jest poza zakresem 64 bitowej dodatniej liczby całkowitej
            Console.WriteLine($"Silnia liczby {liczba} wynosi {ObliczSilnie(liczba)}\n");

            Console.Read();
        }
    }
}

