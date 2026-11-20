using System;

class Program
{
    static void Main()
    {
        Random zufall = new Random();

        int punkteSpieler = 0;
        int punkteComputer = 0;

        string[] auswahl = { "Schere", "Stein", "Papier" };

        Console.WriteLine("=== Schere - Stein - Papier ===");

        bool weiterSpielen = true;

        while (weiterSpielen)
        {
            // 1. Spieler waehlt
            Console.WriteLine();
            Console.WriteLine("Waehle:");
            Console.WriteLine("1 = Schere");
            Console.WriteLine("2 = Stein");
            Console.WriteLine("3 = Papier");
            Console.Write("Deine Wahl: ");

            string eingabe = Console.ReadLine();

            int spieler;
            if (eingabe == "1")
            {
                spieler = 0;
            }
            else if (eingabe == "2")
            {
                spieler = 1;
            }
            else if (eingabe == "3")
            {
                spieler = 2;
            }
            else
            {
                Console.WriteLine("Ungueltige Eingabe! Bitte 1, 2 oder 3 eingeben.");
                continue; // zurueck zum Anfang der Schleife
            }

            // 2. Computer waehlt zufaellig (0, 1 oder 2)
            int computer = zufall.Next(0, 3);

            Console.WriteLine("Du hast:       " + auswahl[spieler]);
            Console.WriteLine("Computer hat:  " + auswahl[computer]);

            // 3. Gewinner bestimmen
            if (spieler == computer)
            {
                Console.WriteLine("Unentschieden!");
            }
            else if ((spieler == 0 && computer == 2) ||   // Schere schlaegt Papier
                     (spieler == 1 && computer == 0) ||   // Stein schlaegt Schere
                     (spieler == 2 && computer == 1))     // Papier schlaegt Stein
            {
                Console.WriteLine("Du gewinnst!");
                punkteSpieler++;
            }
            else
            {
                Console.WriteLine("Der Computer gewinnt!");
                punkteComputer++;
            }

            // 4. Punktestand anzeigen
            Console.WriteLine("Punkte -> Du: " + punkteSpieler + "  Computer: " + punkteComputer);

            // 5. Nochmal spielen?
            Console.Write("Nochmal spielen? (j/n): ");
            string antwort = Console.ReadLine();

            if (antwort != "j")
            {
                weiterSpielen = false;
            }
        }

        Console.WriteLine();
        Console.WriteLine("Endstand -> Du: " + punkteSpieler + "  Computer: " + punkteComputer);
        Console.WriteLine("Danke fuers Spielen!");
        Console.ReadKey();
    }
}