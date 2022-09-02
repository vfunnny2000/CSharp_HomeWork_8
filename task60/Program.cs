// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Н
// апишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



Console.WriteLine($"\nВведите размер массива X x Y x Z:");
int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      Console.Write($"X({i}) Y({j}) ");
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write( $"Z({k})={array3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}







// int[,,] array = { { {12, 13}, {22, 23} }, { {32, 33}, {42, 43} } };

// for(int i = 0; i < array.GetLength(0); i++) {
//     for(int j = 0; j < array.GetLength(1); j++) {
//         for(int k = 0; k < array.GetLength(2); k++) {
//             Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
//         }
//     }
//     Console.WriteLine();
// }






// int[] rndArray = RandomArray(90);
// int[,,] numberArray = GetFillArray(rndArray);

// PrintArray(numberArray);
// Console.WriteLine();

// int[] RandomArray(int length)
// {
//     Random rnd = new Random();
//     int[] number = new int[length];
//     for (int i = 0; i < number.Length; i++)
//     {
//         int a = rnd.Next(10, 100);
//         if (!number.Contains(a))
//         {
//             number[i] = a;
//         }
//         else
//             i--;
//     }
//     return number;
// }

// int[,,] GetFillArray(int[] number)
// {
//     int[,,] array = new int[2, 2, 2];
//     int h = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 array[i, j, k] = number[h];
//                 h++;
//             }
//         }
//     }
//     return array;
// }

// void PrintArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.WriteLine($"Элемент = {array[i, j, k]}; индекс = [{i},{j},{k}] ");
//             }
//         }
//     }
// }
