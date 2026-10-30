using System;

namespace FranzVociTrainer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string[] deutsch =
            {
                "Hund", "Katze", "Haus", "Schule", "Buch",
                "Wasser", "Brot", "Apfel", "Auto", "Freund",
                "Familie", "Stadt", "Tisch", "Stuhl", "Fenster",
                "Tür", "Zeit", "Tag", "Nacht", "Sonne",
                "Mond", "Baum", "Blume", "Meer", "Lehrer"
            };

            string[] franzoesisch =
            {
                "le chien", "le chat", "la maison", "l'ecole", "le livre",
                "l'eau", "le pain", "la pomme", "la voiture", "l'ami",
                "la famille", "la ville", "la table", "la chaise", "la fenetre",
                "la porte", "le temps", "le jour", "la nuit", "le soleil",
                "la lune", "l'arbre", "la fleur", "la mer", "le professeur"
            };

            int punkte = 0;

            Console.WriteLine("=== Französisch Voci-Trainer ===");
            Console.WriteLine("Schreibe das Wort auf Französisch (mit Artikel).");
            Console.WriteLine();

            for (int i = 0; i < deutsch.Length; i++)
            {
                Console.Write((i + 1) + ". " + deutsch[i] + ": ");
                string eingabe = Console.ReadLine() ?? "";

                if (eingabe.Trim().ToLower() == franzoesisch[i])
                {
                    Console.WriteLine("Richtig! +1 Punkt");
                    punkte++;
                }
                else
                {
                    Console.WriteLine("Falsch! Richtig ist: " + franzoesisch[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Du hast " + punkte + " von " + deutsch.Length + " Punkten.");

            if (punkte == deutsch.Length)
            {
                Console.WriteLine("Perfekt!");
            }
            else if (punkte >= 15)
            {
                Console.WriteLine("Gut gemacht!");
            }
            else
            {
                Console.WriteLine("Übe noch ein bisschen.");
            }

            Console.WriteLine();
            Console.WriteLine("Drücke eine Taste zum Beenden...");
            Console.ReadKey();
        }
    }
}