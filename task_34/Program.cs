// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[a];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Вот наш массив: ");
PrintArray(numbers);
int count = 0;
for (int b = 0; b < numbers.Length; b++)
if (numbers[b] % 2 == 0)
count++;
Console.WriteLine($"четные числа массива {count}");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int с = 0; с < numbers.Length; с++)
    {
        numbers[с] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int с = 0; с < numbers.Length; с++)
    {
        Console.Write(numbers[с] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
