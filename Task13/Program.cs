// Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
string NumberText = Console.ReadLine();
if (NumberText.Length > 2)
{
  Console.WriteLine("третья цифра " + NumberText[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет");
}