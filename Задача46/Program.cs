// Задача 46: Задайте двумерный массив 
// размером m×n, заполненный случайными 
// целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int ReadNumber(string messageToUser)
{
    Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}
// Пример двумерного массива
// {
//     {123, 324, 324, 23},
//     {123, 324, 324, 23},
//     {123, 324, 324, 23},
//     {123, 324, 324, 23},
// }
int[,] GetRandomMatrix (int rows, int columns, int leftBorder = 0, int rightBorder = 10)
{
    // int[,] matrix = {
    //     {123, 324, 324, 23},
    //     {123, 324, 324, 23},
    //     {123, 324, 324, 23},
    //     {123, 324, 324, 23}
    // };

    // matrix [1, 1] = 3;
   
    int[,] matrix = new int [rows, columns];
       for (int i = 0; i < matrix.GetLength(0); i++)
       {
           for (int j = 0; j < matrix.GetLength(1); j++)
           {
               matrix[i, j] = Random.Shared.Next(leftBorder,rightBorder);
           }
       }
       return matrix;
}

void PrintMatrix(int[,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
       {
           for (int j = 0; j < matrix.GetLength(1); j++)
           {
               Console.Write(matrix[i, j] + " "); 
           }
           Console.WriteLine();
       }
}

int m = ReadNumber("Введите колличество строк:");
int n = ReadNumber("Введите колличество столбцов:");
int [,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);

Console.WriteLine(string.Join(", ", myMatrix));