
using System;

Console.WriteLine("=== FARBENKOMBINATOR ===");

while (true)
{
    Console.WriteLine();
    Console.WriteLine("1 = Rot");
    Console.WriteLine("2 = Blau");
    Console.WriteLine("3 = Gelb");
    Console.WriteLine("4 = Grün");
    Console.WriteLine("5 = Beenden");

    Console.Write("Erste Farbe: ");
    string a = Console.ReadLine() ?? "";

    if (a == "5") break;

    Console.Write("Zweite Farbe: ");
    string b = Console.ReadLine() ?? "";

    string ergebnis = "Unbekannte Kombination";

    if (a == b)
        ergebnis = "Gleiche Farbe";
    else if ((a == "1" && b == "2") ||
             (a == "2" && b == "1"))
        ergebnis = "Lila";
    else if ((a == "1" && b == "3") ||
             (a == "3" && b == "1"))
        ergebnis = "Orange";
    else if ((a == "2" && b == "3") ||
             (a == "3" && b == "2"))
        ergebnis = "Grün";

    Console.WriteLine();
    Console.WriteLine("Ergebnis: " + ergebnis);
}

Console.WriteLine("Programm beendet.");
