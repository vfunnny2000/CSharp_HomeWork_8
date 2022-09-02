// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] array = ArrayUtils.GetArray(4,4,10);
// WriteLine("До сортировки:");
// ArrayUtils.Print(array);
// SortArray(array);
// WriteLine("После сортировки:");
// ArrayUtils.Print(array);

// void SortArray(int[,] array) {
//     for(int row = 0; row < array.GetLength(0); row++) {
//         bool needSort = true;
//         while(needSort) {
//             needSort = false;
//             for(int column = 0; column < array.GetLength(1) - 1; column++) {
//                 int v1 = array[row, column];
//                 int v2 = array[row, column + 1];
//                 if(v1 < v2) {
//                     array[row, column] = v2;
//                     array[row, column + 1] = v1;
//                     needSort = true;
//                 }
//             }
//         }
//     }
// }



int[,] randomArray = GetFillArray(5, 5);
PrintArray(randomArray);
Console.WriteLine();
int[,] sortArray = SortDescendingOrder(randomArray);
PrintArray(sortArray);


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
            Console.Write(array[i, j]  + "\t");
        }
        Console.WriteLine();
    }
}

int[,] SortDescendingOrder(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 0; k < array.GetLength(1); k++)
        {
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                int max = array[0, 0];
                int temp = 0;
                if (array[i, j] < array[i, j + 1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                }
            }
        }
    }
    return array;
}