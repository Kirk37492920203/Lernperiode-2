using System;

class Program
{
    static void Main()
    {
        string[] deutsch = { "Hund", "Katze", "Haus", "Schule", "Buch",
                             "Wasser", "Brot", "Apfel", "Auto", "Freund",
                             "Familie", "Stadt", "Tisch", "Stuhl", "Fenster",
                             "Tür", "Zeit", "Tag", "Nacht", "Sonne",
                             "Mond", "Baum", "Blume", "Meer", "Lehrer" };

        string[] englisch = { "dog", "cat", "house", "school", "book",
                              "water", "bread", "apple", "car", "friend",
                              "family", "city", "table", "chair", "window",
                              "door", "time", "day", "night", "sun",
                              "moon", "tree", "flower", "sea", "teacher" };

        Random zufall = new Random();
        string auswahl = "";

        while (auswahl != "0")
        {
            Console.Clear();
            Console.WriteLine("=== Englisch Voci-Trainer ===");
            Console.WriteLine("1 = Alle Wörter üben");
            Console.WriteLine("2 = Mini-Prüfung (10 Wörter)");
            Console.WriteLine("0 = Beenden");
            auswahl = Console.ReadLine();

            if (auswahl == "1")
            {
                int punkte = 0;

                for (int i = 0; i < deutsch.Length; i++)
                {
                    Console.Write(deutsch[i] + ": ");
                    string eingabe = Console.ReadLine().ToLower();

                    if (eingabe == englisch[i])
                    {
                        Console.WriteLine("Richtig!");
                        punkte++;
                    }
                    else
                    {
                        Console.WriteLine("Falsch! Richtig ist: " + englisch[i]);
                    }
                }

                Console.WriteLine("Du hast " + punkte + " von " + deutsch.Length + " richtig.");
                Console.ReadKey();
            }
            else if (auswahl == "2")
            {
                int punkte = 0;

                for (int i = 0; i < 10; i++)
                {
                    int nr = zufall.Next(deutsch.Length);

                    Console.Write(deutsch[nr] + ": ");
                    string eingabe = Console.ReadLine().ToLower();

                    if (eingabe == englisch[nr])
                    {
                        Console.WriteLine("Richtig!");
                        punkte++;
                    }
                    else
                    {
                        Console.WriteLine("Falsch! Richtig ist: " + englisch[nr]);
                    }
                }

                double note = punkte / 10.0 * 5 + 1;
                Console.WriteLine("Du hast " + punkte + " von 10 Punkten.");
                Console.WriteLine("Deine Note: " + note);

                if (note >= 4)
                {
                    Console.WriteLine("Bestanden!");
                }
                else
                {
                    Console.WriteLine("Nicht bestanden.");
                }

                Console.ReadKey();
            }
        }
    }
}
