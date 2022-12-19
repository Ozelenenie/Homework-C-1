// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Особенностью метода Console.ReadLine() является то,
что он может считать информацию с консоли только в виде строки.
По умолчанию платформа .NET предоставляет ряд методов,
которые позволяют преобразовать различные значения к типам int, double и т.д.

Convert.ToInt32() (преобразует к типу int)

Convert.ToDouble() (преобразует к типу double)

Convert.ToDecimal() (преобразует к типу decimal)
*/

Console.WriteLine("Напишите два числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.Write("max = ");
    Console.WriteLine(a);
}
if (b > a)
{
    Console.Write("max = ");
    Console.WriteLine(b);
}