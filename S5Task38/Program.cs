//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

double [] array = {5, 7, 28, 76, 3};



double MaxNumber (double[]array)//определение максимального элемента
{
    double max = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (max < array[i])
		{
			max = array[i];
		}
	}
	return max;
}

double MinNumber (double[]array)// определение минимального элемента
{
    double min = array[0];
	for (int i = 0; i < array.Length; i++)
	{
		if (min > array[i])
		{
			min = array[i];
		}
	}
	return min;
}

double maxNum = MaxNumber(array);
double minNum = MinNumber(array);
double res = maxNum-minNum;
Console.Write($"разница между максимальным и минимальным элементов массива равна {res}");