﻿void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;

    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

int IndexOf(int[] collextion, int find)
{
    int count = collextion.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collextion[index] == find)
        {
            position = index;
        }
        index++;
    }
    return position;
}

FillArray(array);
PrintArray(array);

System.Console.WriteLine();

int pos = IndexOf(array, 4);

System.Console.WriteLine(pos);