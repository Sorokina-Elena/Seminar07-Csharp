/*
Задача 52
Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

int [,] findArithmeticMean (int[,] array)
{
    int row = array.GetLength(0);
    int col = array.GetLength(1);



    for (int j = 0; j < j+1 && j < col; j++)
    {
        double sum = 0;
        double result;
        for (int i = 0; i < row; i++)
        {
            sum = sum + array[i, j];
        }
        result = Math.Round(sum / row, 2);
        Console.WriteLine($"Сумма столбца {j+1} равна {sum}");
        Console.WriteLine($"Среднее арифметическое столбца равно {result}");
        Console.WriteLine();
        
    }
    return array;
}

 int [,] array = creatArray(6, 6, -10, 10);
 PrintArray(array);
 Console.WriteLine();
 findArithmeticMean(array);


