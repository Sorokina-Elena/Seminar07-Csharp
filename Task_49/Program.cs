/*
Задача 49
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти 
элементы на их квадраты.

Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

Console.Clear();

int[,] creatArray(int row, int col, int min, int max)
{
    Random rand = new Random();
    int[,] array = new int[row,col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rand.Next(min,max+1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
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

int[,] newArray(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (i%2 ==1 && j%2 == 1)
            {
                array[i, j] =  (array[i, j])*(array[i, j]);
            }
        }
    }
    return array;
}

 
int [,] array = creatArray(3, 4, -10, 10);
PrintArray(array);
Console.WriteLine();
int [,] array2 = newArray(array);
PrintArray(array);
