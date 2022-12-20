//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("N = ");
int N = Convert.ToInt32(Console.ReadLine());

int number = 2;

while (number < N)
{
    Console.WriteLine(number);
    number = number + 2;
}