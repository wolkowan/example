﻿int[] arrey = { 1, 2, 3, 4, 5, 6, 7, 8 };
int n = arrey.Length;
int find = 4;
int index = 0;

while (index < n)
{
    if (arrey[index] == find)
    {
        Console.WriteLine(index);
        break;
    }

    index++;
}
