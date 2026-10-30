using System;

Console.WriteLine("Willkommen zum Kalorienrechner!");

Console.WriteLine("Welches Geschlecht hast du? (M/W)");
string geschlecht = Console.ReadLine().ToUpper();

Console.WriteLine("Wie alt bist du?");
int alter = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wie viel wiegst du in kg?");
double gewicht = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Wie gross bist du in cm?");
double grösse = Convert.ToDouble(Console.ReadLine());

double grundumsatz;

if (geschlecht == "M")
{
    grundumsatz = 88.362
        + (13.397 * gewicht)
        + (4.799 * grösse)
        - (5.677 * alter);
}
else
{
    grundumsatz = 447.593
        + (9.247 * gewicht)
        + (3.098 * grösse)
        - (4.330 * alter);
}

Console.WriteLine("Dein Grundumsatz pro Tag: "
    + Math.Round(grundumsatz) + " kcal");

Console.WriteLine("Dein Grundumsatz pro Woche: "
    + Math.Round(grundumsatz * 7) + " kcal");

Console.WriteLine();
Console.WriteLine("Wie viele Minuten pro Woche machst du Joggen?");
int joggen = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wie viele Minuten pro Woche machst du Schwimmen?");
int schwimmen = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wie viele Minuten pro Woche machst du Radfahren?");
int radfahren = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Wie viele Minuten pro Woche machst du Krafttraining?");
int krafttraining = Convert.ToInt32(Console.ReadLine());

double kalorienJoggen = joggen * 10;
double kalorienSchwimmen = schwimmen * 10;
double kalorienRadfahren = radfahren * 8;
double kalorienKrafttraining = krafttraining * 6;

double sportKalorien = kalorienJoggen
    + kalorienSchwimmen
    + kalorienRadfahren
    + kalorienKrafttraining;

double gesamtWoche = grundumsatz * 7 + sportKalorien;
double gesamtTag = gesamtWoche / 7;

Console.WriteLine("Geschlecht: " + geschlecht);
Console.WriteLine("Alter: " + alter + " Jahre");
Console.WriteLine("Gewicht: " + gewicht + " kg");
Console.WriteLine("Grösse: " + grösse + " cm");

Console.WriteLine();
Console.WriteLine("Sportkalorien pro Woche: "
    + Math.Round(sportKalorien) + " kcal");

Console.WriteLine("Geschätzter Verbrauch pro Tag: "
    + Math.Round(gesamtTag) + " kcal");

Console.WriteLine("Geschätzter Verbrauch pro Woche: "
    + Math.Round(gesamtWoche) + " kcal");

Console.ReadKey();