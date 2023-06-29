//  Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> нет

int[] GetRandomArray()
{
    int[] array = new int[5];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(-9,10);
    }
    return array;
}

int[] array = GetRandomArray();
int count = 0;

Console.WriteLine("Ввeдите число ");
int numberFind = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < array.Length; i++)
{
    if(numberFind == array[i])
    {
        count++;
        break;
    }
}
if (count == 1)
{
    Console.WriteLine("Да ");
}
else
{
    Console.WriteLine("Нет ");
}
Console.WriteLine("Начальный массив это");
Console.WriteLine(string.Join(", ", array));