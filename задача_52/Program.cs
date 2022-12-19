/*
 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result))
    {
        isCorrect = true;
    } 
    else
    {
        Console.WriteLine("Некорректно ввели число");
    }
   } 
   return result;
}

int[,] InitMatrix(int M, int N)
{
    int[,] matrix = new int[M, N];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {   for(int j = 0; j<matrix.GetLength(1); j++)
       {
         matrix[i,j] = rnd.Next(100);
       }
    }
    return matrix;
}

float[] Average(int[,] matrix)
{
    float[] result = new float[matrix.GetLength(1)];
    for(int j = 0; j<matrix.GetLength(1); j++)
    {
        for(int i = 0; i<matrix.GetLength(0); i++)
        {
             result[j] += matrix[i,j];
        }
    }
    for(int k = 0; k<result.Length; k++)
    {
        result[k] = result[k]/matrix.GetLength(1);
    }
    return result;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
Console.Write($"{matrix[i,j]} ");
}
Console.WriteLine();
}
}



int[,] matrix = InitMatrix(GetNumber("Введите колво строк"),GetNumber("Введите колво столбцов"));
PrintMatrix(matrix);
float[] result = Average(matrix);
for(int i = 0; i < result.Length;i++)
{
    Console.Write($" {result[i]} ");
}