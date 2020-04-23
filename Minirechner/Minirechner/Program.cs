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

            /*if(Operation == 1) //Addieren
            {
                Ergebnis = Zahleins + Zahlzwei;
            }
            Console.WriteLine("Ergebnis = " + Ergebnis);

            if (Operation == 2) //Subtrahieren
            {
                Ergebnis = Zahleins - Zahlzwei;
            }
            Console.WriteLine("Ergebnis = " + Ergebnis);

            if (Operation == 3) //Multiplizieren
            {
                Ergebnis = Zahleins * Zahlzwei;
            }
            Console.WriteLine("Ergebnis = " + Ergebnis);

            if (Operation == 3) //Dividieren
            {
                Ergebnis = Zahleins / Zahlzwei;
            }*/
            if(Operation == 1)
            Ergebnis = Addieren(Zahleins, Zahlzwei);

            if (Operation == 2)
                Ergebnis = Subtrahieren(Zahleins, Zahlzwei);

            if(Operation == 3)
                Ergebnis = Multiplizieren(Zahleins, Zahlzwei);

            if (Operation == 4)
                Ergebnis = Dividieren(Zahleins, Zahlzwei);

            Console.WriteLine("Ergebnis = " + Ergebnis);
            Console.ReadKey();
        }

        static int Addieren(int zahl1, int zahl2)
        {
            int Erg = zahl1 + zahl2;
            return Erg;
        }
        static int Subtrahieren(int zahl1, int zahl2)
        {
            int Erg = zahl1 - zahl2;
            return Erg;
        }
        static int Multiplizieren(int zahl1, int zahl2)
        {
            int Erg = zahl1 * zahl2;
            return Erg;
        }
        static int Dividieren(int zahl1, int zahl2)
        {
            int Erg = zahl1 / zahl2;
            return Erg;
        }


    }
}
