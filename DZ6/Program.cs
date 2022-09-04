//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
// int NumberСounter(int[] array, int size)
// {
//  int sum=0;
//  for(int i=0; i<size; i++)
//  {
//    if(array[i]>0)
//    sum++;
//  }
//  return sum;
// }
// int[] CreateRandomArray(int size)
// {
//     int[] NewArray=new int[size];  

//     for(int i=0; i<size; i++)
//     {
      
//        Console.Write($"Введите число: ");
//        NewArray[i]=Convert.ToInt32(Console.ReadLine());    
//     }
//     return NewArray;
// }
// void ShowArray(int[] array)
// {
//   for(int i=0; i<array.Length; i++)
//       Console.Write(array[i] +" ");
//   Console.WriteLine();
// }

// Console.Write("Введите окличество чисел для проверки: ");
// int a= Convert.ToInt32(Console.ReadLine());
// int[] myArray=CreateRandomArray(a);
// ShowArray(myArray);
// int result=NumberСounter(myArray, a);
// Console.Write($"Количество чисел больше 0 равно {result}");

// //Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// void IntersectionPoint(double a, double b, double c, double d)
// {
//   var x = -(a - c) / (b - d);
//   var y = d * x + c;
//   Console.Write($"Точка пересечения двух прямых({x}:{y})");
// }

// Console.Write("Введите b1: ");
// var b1= Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k1: ");
// var k1= Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// var b2= Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// var k2= Convert.ToDouble(Console.ReadLine());
// if(b1==b2) 
// Console.WriteLine("Прямые парраллельны.");
// else
//   IntersectionPoint(b1,k1,b2,k2);
