// Напишите программу, которая задает массив из 8 элементов случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции 



int[] RandomArray(int length)
{
    int[] array;
    array = new int[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 1000);
    }
    return array;
}

void PrintArray(int[] PArray)
{
    for (int j = 0; j < PArray.Length; j++)
    {
        Console.Write($"{PArray[j]} ");
    }
}

int[] myArray = RandomArray(8);

PrintArray(myArray);

