//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


int[] array = new int[4];
int sum = 0;
int num = 0;
	
Random rand = new Random();                      //рандомный массив
for (int x = 0; x < array.Length; x++)
      {
          array[x] = rand.Next(100);
          Console.WriteLine( num + "index " + array[x]);
          num++;
      }

for (int i = 1; i < array.Length; i= i + 2)
{
sum = array[i] + sum;
}
Console.WriteLine("Сумма значений под нечётными индексами = " + sum);