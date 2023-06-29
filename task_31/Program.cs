// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] GetRandomArray()
{
    int[] array = new int[12];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9,10);
    }
    return array;
}

int SumPositiveElements(int[] massive)
{
    int sumOfPositiveElements = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > 0)
        {
            //sumOfPositiveElements = sumOfPositiveElements + massive[i];
            sumOfPositiveElements += massive[i];
        }
    }
    return sumOfPositiveElements;
}

int SumNegativeElements(int[] massive)
{
    int sumOfPositiveElements = 0;
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < 0)
        {
            //sumOfPositiveElements = sumOfPositiveElements + massive[i];
            sumOfPositiveElements += massive[i];
        }
    }

    return sumOfPositiveElements;
}

int[] myArrey = GetRandomArray();
int SumPositive = SumPositiveElements(myArrey);
int SumNegative = SumNegativeElements(myArrey);

Console.WriteLine(string.Join(", ", myArrey));
Console.WriteLine($"Сумма положительных элементов равна = {SumPositive}");
Console.WriteLine($"Сумма отрицательных элементов равна = {SumNegative}");
