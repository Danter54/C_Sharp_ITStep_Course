int[] array1 = new int[5];
int[,] array2 = new int[3, 4];

Random random = new Random();

void FillArray(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
        Console.Write($"{i+1}. >> ");
        arr[i] = int.Parse(Console.ReadLine());
    }
}

void RandomFillArray(int[,] arr)
{
	for (int i = 0; i < arr.GetLength(0); i++)
	{
		for (int j = 0; j < arr.GetLength(1); j++)
		{
			arr[i, j] = random.Next(1, 10);
		}
	}
}

int GetSum(int[] arr1, int[,] arr2)
{
	int sum = 0;
	for (int i = 0; i < arr1.Length; i++)
	{
		sum+=arr1[i];
	}
	for (int i = 0; i < arr2.GetLength(0); i++)
	{
		for (int j = 0; j < arr2.GetLength(1); j++)
		{
			sum += arr2[i, j];
		}
	}
	return sum;
}

int MaximumOfTwoArrays(int[] arr1, int[,] arr2)
{
	int max = arr1[0];
	for (int i = 0; i < arr1.Length; i++)
	{
		if (arr1[i] > max)
		{
			for (int k = 0;  k < arr2.GetLength(0); k++)
			{
				for (int j = 0; j < arr2.GetLength(1); j++)
				{
					if (arr2[k, j] == arr1[i]) max = arr1[i];
				}
			}
		}
	}
	return max;
}

int MinimumOfTwoArrays(int[] arr1, int[,] arr2)
{
    int min = arr1[0];
    for (int i = 0; i < arr1.Length; i++)
    {
        if (arr1[i] < min)
        {
            for (int k = 0; k < arr2.GetLength(0); k++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (arr2[k, j] == arr1[i]) min = arr1[i];
                }
            }
        }
    }
    return min;
}

int GetPow(int[] arr1, int[,] arr2)
{
    int pow = 1;
    for (int i = 0; i < arr1.Length; i++)
    {
        pow *= arr1[i];
    }
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            pow *= arr2[i, j];
        }
    }
    return pow;
}

int GetSumOfEven(int[] arr1)
{
	int sum = 0;
	for (int i = 0; i < arr1.Length; i++)
	{
		if (arr1[i] % 2 == 0)
		{
			sum += arr1[i];
		}
	}
	return sum;
}

int GetSumOfOdd(int[,] arr2)
{
    int sum = 0;
	for (int i = 0; i < arr2.GetLength(0); i++)
	{
		for (int j = 0; j < arr2.GetLength(1); j++)
		{
			if (arr2[i,j]%2 !=0)
			{
				sum += arr2[i, j];
			}
		}
	}
    return sum;
}

Console.WriteLine("Заполните массив числами: ");
FillArray(array1);

Console.WriteLine("Заполнение массива случайными числами: ");
RandomFillArray(array2);

Console.WriteLine("Первый массив:");
for (int i = 0; i < array1.Length; i++)
{
	Console.Write($"{array1[i]} ");
}
Console.WriteLine();

Console.WriteLine("Второй массив:");
for (int i = 0; i < array2.GetLength(0); i++)
{
	for (int j = 0; j < array2.GetLength(1); j++)
	{
        Console.Write($"{array2[i,j]} ");
    }
	Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine($"Maximum of 2 arrays is {MaximumOfTwoArrays(array1, array2)}");
Console.WriteLine($"Minimum of 2 arrays is {MinimumOfTwoArrays(array1, array2)}");
Console.WriteLine($"Sum of all elements = {GetSum(array1, array2)}");
Console.WriteLine($"Pow of all elements = {GetPow(array1, array2)}");

Console.WriteLine($"Sum of all Even = {GetSumOfEven(array1)}");
Console.WriteLine($"Sum of all Odd = {GetSumOfOdd(array2)}");