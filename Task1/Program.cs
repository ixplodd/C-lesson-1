//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Enter first number");
string? strA = Console.ReadLine();
int A = Convert.ToInt32(strA);

Console.WriteLine("Enter second number");
string? strB = Console.ReadLine();
int B = Convert.ToInt32(strB);
int max = A;
int min = B;
if (B>max) max = B;
{
    min = A;
}

Console.Write("Max number is ");
Console.WriteLine(max);
Console.Write("Min number is ");
Console.WriteLine(min);



