// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите целое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите натуральную степень числа: ");
int numB = int.Parse(Console.ReadLine());
Console.WriteLine($"{numA}, {numB} -> {GetNaturalDegree(numA, numB)}");

int GetNaturalDegree(int num1, int degree)
{
    int result = 1;
    if (num1 < 0) num1 *= (-1);
    for (int i = 0; i < degree; i++) result *= num1;
    return result;
}