/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/

int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result) )
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

float[,] InitMatrix(int M, int N)
{
    float[,] matrix = new float[M, N];
    Random rnd = new Random();
    for(int i = 0; i<matrix.GetLength(0); i++)
    {   for(int j = 0; j<matrix.GetLength(1); j++)
       {
         matrix[i,j] = ((float)rnd.NextDouble())*rnd.Next(100);
       }
    }
    return matrix;
}

void PrintMatrix(float[,] matrix)
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

PrintMatrix(InitMatrix(GetNumber("Введите кол-во строк"), GetNumber("Введите кол-во столбцов")));
