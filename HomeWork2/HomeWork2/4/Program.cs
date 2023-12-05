int[,] PowMatrix(int[,]array,int num)
{
    int[,] matrix = new int[array.GetLength(0), array.GetLength(1)];

	for (int i = 0; i < matrix.GetLength(0); i++)
	{
		for (int j = 0; j < matrix.GetLength(1); j++)
		{
			matrix[i, j] = array[i, j] * num;
		}
	}
	return matrix;
}

int[,] SumMatrix(int[,] array1, int[,]array2)
{
	if (array1.GetLength(0) != array2.GetLength(0) && array1.GetLength(1) != array2.GetLength(1)) return null;
	else
	{
		int[,] matrix = new int[array1.GetLength(0), array1.GetLength(1)];
		for (int i = 0; i < matrix.GetLength(0); i++)
		{
			for (int j = 0; j < matrix.GetLength(1); j++)
			{
				matrix[i, j] = array1[i, j] + array2[i, j];
            }
		}
		return matrix;
	}
}

int[,] PowMatrixOnMatrix(int[,] array1, int[,] array2)
{
	if (array1.GetLength(0) != array2.GetLength(1)) return null;
	else
	{
        int rowsA = array1.GetLength(0);
        int colsA = array1.GetLength(1);
        int colsB = array2.GetLength(1);

        int[,] result = new int[rowsA, colsB];

        for (int i = 0; i < rowsA; i++)
        {
            for (int j = 0; j < colsB; j++)
            {
                int sum = 0;

                for (int k = 0; k < colsA; k++)
                {
                    sum += array1[i, k] * array2[k, j];
                }

                result[i, j] = sum;
            }
        }

        return result;
    }
}