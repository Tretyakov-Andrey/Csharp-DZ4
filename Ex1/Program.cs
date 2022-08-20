// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int a = new Random().Next(2, 10);
System.Console.WriteLine("A = "+ a );
int b = new Random().Next(2, 10);
System.Console.WriteLine("B = "+ b );
int x = a;

for (int i = 1; i < b; i++)
{
    a = a * x;
}
System.Console.WriteLine(a);

