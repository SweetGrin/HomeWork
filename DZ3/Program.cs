// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// bool Palindrom(int number)
// {
// int a=number/1000;
// int b=number%100;
// if (a==b) 
// {
//  return true;
// }
// else
// {
//  return false;
// }
// }
// Console.Write (" Input digit number: ");
// int num= Convert.ToInt32(Console.ReadLine());
// bool palindrom =Palindrom(num);
// Console.WriteLine($"number is palindrom: {palindrom}");


//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double FindDistance(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double distance =  Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
//     return distance;
// }
// Console.Write (" Input xA: ");
// double xA= Convert.ToDouble(Console.ReadLine());
// Console.Write (" Input yA: ");
// double yA= Convert.ToDouble(Console.ReadLine());
// Console.Write (" Input zA: ");
// double zA= Convert.ToDouble(Console.ReadLine());
// Console.Write (" Input xB: ");
// double xB= Convert.ToDouble(Console.ReadLine());
// Console.Write (" Input yB: ");
// double yB= Convert.ToDouble(Console.ReadLine());
// Console.Write (" Input zB: ");
// double zB= Convert.ToDouble(Console.ReadLine());
// double distanceAB=FindDistance(xA,yA,zA,xB,yB,zB);
// Console.WriteLine($"Distance between points A({xA}, {yA}, {zA}) B({yA}, {yB}, {zB}) = {distanceAB} ");


//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
void FindCube(int N)
{
    double current=1;
    while (current<=N)
    {
      Console.WriteLine($"Cube {current} = {Math.Pow(current,3)}");
      current++;
    }
}
Console.Write (" Input digit: ");
int digit = Convert.ToInt32(Console.ReadLine());
FindCube(digit);