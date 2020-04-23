using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int Zahleins = 0;
            int Zahlzwei = 0;
            int Operation = 0;
            int Ergebnis = 0;


            Console.WriteLine("Gib die erste Zahl ein:");
            Zahleins = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Gib die zweite Zahl ein");
            Zahlzwei = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Wähle: 1 = Addieren, 2 = Subtrahieren, 3 = Multiplizieren, 4 = Dividieren");
            Operation = Convert.ToInt16(Console.ReadLine());

            Ergebnis = Addieren(Zahleins, Zahlzwei);

            Console.WriteLine("Ergebnis = " + Ergebnis);
            Console.ReadKey();
        }

        static int Addieren(int zahl1, int zahl2)
        {
            int Erg = zahl1 + zahl2;
            return Erg;
        }

    }
}
