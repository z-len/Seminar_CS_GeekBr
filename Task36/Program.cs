/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/ 
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SummOdd(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)

    {
        if (i % 2 == 1)
        {
            summ+=array[i];
        }
    }
    return summ;
}
int[] array = GetArray(10, -10, 10);
Console.WriteLine(string.Join(" , ", array));
int sum = SummOdd(array);
Console.WriteLine($"-> {sum}");