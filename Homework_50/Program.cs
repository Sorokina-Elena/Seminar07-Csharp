/*
Задача 50
Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
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

 void result(int inexRow, int indexCol, int[,] array)
 {
    int i;
    int j;
    int row = array.GetLength(0);
    int col = array.GetLength(1);
    for (i = 0; i < row; i++)
    {
        for (j = 0; j < col; j++)
        {
            if (i == (inexRow-1) && j == (indexCol-1))
            {
                Console.WriteLine($"Значение числа с заданной позицией равно {array[i, j]}\t");
            }
        }
    }


    
 }

Console.WriteLine("Введите кол-во строк создаваемого массива");
int numberLines = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов создаваемого массива");
int numberCol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
 
int [,] array = creatArray(numberLines, numberCol, -10, 10);
PrintArray(array);
Console.WriteLine();
 
Console.WriteLine("Введите индекс строки");
int indexRow = Convert.ToInt32(Console.ReadLine());
 
Console.WriteLine("Введите индекс столбца");
int indexCol = Convert.ToInt32(Console.ReadLine());

result(indexRow, indexCol, array);
if (indexRow > numberLines || indexCol > numberCol)
{
    Console.WriteLine("Такого числа нет в массиве");
}


