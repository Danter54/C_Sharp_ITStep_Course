int a, b;
Console.WriteLine("Введите 2 числа:");

Console.Write("a >> ");
a = int.Parse(Console.ReadLine());

Console.Write("b >> ");
b = int.Parse(Console.ReadLine());

if (a > b)
{
    int temp = a;
    a = b;
    b = temp;
}

for (int i = a; i < b; i++)
{
    if (i%2==0)
    {
        Console.Write($"{i} ");

    }
}
Console.WriteLine();