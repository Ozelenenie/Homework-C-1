// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.

Console.WriteLine("Введи пятизначное число");
string Number = Console.ReadLine();


if (Number[0] == Number[4] & Number[1] == Number[3] )
{
Console.WriteLine("Палиндр");
}
else 
Console.WriteLine("Не палиндр");


