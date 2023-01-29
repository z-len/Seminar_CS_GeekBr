/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

Console.Clear();

int [] ReadArray()
{
    int[] array = new int[8];
    for(int i = 0; i<8; i++)
    {
        Console.Write("Введите число: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.Write($"{col[position]}, ");
        position++;
    }
}

int[] array1 = ReadArray(); 
PrintArray(array1);