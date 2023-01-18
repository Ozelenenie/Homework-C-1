// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число : ");
string number = Console.ReadLine();
int sum = 0;
for (int i = 0 ; i < number.Length ; i++)
{
    sum = sum + (number[i] - '0');
}
Console.WriteLine("Сумма цифр в числе равна " + sum);