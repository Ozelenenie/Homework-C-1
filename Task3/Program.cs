// Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Напиши число, чтобы узнать чётное ли оно");

int a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("Да, четное");
}

else
{ 
Console.WriteLine("Нет");
}
   
