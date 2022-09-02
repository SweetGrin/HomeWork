//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] NewArray=new int[size];  

//     for(int i=0; i<size; i++)
//        NewArray[i]=new Random().Next(minValue, maxValue +1);
//     return NewArray;
// }
// void ShowArray(int[] array)
// {
//   for(int i=0; i<array.Length; i++)
//       Console.Write(array[i] +" ");
//   Console.WriteLine();
// }
// int SumPositiveElements(int[] array )
// {
//     int sum=0;
//     for( int i=0; i<array.Length; i++)
//     {
//         if(array[i]%2==0) sum++;
//     }
//     return sum;
// }

// Console.WriteLine("Input size for array: ");
// int a= Convert.ToInt32(Console.ReadLine());
// int[] myArray=CreateRandomArray(a,100,999);
// ShowArray(myArray);
// int result= SumPositiveElements(myArray);
// Console.WriteLine($"Summa positive elements = {result}");

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] NewArray=new int[size];  

//     for(int i=0; i<size; i++)
//        NewArray[i]=new Random().Next(minValue, maxValue +1);
//     return NewArray;
// }
// void ShowArray(int[] array)
// {
//   for(int i=0; i<array.Length; i++)
//       Console.Write(array[i] +" ");
//   Console.WriteLine();
// }
// int SumOddIndex(int[] array )
// {
//     int sumOdd=0;
//     for( int i=0; i<array.Length; i+=2)
//     {
//        sumOdd=array[i]+sumOdd; 
//     }
//     return sumOdd;
// }

// Console.WriteLine("Input size for array: ");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max= Convert.ToInt32(Console.ReadLine());
// int[] myArray=CreateRandomArray(a,min,max);
// ShowArray(myArray);
// int result = SumOddIndex(myArray);
// Console.WriteLine($"Sum odd elements = {result}");

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
double[] CreateRandomArray(int size, double maxsize)
{
    double[] NewArray=new double[size];  

    for(int i=0; i<size; i++)
       NewArray[i]=new Random().NextDouble()*maxsize;
    return NewArray;
}
void ShowArray(double[] array)
{
  for(int i=0; i<array.Length; i++)
      Console.Write(array[i] +" ");
  Console.WriteLine();
}
void DiffMinMax(double[] array )
{
    double minElements=array[0];
    double maxElements=array[0];
    for( int i=0; i<array.Length; i++)
    {
       if(array[i]<minElements)
       minElements=array[i];
       if(array[i]>maxElements)
       maxElements=array[i];
    }
Console.WriteLine($"difference between maximum {maxElements} and minimum {minElements} array element is {maxElements-minElements} ");
}

Console.WriteLine("Input size for array: ");
int a= Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max Value: ");
double max= Convert.ToDouble(Console.ReadLine());
double[] myArray=CreateRandomArray(a, max);
ShowArray(myArray);
DiffMinMax(myArray);

