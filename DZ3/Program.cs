// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
int Palindron(int number)
{
int a=number/1000;
int b=number%100;
if (a=b)
}
Console.Write (" Input three-digit number: ");
int num= Convert.ToInt32(Console.ReadLine());
int polindrom =(Palindron(num));
Console.WriteLine(polindrom);