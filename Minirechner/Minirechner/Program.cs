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
            double Zahleins = 0;
            double Zahlzwei = 0;
            int Operation = 0;
            double Ergebnis = 0;

            Console.WriteLine("Gib die erste Zahl ein:");
            Zahleins = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gib die zweite Zahl ein");
            Zahlzwei = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wähle: 1 = Addieren, 2 = Subtrahieren, 3 = Multiplizieren, 4 = Dividieren");
            Operation = Convert.ToInt16(Console.ReadLine());

            if(Operation == 1)
            Ergebnis = Addieren(Zahleins, Zahlzwei);

            if (Operation == 2)
                Ergebnis = Subtrahieren(Zahleins, Zahlzwei);

            if(Operation == 3)
                Ergebnis = Multiplizieren(Zahleins, Zahlzwei);

            if(Operation == 4)
                Ergebnis = Dividieren(Zahleins,Zahlzwei);

            Console.WriteLine("Ergebnis = " + Ergebnis);
            Console.ReadKey();
        }

        static double Addieren(double zahl1, double zahl2)
        {
            double Erg = zahl1 + zahl2;
            return Erg;
        }
        static double Subtrahieren(double zahl1, double zahl2)
        {
            double Erg = zahl1 - zahl2;
            return Erg;
        }
        static double Multiplizieren(double zahl1, double zahl2)
        {
            double Erg = zahl1 * zahl2;
            return Erg;
        }
        static double Dividieren(double zahl1, double zahl2)
        {
            double Erg = zahl1 / zahl2;
            return Erg;
        }


    }
}
