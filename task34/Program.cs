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

int FindChetnyeArray(int[] array)
{
   int amount = 0;
   for (int i = 0; i<array.Length; i++)
   {
    if (array[i] % 2 == 0)
        amount = amount + 1; 
   } 
   return amount;
}


int[] array = CreateArray(5, 100, 999);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"количество четных чисел {FindChetnyeArray(array)}");
