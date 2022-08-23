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

int FindSumm(int[] array)
{
    int summ = 0;
    for (int i = 0; i<array.Length; i++)
    {
        if (i % 2 !=0)
        summ = summ + array[i];
    }
    return summ;
}

int[] array = CreateArray(5,1,99);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"сумма = {FindSumm(array)}");