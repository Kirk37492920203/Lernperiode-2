using System;

namespace MatheHelfer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] themen = { "plus", "minus", "mal", "geteilt", "prozent", "bruch" };

            string[] erklaerungen =
            {
                "Plus heisst zusammenzählen. Beispiel: 5 + 3 = 8",
                "Minus heisst abziehen. Beispiel: 9 - 4 = 5",
                "Mal heisst mehrmals zusammenzählen. Beispiel: 3 * 4 = 3 + 3 + 3 + 3 = 12",
                "Geteilt heisst aufteilen. Beispiel: 12 / 3 = 4 (12 Äpfel auf 3 Personen = je 4)",
                "Prozent heisst 'von Hundert'. Beispiel: 20% von 50 = 50 / 100 * 20 = 10",
                "Ein Bruch ist ein Teil vom Ganzen. Beispiel: 1/2 = die Hälfte, 1/4 = ein Viertel"
            };

            Console.WriteLine("=== Mathe-Helfer ===");
            Console.WriteLine("Themen: plus, minus, mal, geteilt, prozent, bruch");
            Console.WriteLine("Schreibe 'ende' zum Beenden.");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Welches Thema? ");
                string eingabe = Console.ReadLine().Trim().ToLower();

                if (eingabe == "ende")
                {
                    break;
                }

                bool gefunden = false;

                for (int i = 0; i < themen.Length; i++)
                {
                    if (eingabe == themen[i])
                    {
                        Console.WriteLine(erklaerungen[i]);
                        gefunden = true;
                    }
                }

                if (gefunden == false)
                {
                    Console.WriteLine("Dieses Thema kenne ich nicht.");
                }
            }
        }
    }
}