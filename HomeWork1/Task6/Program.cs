Console.Write("Введите показания теспературы >> ");
double temperature = double.Parse(Console.ReadLine());
bool IsCelsius = false;
bool IsFareng = false;

Console.Write("По Фаренгейту - 1, по Цельсию - 2 >> ");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
	case 1:
		IsFareng = true;
		break;
	case 2:
		IsCelsius = true;
		break;
	default:
		break;
}

do
{
	Console.Write("Вывести температуру по Фаренгейту - 1, по Цельсию - 2 >> ");
	choice = int.Parse(Console.ReadLine());

	switch (choice)
	{
		case 1:
			if (IsFareng)
			{
				Console.WriteLine($"Температура по Фаренгейту = {temperature.ToString()}"); 
			}
			else
			{
				IsFareng = true;
				IsCelsius = false;
				temperature = (temperature * (9.0 / 5.0) + 32.0);
                Console.WriteLine($"Температура по Фаренгейту = {temperature.ToString()}");
            }
			break;
		case 2:
            if (IsCelsius)
            {
                Console.WriteLine($"Температура по Цельсию = {temperature.ToString()}"); 
            }
            else
            {
                IsFareng = false;
                IsCelsius = true;
				temperature = (temperature - 32.0) * (5.0 / 9.0);
                Console.WriteLine($"Температура по Цельсию = {temperature.ToString()}");
            }
            break;
		default:
			return;
	}
} while (true);

