Console.WriteLine("Input (a+b) or (a-b):");
string user_string = Console.ReadLine();
string[] numbers;
char dedelimiter;

if(user_string.IndexOf('-') != -1)
{
    dedelimiter = '-';
    numbers = user_string.Split('-');
}
else
{
    dedelimiter = '+';
    numbers = user_string.Split('+');
}

switch (dedelimiter)
{
    case '-':
        Console.WriteLine($"Result = {int.Parse(numbers[0]) - int.Parse(numbers[1])}");
        break;
    case '+':
        Console.WriteLine($"Result = {int.Parse(numbers[0]) + int.Parse(numbers[1])}");
        break;
    default:
        Console.WriteLine("Invalid input!!!");
        break;
}
