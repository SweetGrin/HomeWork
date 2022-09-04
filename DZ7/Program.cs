//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

// double[,] CreateRandom2DArray(int rows, int columns, double maxValue)
// {
//     double[,] NewArray=new double[rows, columns];  

//     for(int i=0; i< rows; i++)
//         for(int j = 0; j< columns; j++)
//         {
//             NewArray[i,j]=new Random().NextDouble()*maxValue - 1;
//         }
//     return NewArray;
// }
// void Show2dArray(double[,] array)
// {
//   for(int i=0; i<array.GetLength(0); i++)
//   {
//       for(int j=0; j<array.GetLength(1); j++)
//       {
//         array[i,j] = Math.Round(array[i,j], 1);
//         Console.Write(array[i,j] +" ");
//       }
      
//       Console.WriteLine();
//   }
// }
// Console.Write("Введите количество строк: ");
// int m= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int n= Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение элементов: ");
// double maxValue= Convert.ToDouble(Console.ReadLine());
// double[,] myArray=CreateRandom2DArray(m,n, maxValue);
// Show2dArray(myArray);


//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] newArray = new int[rows, columns];
//     for (int i = 0; i < rows; i++)
//         for (int j = 0; j < columns; j++)
//             newArray[i, j] = new Random().Next(minValue, maxValue + 1);
//     return newArray;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//             Console.Write(array[i, j] + " ");
//         Console.WriteLine();
//     }
// }
// void ElementSearch(int m, int n, int[,] array)
// {
//     string currentvalue;
//     if (m > array.GetLength(0) || n > array.GetLength(1))
//         Console.WriteLine("Элемента с данным индексом не существует в даной матрице");
//     else 
//     {
//         currentvalue = Convert.ToString(array[m - 1, n - 1]);
//         Console.WriteLine($"Под индексом [{m}, {n}] находится число {currentvalue}");
//     }
    
// }
// Console.Write("Введиче число строк: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введиче число столбцов: ");
// int j = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное возвожное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное возвожное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] myArray = CreateRandom2dArray(i, j, min, max);
// Show2dArray(myArray);
// Console.Write("Введите номер строки искомого элемента: ");
// int aX = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца искомого элемента: ");
// int aY = Convert.ToInt32(Console.ReadLine());
// ElementSearch(aX, aY, myArray);

//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
void AverageArray(int[,] array2d)
{
     for (int j = 0; j < array2d.GetLength(1); j++)
    {
        double arithmeticMean = 0;
        double sum = 0;
        for (int i = 0; i < array2d.GetLength(0); i++)
        {
            sum += array2d[i, j];
            arithmeticMean = Math.Round(sum / array2d.GetLength(0), 1);
        }
    
    Console.Write(arithmeticMean + " ");
    }
}
Console.Write("Введиче число строк: ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Введиче число столбцов: ");
int j = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возвожное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возвожное значение: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(i, j, min, max);
Show2dArray(myArray);
 Console.Write("Среднее арифметическое элементов в каждом столбце: ");
AverageArray(myArray);