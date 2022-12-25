//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Напишите число");
int N = Convert.ToInt32(Console.ReadLine());
int A = 1;

while (A<N)
{
Console.WriteLine(A*A*A);
A++;
}
Console.WriteLine(N*N*N);