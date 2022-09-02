// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] randomArray1 = GetFillArray(3, 3);
Console.WriteLine("Матрица № 1:");
PrintArray(randomArray1);
Console.WriteLine();

int[,] randomArray2 = GetFillArray(3, 3);
Console.WriteLine("Матрица № 2:");
PrintArray(randomArray2);
Console.WriteLine();

if (randomArray1.GetLength(1) == randomArray2.GetLength(0))
{
int[,] matrix3 = Array(randomArray1, randomArray2);
Console.WriteLine("Произведение матриц");
PrintArray(matrix3);
}
else Console.WriteLine("Произведение матриц нельзя найти, поскольку число " +
                       "столбцов матрицы №1 неравно числу строк матрицы №2.");


int[,] GetFillArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random randomElement = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = randomElement.Next(10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] Array(int[,] matrix, int[,] matrix2)
{
    int[,] array = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int k = 0; k < matrix2.GetLength(1); k++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                array[i,k] += (matrix[i, j] * matrix2[j, k]);
            }
        }
    }
    return array;
}