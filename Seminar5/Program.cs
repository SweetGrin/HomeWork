// Задать массив из 12 элементов, заполненый случайными цислами с промежутком от -9  до +9. И посчитат сумму положительный и отрицательных элементов.


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
// void FindMinMaxSum(int[] array )
// {
//     int sumPositive=0;
//     int sumNegative=0;
//     for( int i=0; i<array.Length; i++)
//     {
//         if(array[i]>0)
//            sumPositive+=array[i];
//         else
//            sumNegative+=array[i]; 
//     }
//     Console.WriteLine($"Sum os Negativ elements {sumNegative}");
//     Console.WriteLine($"Sum os Positive elements {sumPositive}");
// }

// Console.WriteLine("Input size for array: ");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max= Convert.ToInt32(Console.ReadLine());
// int[] myArray=CreateRandomArray(a,min,max);
// ShowArray(myArray);
// FindMinMaxSum(myArray);


//Замена элементов массива положительные на отрицательные и наоборт.
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
// int[] MultArray(int[] array )
// {
    
//     for( int i=0; i<array.Length; i++)
//     {
//        array[i]=array[i] * (-1);  
//     }
//     return array;
// }

// Console.WriteLine("Input size for array: ");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max= Convert.ToInt32(Console.ReadLine());
// int[] myArray=CreateRandomArray(a,min,max);
// ShowArray(myArray);
// MultArray(myArray);
// ShowArray(myArray);



//Задать массив и напистаь программу которая определяет присутствует ли заданное число в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] NewArray=new int[size];  

//     for(int i=0; i<size; i++)
//     {
      
//        Console.Write($"Input element array at index {i}: ");
//        NewArray[i]=Convert.ToInt32(Console.ReadLine());    
//     }
//     return NewArray;
// }
// void ShowArray(int[] array)
// {
//   Console.WriteLine("Array:");
//   for(int i=0; i<array.Length; i++)
//       Console.Write(array[i] +" ");
//   Console.WriteLine();
// }
// bool NumberCearch(int[] array, int n)
// {
//    for(int i=0; i< array.Length; i++)
//    {
//       if(array[i]==n) return true;
//    } 
//    return false;
// }

// Console.Write("Input size for array: ");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.Write("Input number: ");
// int number= Convert.ToInt32(Console.ReadLine());
// int[] myArray=CreateRandomArray(a);
// ShowArray(myArray);
// bool chek = NumberCearch(myArray,number);
// if (chek==true)Console.WriteLine($"Number {number} found in array ");
// else Console.Write($"Number {number} not found in array ");

//Задайте одномерный массив из 12 случайных чисел. Необходимо найти количество элементов массива, которые лежат в отрезкке от 10 до 99.
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
// int CountElements(int[] array, int min, int max )
// {
//     int count=0;
//     for( int i=0; i<array.Length; i++)
//     {
//         if(array[i]>=min && array[i]<=max)count++;
//     }
//    return count;
// }
// Console.WriteLine("Input size for array: ");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input xA: ");
// int minA= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input yA: ");
// int maxA= Convert.ToInt32(Console.ReadLine());
// int[] myArray=CreateRandomArray(a,min,max);
// ShowArray(myArray);
// int result= CountElements(myArray, minA,maxA);
// Console.WriteLine($"Sum elements: {result}");

//Найти произведение пар чисел в одномерном массиве. Парой считается первый и последнйи элемент. Второй и предпоследний. Результат записать в новом массиве.
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
int [] newArray = new int[size];
for (int i = 0; i < size; i++)
    newArray[i] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int[] CompositionPairsOfElements(int[] array)
{
    int[] newArray = new int [array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        newArray[i] = array[i]*array[array.Length - 1 - i];
    }
   return newArray;
}
Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateRandomArray (a, min, max);
ShowArray(myArray);
ShowArray(CompositionPairsOfElements(myArray));