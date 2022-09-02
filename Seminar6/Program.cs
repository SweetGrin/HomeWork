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
//не используя рекурсию вывести первое N чисел отряда ФИбаначи.
//программа которая будет преобразововать 10 системы в 2ричную систему.
