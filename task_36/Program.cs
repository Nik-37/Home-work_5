//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] array = GetArray(10, 1, 999);

Console.WriteLine($"Массив: [{String.Join("; ", array)}]");

int[] GetArray(int size, int minValue, int maxValue)
{
int[] result = new int[size];

for (int i = 0; i < size; i++)
  {
    result[i] = new Random().Next(minValue, maxValue);
  }
return result;
}

int result = 0;

for (int i = 1; i < array.Length; i+=2)
{
    result += array[i];
}

Console.WriteLine($"сумма элементов стоящих на нечетных позициях = {result}");