// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int  Exponentiation(int n, int s)
// {
//   int exp=1;
//   for(int current=1; current <= s; current++)
//   {
//     exp *=n; 
//   } 
//   return exp;
// }
// Console.Write (" Input A: ");
// int number= Convert.ToInt32(Console.ReadLine());
// Console.Write (" Input B: ");
// int power= Convert.ToInt32(Console.ReadLine());
// int result=Exponentiation(number,power);
//  Console.WriteLine($"Exponentiation {number} in {power} = {result}");

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumDigit(int a)
// {
//    int sum = 0;
//    while(a>0)
//   {
//     sum+=a%10;
//     a=a/10;
//   }  
// return sum;
// }
// Console.WriteLine("Input number: ");
// int number= Convert.ToInt32(Console.ReadLine());
// int result=SumDigit(number);
// Console.WriteLine($"Sum digit {number} = {result} ");

//Сгенирировать массив.
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


// Console.WriteLine("Input size for array: ");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input min: ");
// int min= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max: ");
// int max= Convert.ToInt32(Console.ReadLine());
// int[] myArray=CreateRandomArray(a,min,max);
// ShowArray(myArray);


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
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


// Console.Write("Input size for array: ");
// int a= Convert.ToInt32(Console.ReadLine());
// int[] myArray=CreateRandomArray(a);
// ShowArray(myArray);

