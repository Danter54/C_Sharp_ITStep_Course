Console.Write("Введите дату (01.01.2001): ");
string input = Console.ReadLine();

string[] input_split = input.Split('.');

DateTime date =
    new DateTime(int.Parse(input_split[2]),
                int.Parse(input_split[1]), int.Parse(input_split[0]));

if (int.Parse(input_split[1]) >= 3 && int.Parse(input_split[1]) <= 5)
{
    Console.Write("Spring ");
}
else if (int.Parse(input_split[1]) >= 6 && int.Parse(input_split[1]) <= 8)
{
    Console.Write("Summer ");
}
else if (int.Parse(input_split[1]) >= 9 && int.Parse(input_split[1]) <= 11)
{ Console.Write("Autumn "); }
else Console.Write("Winter ");

    Console.WriteLine(date.DayOfWeek);
