Random random = new Random();

void FillArray(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++)
	{
		for (int j = 0; j < array.GetLength(1); j++)
		{
			array[i, j] = random.Next(-100,100);
		}
	}
}

int GetSum(int[,] array)
{
    int minElement = array[0, 0];
    int maxElement = array[0, 0];
    Tuple<int, int> minIndex = new Tuple<int, int>(0, 0);
    Tuple<int, int> maxIndex = new Tuple<int, int>(0, 0);

    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            if (array[i, j] < minElement)
            {
                minElement = array[i, j];
                minIndex = new Tuple<int, int>(i, j);
            }

            if (array[i, j] > maxElement)
            {
                maxElement = array[i, j];
                maxIndex = new Tuple<int, int>(i, j);
            }
        }
    }

    Console.WriteLine($"Min = {minElement}");
    Console.WriteLine($"Max = {maxElement}");

    int sum = 0;
    int startRow = Math.Min(minIndex.Item1, maxIndex.Item1);
    int endRow = Math.Max(minIndex.Item1, maxIndex.Item1);
    int startCol = Math.Min(minIndex.Item2, maxIndex.Item2);
    int endCol = Math.Max(minIndex.Item2, maxIndex.Item2);

    for (int i = startRow; i <= endRow; i++)
    {
        for (int j = startCol; j <= endCol; j++)
        {
            sum += array[i, j];
        }
    }

    return sum;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j].ToString() + ' ');
        }
        Console.WriteLine();
    }
}

int[,] array = new int[5, 5];

FillArray(array);
PrintArray(array);

Console.WriteLine($"Sum = {GetSum(array)}");