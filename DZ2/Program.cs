//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
/*
int SecondDigit (int digit)
{
   int ed=digit/10;
   int sot=ed%10;
   return sot;
}
Console.Write (" Input three-digit number: ");
int number= Convert.ToInt32(Console.ReadLine());
int newDigit = SecondDigit (number);
Console.WriteLine($"Second digit is {number} of {newDigit}");
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int ThirdDigit(int a)
{ 
  while (a >= 1000) a /= 10;
 int digit = a % 10;
 return digit;
}
Console.Write ("Input number: ");
int number= Convert.ToInt32(Console.ReadLine());
if (number<100)
{
  Console.WriteLine("Digit the number does not have a 3rd digit");
  return;
}
int number3=ThirdDigit(number);
Console.WriteLine(number3);

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void WeekDays(int day)
{
 if(day==6 || day==7)
  {
     Console.WriteLine($"{day} - holiday");
  }
  else 
  {
    Console.WriteLine($" {day} - no holiday");
  }
}
Console.Write ("Input day week: ");
int d1= Convert.ToInt32(Console.ReadLine());
WeekDays(d1);
*/

