// Задача 2: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int [] CreateArray(int len)
{
    int [] array = new int [len];
    for (int i = 0; i < len; i++)
    {
        int rnd = new Random().Next(-100, 100);
        array[i] = rnd;
    }
    return array;
}

int SumMass(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int [] arr = CreateArray(4);
PrintArray(arr);
int sumNum = SumMass(arr);
System.Console.WriteLine($" -> {sumNum} ");