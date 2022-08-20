// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int a = new Random().Next(10, 10000);
System.Console.WriteLine("Заданое число: " + a);

int x = 0;
 
while (a!=0)
{
    x = x + a%10;
    a = a/10;
}
System.Console.WriteLine(x);
