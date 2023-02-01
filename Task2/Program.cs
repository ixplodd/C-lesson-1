//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Enter first number ");
string strNumA = Console.ReadLine();
int NumA = Convert.ToInt32(strNumA);

Console.WriteLine("Enter second number");
string strNumB = Console.ReadLine();
int NumB = Convert.ToInt32(strNumB);

Console.WriteLine("Enter third number");
string strNumC = Console.ReadLine();
int NumC = Convert.ToInt32(strNumC);

int max = NumA;
if (NumB>max) max = NumB;
if (NumC>max) max = NumC;
Console.Write("Max number is ");
Console.Write(max);