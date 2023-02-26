double[] GetArray(int size)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
      result[i] = new Random().NextDouble() * 10;
    }

    return result;
}
    
double[] array = GetArray(10);
Console.WriteLine($"Массив: [{String.Join("; ", array)}]");

double min = array[0];
double max = array[0];
int size = array.Length;

for (int i = 0; i < size; i++)
{
    if (array[i] > max)
    {
      max = array[i];
    }

    if (array[i] < min)
    {
      min = array[i];
    }
}
double result;
result = max - min;
Console.WriteLine($"Максимальный элемент массива = {max}, минимальный элемент массива = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {result}");
