using ConsoleApp1;
using System.Drawing;

Squere s1 = new Squere(5f, "Tolik");

string[] colorNames = { "red", "green", "blue" };
ConsoleColor[] colorItems = { ConsoleColor.Red, ConsoleColor.Green, ConsoleColor.Blue };
int idx = -1;
int userChoose = 0;

do
{
    Console.Clear();
    for (int i = 0; i < colorNames.Length; i++)
    {
        if (userChoose == i)
        {
            Console.ForegroundColor = colorItems[userChoose];
            Console.Write("-->");
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.WriteLine(colorNames[i]);
    }

    if (Console.ReadKey().Key == ConsoleKey.UpArrow)
        userChoose -= 1;
    if (Console.ReadKey().Key == ConsoleKey.DownArrow)
        userChoose += 1;

    if (userChoose < 0) { idx = 0; userChoose = 0; }
    else if (userChoose > 2) { idx = 2; userChoose = 2; }
    else idx = userChoose;

} while (Console.ReadKey().Key != ConsoleKey.Enter);


Console.Clear();

Console.ForegroundColor = colorItems[idx];
Console.WriteLine(s1.GetPiture());
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Black;