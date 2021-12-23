using System;
namespace PPK___Zadanie_2_pkt_3
{
    internal class Pkt3
    {
        static void Main()
        {
        StartProgramu:
            Console.Clear();
            ulong wynik;
            string liczby;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" *** Kalkulator ***\n\n");
            Console.ResetColor();
            Console.Write(" Podaj liczby (oddzielone spacją): ");
            liczby = Console.ReadLine();
            string [] tablicaString = liczby.Split(' ') ;
            ulong[] tablicaLiczb = new ulong[3];
            for (int i = 0; i < tablicaString.Length; i++)
            {
                try
                {
                    tablicaLiczb[i] = Convert.ToUInt64(tablicaString[i]);
                }
                catch
                {
                    goto StartProgramu;
                }
            }
            wynik = tablicaLiczb[0] + tablicaLiczb[1];
            Console.WriteLine($" Iloczyn tych liczb to {wynik}");
            Console.Read();
            goto StartProgramu;
        }
    }
}

