// задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


double[] FillArray(int size, int start = 0, int end = 100)
{
    double[] array = new double[size];
    Random rand = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(start, end) + rand.NextDouble(), 2);
    }
    return array;
}


void PrintArray(double[] array)
{
    System.Console.WriteLine(string.Join(",  ", array));
}


double MinIndex(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
    }
    return min;
}


double MaxIndex(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
    }
    return max;
}

//--------------------------------------------------------------------------

int size = ReadInt("Задайте размер массива: ");
double[] array = FillArray(size);
PrintArray(array);
System.Console.WriteLine($"Минимальный элемент: {MinIndex(array)}");
System.Console.WriteLine($"Максимальный элемент: {MaxIndex(array)}");
double difference = MaxIndex(array) - MinIndex(array);
System.Console.WriteLine($"Разница между макс и мин элементами массива равна: {Math.Round(difference, 2)}");