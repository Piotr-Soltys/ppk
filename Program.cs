using System;
namespace PPK___Zadanie_2_pkt_3c
{
    internal class Pkt3c
    {
        static void Main()
        {
            StartProgramu:
            Console.Clear();
            long wynik;
            string liczby;

            long Suma(long liczba1, long liczba2)
            {
                return liczba1 + liczba2;
            }
            long Roznica(long liczba1, long liczba2)
            {
                return liczba1 - liczba2;
            }
            long Iloczyn(long liczba1, long liczba2)
            {
                return liczba1 * liczba2;
            }
            decimal Iloraz(decimal liczba1, decimal liczba2)
            {
                return liczba1 / liczba2;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" *** Kalkulator ***\n\n");
            Console.ResetColor();
            Console.Write(" Podaj liczby (oddzielone spacja): ");
            liczby = Console.ReadLine();
            string[] tablicaString = liczby.Split(' ');
            long[] tablicaLiczb = new long[3];
            for (int i = 0; i < tablicaString.Length; i++)
            {
                try
                {
                    tablicaLiczb[i] = Convert.ToInt64(tablicaString[i]);
                }
                catch
                {
                    goto StartProgramu;
                }
            }
            Console.Write(" Podaj operację do wykonania (+, -, *, /): ");
            string znak = Console.ReadLine();
            switch (znak)
            {
                case "+":
                    wynik = Suma(tablicaLiczb[0], tablicaLiczb[1]);
                    Console.WriteLine($" Suma tych liczb to {wynik}");
                    break;
                case "-":
                    wynik = Roznica(tablicaLiczb[0], tablicaLiczb[1]);
                    Console.WriteLine($" Różnica tych liczb to {wynik}");
                    break;
                case "*":
                    wynik = Iloczyn(tablicaLiczb[0], tablicaLiczb[1]);
                    Console.WriteLine($" Iloczyn tych liczb to {wynik}");
                    break;
                case "/":
                    if (tablicaLiczb[1] == 0)
                    {
                        Console.WriteLine($" Nie można dzielić przez 0");
                    }
                    else
                    {
                        decimal wynikDecimal = Iloraz(tablicaLiczb[0], tablicaLiczb[1]);
                        Console.WriteLine($" Iloraz tych liczb to {wynikDecimal}");
                    }
                    break;
                default: goto StartProgramu;
            }
            Console.Read();
            goto StartProgramu;
        }
    }
}

