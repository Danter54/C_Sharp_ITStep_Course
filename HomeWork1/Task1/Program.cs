int number = 0;

while (true)
{
    Console.Write("Введите число >> ");
    number = int.Parse(Console.ReadLine());

    if (number < 1 || number > 100) Console.WriteLine("Ошибка!!!");
    else if (number % 3 == 0 && number % 5 == 0) Console.WriteLine("Fizz Buzz");
    else if (number % 3 == 0) Console.WriteLine("Fizz");
    else if (number % 5 == 0) Console.WriteLine("Buzz");
    else Console.WriteLine(number.ToString());
}