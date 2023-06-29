// Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива. (не использовать стандартные функции/методы)
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int a = 0; a < numbers.Length; a++)
{
    if (numbers[a] > max)
    {
        max = numbers[a];
    }
    if (numbers[a] < min)
    {
        min = numbers[a];
    }
}
Console.WriteLine($"Максимальное значение = {max}");
Console.WriteLine($"Минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
void FillArrayRandomNumbers(double[] numbers)
{
    for(int b = 0; b < numbers.Length; b++)
    {
        numbers[b] = Convert.ToDouble(new Random().Next(1,100));
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int b = 0; b < numbers.Length; b++)
    {
        Console.Write(numbers[b] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}