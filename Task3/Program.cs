//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Enter number");
string strNumber = Console.ReadLine();
int Number = Convert.ToInt32(strNumber);
if (Number % 2==0)
{
    Console.Write("Number is even");
}
else Console.Write("Number is not even");