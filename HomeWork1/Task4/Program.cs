Console.Write("Введите 6-ти значное число >> ");
string number = Console.ReadLine();
int pos1, pos2;

Console.Write("Введите 1 позицию >> ");
pos1 = int.Parse(Console.ReadLine());

Console.Write("Введите 2 позицию >> ");
pos2 = int.Parse(Console.ReadLine());

if(pos1 <=1 || pos2 <=1 || pos1 >6 || pos2 > 6)
{
    Console.WriteLine("Ошибка индексации!!!");
    return;
}
else
{
    char[] digits = number.ToCharArray();
    char temp = digits[pos1 - 1];
    digits[pos1 - 1] = digits[pos2 - 1];
    digits[pos2 - 1] = temp;

    foreach (var item in digits)
    {
        Console.Write(item);
    }
    Console.WriteLine();
}