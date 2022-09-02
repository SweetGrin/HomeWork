// Перевернуть массив наоборот по парам.
// int[] ReversArray(int[]array)
// {
//   for(int i=0; i< array.Length /2; i++)
//   {
//     int temp=array[i];
//     array[i]=array[array.Length -1 - i];
//     array[array.Length -1 - i] = temp;
//   }  
//   return array;
// }
// // for(int i=0,j=array.Length -1; i<j; i++,j--)
// //   {
// //     int temp=array[i];
// //     array[i]=array[j];
// //     array[j] = temp;
// //   }  
// //   return array;
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
// int[] myArray=CreateRandomArray(a,1,1000);
// ShowArray(myArray);
// ShowArray(ReversArray(myArray));


//Принимает 3 числа. может ли существовать треугольник такой величины.
// bool CheckTriangle(int x, int y, int z)
// {
//   if((x<y+z) && (z<x+y)&&(y<x+z))
//      return true;
//   else
//   {
//     return false;
//   }
// }
// Console.WriteLine("Input side size A : ");
// int a= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input side size B: ");
// int b= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input side size C: ");
// int c= Convert.ToInt32(Console.ReadLine());
// bool result=CheckTriangle(a,b,c);
// Console.WriteLine(result);
//не используя рекурсию вывести первое N чисел отряда ФИбаначи.
// int[] Fibonachi(int a, int b,int N)
// {
//     int[] array=new int[N];
//     array[0]=a;
//     array[1]=b;
//     for( int i=2; i<N; i++)
//     {
//       array[i]=array[i-2]+array[i-1];
//     }
//     return array;
// }
// void ShowArray(int[] array)
// {
//   for(int i=0; i<array.Length; i++)
//       Console.Write(array[i] +" ");
//   Console.WriteLine();
// }
// Console.WriteLine("Input 1 number: ");
// int firstnumber= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input 2 number: ");
// int secondNumber= Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input size for array: ");
// int size= Convert.ToInt32(Console.ReadLine());
// ShowArray(Fibonachi(firstnumber,secondNumber,size));

//программа которая будет преобразововать 10 системы в 2ричную систему.
// void Sistem(int number)
// {
//    string result=string.Empty;
//    while(number>0)
//    {
//      result=number%2 + result;
//      number/=2;
//    }  
//    Console.WriteLine(result);
// }
// Console.WriteLine("Input  number: ");
// int num= Convert.ToInt32(Console.ReadLine());
// Console.Write($"Number {num} to binaty is ");

// Sistem(num);
