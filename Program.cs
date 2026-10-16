Random r = new Random();
int zahl = r.Next(1, 101);
int tipp = 0;

Console.WriteLine("Rate eine Zahl von 1 bis 100.");

while (tipp != zahl)
{
    Console.Write("Tipp: ");
    tipp = Convert.ToInt32(Console.ReadLine());

    if (tipp < zahl)
    {
        Console.WriteLine("Zu klein!");
    }
    else if (tipp > zahl)
    {
        Console.WriteLine("Zu gross!");
    }
    else
    {
        Console.WriteLine("Richtig!");
    }
}