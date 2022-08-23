int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i<array.Length;i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int FindMinMaxResult(int[] array)
{
    int result = 0;
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
             min = array[i];
        if (array[i] > max)
             max = array[i];
    }
    result = max - min;
    return result;
}

int[] array = CreateArray(5, 1, 99);
PrintArray(array);
int result = FindMinMaxResult(array);
Console.WriteLine();
Console.WriteLine($"разница между максимальным и минимальным {result}");