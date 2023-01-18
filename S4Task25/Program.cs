//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B

Console.WriteLine("Введите число A : ");
string numberA = Console.ReadLine();
Console.WriteLine("Введите число B : ");
string numberB = Console.ReadLine();
int A;
int B;
int.TryParse (numberA , out A);
int.TryParse (numberB , out B);

double pow = Math.Pow(A,B);

Console.WriteLine("A в степени B = " + pow);