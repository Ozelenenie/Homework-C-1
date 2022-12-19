// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Напишите три числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a > b & a > c)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}

else
if (b > a & b > c)
{
    Console.Write("max = ");
    Console.WriteLine(b);
}
else
if (c > a & c > a)
{
    Console.Write("max = ");
    Console.WriteLine(c);
}

