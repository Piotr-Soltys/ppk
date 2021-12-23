using System;
namespace PPK___Zadanie_2_pkt_2
{
    internal class Pkt2
    {
        static void Main()
        {
        StartProgramu:
            Console.Clear();
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

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" *** Program pozwalający obliczyć silnię z liczby podanej przez użytkownika ***\n\n");
            Console.ResetColor();
            Console.Write(" Podaj liczbę: ");
            try
            {
                liczba = Convert.ToUInt64(Console.ReadLine());
            }
            catch
            {
                goto StartProgramu;
            }
            UInt64 wynik = ObliczSilnie(liczba);
            if (wynik == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\n Nie można obliczyć silni z liczby {liczba}. Jest poza maksymalną wartością zmiennej.\n");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n Silnia liczby {liczba} wynosi {ObliczSilnie(liczba)}\n");
                Console.ResetColor();
            }

            Console.Read();
            goto StartProgramu;
        }
    }
}

