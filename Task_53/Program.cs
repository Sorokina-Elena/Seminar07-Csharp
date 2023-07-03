/*
**Задача 53:** Задайте двумерный массив. Напишите программу, 
которая поменяет местами первую и последнюю строку массива

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/

Console.Clear();

int[,] creatArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}
 void PrintArray(int[,] array)
 {
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
 }
 

 int[,] newArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
   
    for (int i = 0; i < row; i++) 
    {   
        for (int j = 0; j < col; j++)
            {
            int temp = array[0,j];
            if (i == 0)
            {
                array[i,j] = array[row-1,j];
                array[row-1,j] = temp;
            }
        }
    }
    return array;
}

 int [,] array = creatArray(5, 5);
 PrintArray(array);
 Console.WriteLine();
 newArray(array);
 PrintArray(array);

