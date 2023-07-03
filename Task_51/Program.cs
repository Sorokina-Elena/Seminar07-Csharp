/*
Задача 51
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
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

void sumElements(int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    int sum = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            if (j == i)
            {
                sum = sum + array[i,j];
            }
            
        }
    }
    Console.WriteLine($"Сумма элементов по диагонали равна {sum}");
    
}


 
int [,] array = creatArray(4, 4, -10, 10);
PrintArray(array);
Console.WriteLine();
int [,] array2 = newArray(array);
PrintArray(array);
sumElements(array);

