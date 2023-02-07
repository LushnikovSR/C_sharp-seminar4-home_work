// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.Clear();
Console.Write("Введите число - размер массива: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Введите минимальное значение для диапазона значений массива: ");
int minLevel = int.Parse(Console.ReadLine());
Console.Write("Введите максимальное значение для диапазона значений массива: ");
int maxLevel = int.Parse(Console.ReadLine());
int[] mas = GetArray(num, minLevel, maxLevel);
Console.WriteLine($"{String.Join(", ", mas)} -> [{String.Join(", ", mas)}]");

int[] GetArray(int LenArray, int min, int max)
{
    int[] array = new int[LenArray];
    for (int i = 0; i < LenArray; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}