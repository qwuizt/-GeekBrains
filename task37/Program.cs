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

int[] DoMultiplication(int[] array)
{
    int middleArrayIndex =  array.Length / 2;
    int[] myArray = new int[middleArrayIndex];
    for (int i = 0; i < middleArrayIndex; i++)
    {
        myArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return myArray;
}

 void PrintMultiplication(int[] array)
 {
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
 }

int[] array = CreateArray(5,1,9);
PrintArray(array);
Console.WriteLine();
int[] multiArray = DoMultiplication(array);
PrintMultiplication(multiArray);
