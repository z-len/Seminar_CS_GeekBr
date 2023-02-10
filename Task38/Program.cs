/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/ 
Console.Clear();
double[] GetArray(int size, double minValue, double maxValue)
{
    double[] res = new double[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().NextDouble(minValue, maxValue + 1) * 100;
        
    }
    return res;
}

// double DiffMaxMin(int[] array)
// {
//     double summ = 0;
//     for (int i = 0; i < array.Length; i++)

//     {
//         if (i % 2 == 1)
//         {
//             summ+=array[i];
//         }
//     }
//     return summ;
// }
double[] array = GetArray(10, -10, 10);
Console.WriteLine(string.Join(" , ", array));
// int sum = SummOdd(array);
// Console.WriteLine($"-> {sum}");

