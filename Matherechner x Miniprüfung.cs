using System;

namespace MatheRechner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ===== Teil 1: Rechner =====
            Console.WriteLine("=== Mathe-Rechner ===");

            Console.Write("Erste Zahl: ");
            double zahl1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Rechenzeichen (+, -, *, /): ");
            string zeichen = Console.ReadLine();

            Console.Write("Zweite Zahl: ");
            double zahl2 = Convert.ToDouble(Console.ReadLine());

            if (zeichen == "+")
            {
                Console.WriteLine("Ergebnis: " + (zahl1 + zahl2));
            }
            else if (zeichen == "-")
            {
                Console.WriteLine("Ergebnis: " + (zahl1 - zahl2));
            }
            else if (zeichen == "*")
            {
                Console.WriteLine("Ergebnis: " + (zahl1 * zahl2));
            }
            else if (zeichen == "/")
            {
                Console.WriteLine("Ergebnis: " + (zahl1 / zahl2));
            }
            else
            {
                Console.WriteLine("Falsches Rechenzeichen!");
            }

            // ===== Teil 2: Mini-Prüfung =====
            Console.WriteLine();
            Console.WriteLine("=== Mini-Prüfung ===");

            string[] aufgaben = { "5 + 3", "9 - 4", "6 * 2", "10 / 2", "7 + 8" };
            int[] loesungen = { 8, 5, 12, 5, 15 };

            int punkte = 0;

            for (int i = 0; i < aufgaben.Length; i++)
            {
                Console.Write(aufgaben[i] + " = ");
                int antwort = Convert.ToInt32(Console.ReadLine());

                if (antwort == loesungen[i])
                {
                    Console.WriteLine("Richtig!");
                    punkte++;
                }
                else
                {
                    Console.WriteLine("Falsch! Richtig ist: " + loesungen[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Du hast " + punkte + " von " + aufgaben.Length + " Punkten.");

            Console.ReadKey();
        }
    }
}
