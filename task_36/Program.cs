// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество чисел массива");
int x = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[x];
GRandomArray(numbers);
Console.WriteLine("Массив который получился: ");
PrintArray(numbers);
int sum = 0;
for (int a = 0; a < numbers.Length; a+=2)
sum = sum + numbers[a];
Console.WriteLine($"сумма элементов на нечётных позициях = {sum}");
void GRandomArray(int[] numbers)
{
    for(int b = 0; b < numbers.Length; b++)
    {
        numbers[b] = new Random().Next(-100,100);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int b = 0; b < numbers.Length; b++)
    {
        Console.Write(numbers[b] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}