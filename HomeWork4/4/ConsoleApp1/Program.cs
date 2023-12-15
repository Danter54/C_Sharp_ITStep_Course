using ConsoleApp1;
using ConsoleApp1.Figures;

ListOfFigure list = new ListOfFigure();
int choice = 0;

do
{
    Console.WriteLine("What we do with figures:" +
        "1 - Add Figure" +
        "2 - Remove Figure" +
        "3 - Find Figure" +
        "4 - Output" +
        "5 - Exit");

    choice = int.Parse(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.WriteLine("Wich figure you want to create(1 - Squere, 2 - Circule, 3 - Triangle):");
            choice = int.Parse(Console.ReadLine());

            if (choice ==1)
            {
                Console.Write("Input side of squere: ");
                double side = double.Parse(Console.ReadLine());
                Squere sq = new Squere(side);
                list.AddFigure(sq);
            }
            else if(choice == 2)
            {
                Console.Write("Input radius of circule: ");
                double radius = double.Parse(Console.ReadLine());
                Circule circ = new Circule(radius);
                list.AddFigure(circ);
            }
            else if (choice==3)
            {
                Console.Write("Input radius of circule: ");
                double SideA = double.Parse(Console.ReadLine());
                double SideB = double.Parse(Console.ReadLine());
                double SideC = double.Parse(Console.ReadLine());

                Triangle tria = new Triangle(SideA, SideB,SideC);
                list.AddFigure(tria);
            }
            break;
        case 2:
            Console.WriteLine();
            break;
        case 3:
            break;
        case 4:
            if (list != null)
            {
                for (int i = 0; i < list.GetLength(); i++)
                {
                    Console.WriteLine(list.GetObject(i).ToString());
                }
            }
            break;
        case 5:
            Console.WriteLine("Exit...");
            break;
        default:
            Console.WriteLine("Invalid input!!!");
            break;
    }
} while (choice != 5);
