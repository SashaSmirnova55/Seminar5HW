// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}


int[] FillArray(int size, int start = -99, int end = 100)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(start, end);
    }
    return array;
}


void PrintArray(int[] array)
{
    System.Console.WriteLine(string.Join(",  ", array));
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

//-------------------------------------------------------------------------

int size = ReadInt("Задайте размер массива: ");
int[] array = FillArray(size);
PrintArray(array);
System.Console.WriteLine($"Сумма элементов массива с нечётыми индексами равна: {Sum(array)}");