//int[] numbers = new int[10];
//Random random = new Random();

//for (int i = 0; i < numbers.Length; i++)
//{
//    numbers[i] = random.Next(0,9);
//}

using ConsoleApp1;

//string path = "MyFile.txt";

//for (int i = 0; i < numbers.Length; i++)
//{
//    File.AppendAllText(path,numbers[i].ToString() + ',');
//}


//string[] lines_numbers = File.ReadAllLines(path);

//int sum = 0;

//foreach (var numbers in lines_numbers)
//{
//    foreach (var number in numbers.Split(','))
//    {
//        sum += int.Parse(number);
//    }
//}

//Console.WriteLine($"Result = {sum}");

//5

//Random random = new Random();


//Console.WriteLine("Введите количество точек:");
//Console.Write(">> ");
//int length = int.Parse(Console.ReadLine());

//Point2D[] points = new Point2D[length];

//for (int i = 0; i < points.Length; i++)
//{
//    points[i] = new Point2D();
//    points[i].SetRandomValue();
//}

//foreach (var point in points)
//{
//    Console.WriteLine(point.ToString());
//}

//foreach (var point in points)
//{
//    File.AppendAllText(new_path, point.ToString() + '\n');
//}


//6
//string new_path = "Point2D.txt";
//string[] lines = File.ReadAllLines(new_path);

//Point2D[] points = new Point2D[lines.Length];

//for (int i = 0; i < points.Length; i++)
//{
//    points[i] = new Point2D();
//    points[i].SetValueFromString(lines[i]);
//}

//Console.WriteLine("Before:");
//foreach (var point in points)
//{
//    Console.WriteLine(point.ToString() + $" lenght = {point.GetLength()}");
//}

//for (int i = 0; i < points.Length; i++)
//{
//    for (int j = 0; j <points.Length - 1; j++)
//    {
//        if (points[j].GetLength() > points[j+1].GetLength())
//        {
//            Point2D temp = points[j];
//            points[j] = points[j+1];
//            points[j + 1] = temp;
//        }
//    }
//}
//Console.WriteLine("After:");

//foreach (var point in points)
//{
//    Console.WriteLine(point.ToString() + $" lenght = {point.GetLength()}");
//}

//7

//Добавить, вывести на екран, изменить, удалить, считать с файла, записать в файл,выйти
string new_path = "Point2D.txt";

int choice = -1;
int index = 0;
List<Point2D> points = new List<Point2D>();
Point2D point;
int x = 0, y = 0;
do
{
    Console.WriteLine("Menu:\n" +
        "0 - Добавить точку\n" +
        "1 - Изменить данные точки\n" +
        "2 - Удалить точку\n" +
        "3 - Вывести на экран\n" +
        "4 - Считать с файла\n" +
        "5 - Запистаь в файл\n" +
        "6 - Выход");
    Console.Write(">> ");
    choice = int.Parse(Console.ReadLine());
    switch (choice)
    {
        case 0:
            Console.WriteLine("Введите координаты: ");
            Console.Write("X >> ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Y >> ");
            y = int.Parse(Console.ReadLine());
            point = new Point2D(x, y);
            points.Add(point);
            Console.Clear();
            break;

        case 1:
            Console.WriteLine("Введите новые координаты: ");
            Console.Write("X >> ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Y >> ");
            y = int.Parse(Console.ReadLine());
            point = new Point2D(x, y);
            Console.WriteLine("Введите номер точки: ");
            index = int.Parse(Console.ReadLine());

            if (index <1 || index> points.Count)
            {
                Console.WriteLine("Ошибка индексации!!!");
                break;
            }
            else
            {
                points[index-1] = point;
            }
            Console.Clear();
            break;

        case 2:
            Console.Write("Какой элемент хотите удалить? >>");
            index = int.Parse(Console.ReadLine());
            if (index < 1 || index > points.Count) Console.WriteLine("Ошибка индексакции!!!");
            else points.RemoveAt(index - 1);
            break;

        case 3:
            if(points.Count == 0)
            {
                Console.WriteLine("Список пуст!!!");
                break;
            }
            Console.WriteLine("#\tX\tY\tLength\t");
            for (int i = 0; i < points.Count; i++)
            {
                Console.WriteLine($"{i + 1}\t{points[i].X}\t{points[i].Y}\t{points[i].GetLength()}\t");
            }
            Console.WriteLine("Нажмите Enter...");
            Console.ReadKey();
            Console.Clear();
            break;

        case 4:
            string[] lines = File.ReadAllLines(new_path);
            if (points.Count > 0) points.Clear();
            
            foreach (var line in lines)
            {
                point = new Point2D();
                point.SetValueFromString(line);
                points.Add(point);
            }
            break;

        case 5:
            File.Delete(new_path);
            string result = "";
            for (int i = 0; i < points.Count; i++)
            {
                result += points[i].ToString() + '\n';
            }
            File.AppendAllText(new_path, result);
            break;

        case 6:
            Console.WriteLine("Выход...");
            break;

        default:
            Console.WriteLine("Неверный ввод!!!");
            Console.Write("Введите ещё раз >> ");
            break;
    }

} while (choice != 6);