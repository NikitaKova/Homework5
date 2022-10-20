// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] array = {3, 7, 22, 2, 78};
double max = Max(array);
double min = Min(array);

double Max(double [] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(max < arr[i])
        {
            max = arr[i];
        }
    }
    return max;
}

double Min(double [] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if(min > arr[i])
        {
            min = arr[i];
        }
    }
    return min;
}
void PrintArray(double [] arr, double max, double min)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.Write($" -> {max - min} ");
}

PrintArray(array, max, min);