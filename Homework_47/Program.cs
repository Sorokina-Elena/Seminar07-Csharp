/*
Задача 47
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Clear();

double [,] createArray(int m, int n, int min, int max)
{
Random rand = new Random();
double [,] myArray = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            myArray[i,j] = Math.Round(rand.Next(min, max) + rand.NextDouble(),2);
        }
    }
    return myArray;
}

void PrintArray(double[,] array)
 {
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
 }
 
 double [,] array = createArray(3, 4, -10, 10);
 PrintArray(array);