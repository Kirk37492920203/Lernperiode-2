using System;

namespace CSharpQuiz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] fragen =
            {
                "Welcher Datentyp speichert ganze Zahlen?",
                "Welcher Datentyp speichert Text?",
                "Mit welchem Befehl gibt man Text in der Konsole aus?",
                "Mit welchem Befehl liest man eine Eingabe ein?",
                "Mit welchem Zeichen endet eine Anweisung in C#?",
                "Welcher Datentyp speichert true oder false?",
                "Welche Schleife wiederholt Code eine bestimmte Anzahl Mal?",
                "Wie prüft man, ob zwei Werte gleich sind?",
                "Bei welchem Index beginnt ein Array?",
                "Welcher Datentyp speichert Kommazahlen?"
            };

            string[] optionen =
            {
                "a) int      b) string     c) bool",
                "a) double   b) string     c) char",
                "a) Console.ReadLine()     b) Console.WriteLine()     c) Console.Clear()",
                "a) Console.ReadLine()     b) Console.WriteLine()     c) Console.Beep()",
                "a) .        b) :          c) ;",
                "a) bool     b) int        c) string",
                "a) if       b) for        c) switch",
                "a) =        b) ==         c) !=",
                "a) 0        b) 1          c) -1",
                "a) int      b) char       c) double"
            };

            string[] loesungen = { "a", "b", "b", "a", "c", "a", "b", "b", "a", "c" };

            int punkte = 0;

            Console.WriteLine("=== C# Quiz ===");
            Console.WriteLine("Antworte mit a, b oder c.");
            Console.WriteLine();

            for (int i = 0; i < fragen.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + fragen[i]);
                Console.WriteLine("   " + optionen[i]);
                Console.Write("Deine Antwort: ");
                string eingabe = (Console.ReadLine() ?? "").Trim().ToLower();

                if (eingabe == loesungen[i])
                {
                    Console.WriteLine("Richtig! +1 Punkt");
                    punkte++;
                }
                else
                {
                    Console.WriteLine("Falsch! Richtig ist: " + loesungen[i]);
                }
                Console.WriteLine();
            }

            double note = Math.Round((double)punkte / fragen.Length * 5 + 1, 1);

            Console.WriteLine("Du hast " + punkte + " von " + fragen.Length + " Punkten.");
            Console.WriteLine("Deine Note: " + note);

            Console.WriteLine();
            Console.WriteLine("Drücke eine Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}
