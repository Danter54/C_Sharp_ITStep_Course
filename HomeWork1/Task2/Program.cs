double number = 0, proc = 0;

Console.Write("Введите число >> ");
number = double.Parse(Console.ReadLine());

Console.Write("Введите процент >> ");
proc = double.Parse(Console.ReadLine());

Console.WriteLine(((proc / 100) * number).ToString());

