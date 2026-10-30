using System;

class Program
{
    static double Addiere(double a, double b)
    {
        return a + b;
    }

    static double Subtrahiere(double a, double b)
    {
        return a - b;
    }

    static double Multipliziere(double a, double b)
    {
        return a * b;
    }

    static double Dividiere(double a, double b)
    {
        return a / b;
    }

    static void Main()
    {
        string nochmal;

        do
        {
            Console.WriteLine("===== Mathe-Rechner =====");
            Console.WriteLine("1 oder + = Plus");
            Console.WriteLine("2 oder - = Minus");
            Console.WriteLine("3 oder * = Mal");
            Console.WriteLine("4 oder / = Geteilt");
            Console.Write("Welche Rechnung willst du? ");
            string wahl = Console.ReadLine().Trim();

            Console.Write("Erste Zahl: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Zweite Zahl: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            if (wahl == "1" || wahl == "+")
            {
                Console.WriteLine("Ergebnis: " + Addiere(zahl1, zahl2));
            }
            else if (wahl == "2" || wahl == "-")
            {
                Console.WriteLine("Ergebnis: " + Subtrahiere(zahl1, zahl2));
            }
            else if (wahl == "3" || wahl == "*")
            {
                Console.WriteLine("Ergebnis: " + Multipliziere(zahl1, zahl2));
            }
            else if (wahl == "4" || wahl == "/")
            {
                if (zahl2 == 0)
                {
                    Console.WriteLine("Fehler: Durch 0 teilen geht nicht!");
                }
                else
                {
                    Console.WriteLine("Ergebnis: " + Dividiere(zahl1, zahl2));
                }
            }
            else
            {
                Console.WriteLine("Ungültige Auswahl! Du hast eingegeben: [" + wahl + "]");
            }

            Console.Write("Nochmal rechnen? (j/n): ");
            nochmal = Console.ReadLine().Trim();
            Console.WriteLine();

        } while (nochmal == "j");

        Console.WriteLine("Tschüss!");
    }
}