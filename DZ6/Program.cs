//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь
int NumberСounter(int[] array)
{
 int sum=0;
 for(int i=0; i<array.Lenght; i++)
 {
   if(array[i]>0)
   sum++;
 }
 return sum;
}
int[] CreateRandomArray(int size)
{
    int[] NewArray=new int[size];  

    for(int i=0; i<size; i++)
    {
      
       Console.Write($"Введите число: ");
       NewArray[i]=Convert.ToInt32(Console.ReadLine());    
    }
    return NewArray;
}
void ShowArray(int[] array)
{
  for(int i=0; i<array.Length; i++)
      Console.Write(array[i] +" ");
  Console.WriteLine();
}

Console.Write("Введите окличество чисел для проверки: ");
int a= Convert.ToInt32(Console.ReadLine());
int[] myArray=CreateRandomArray(a);
ShowArray(myArray);
int result=NumberСounter(myArray);
Console.Write($"Количество чисел больit 0 равно {result}");